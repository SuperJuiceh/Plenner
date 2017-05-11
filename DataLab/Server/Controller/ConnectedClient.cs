using DataLab.Server.Packets;
using DataLab.Data.Planning;
using DataLab.Data.Users;
using DataLab.Data.Users.Message;
using PlannerServer.Server;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Windows.Data.Xml.Dom;
using Windows.Networking.Sockets;
using static DataLab.Data.Users.Contracts.PlanningContract;
using static DataLab.Data.Users.UserManager;
using Datalab.Server.Packets;
using DataLab.Server.Controller.Login;

namespace DataLab.Server.Controller
{
    public sealed class ConnectedClient: IDisposable
    {

        private StreamSocket _socket;

        private BackgroundWorker _thread = new BackgroundWorker();

        private ServerStorage Storage { get; set; }

        public  User        CurrentUser { get; set; } = null;

        private PacketServer _mainServ;

        public ConnectedClient(StreamSocket socket, ServerStorage storage, PacketServer _serv)
        {
            this._socket = socket;
            this.Storage = storage;
            this._mainServ = _serv;

            // Start running the thread
            this._thread.DoWork += _thread_DoWork;
            this._thread.WorkerSupportsCancellation = true;
            this._thread.WorkerReportsProgress = true;
            this._thread.RunWorkerAsync();
        }

        private void _thread_DoWork(object sender, DoWorkEventArgs e)
        {
            while (!e.Cancel)
            {
                try
                {
                    StreamReader reader = new StreamReader(_socket.InputStream.AsStreamForRead());

                    try
                    {
                        if (reader.Peek() > 0)
                        {
                            StringBuilder builder = new StringBuilder();
                            while (reader.Peek() > 0)
                            {
                                builder.Append((char)reader.Read());
                            }
                            // Get the type
                            Type serializationType = xmlStringToType(builder.ToString());
                            if (serializationType != null)
                            {
                                //_mainServ.Storage.ServerData.Log.addLog("Received Packet, Type = "+ serializationType.ToString(), Logging.Log.LogTypes.Server_Status);
                                Packet p = null;
                                if (serializationType.Equals(typeof(QuestionPacket)))
                                {
                                    p = new XmlSerializer(serializationType).Deserialize(new StringReader(builder.ToString())) as QuestionPacket;
                                }

                                if (p != null)
                                {
                                    if (p is QuestionPacket)
                                    {
                                        Packet pakketje = handleQuestionPacket(p);
                                        // send back the packet
                                        StreamWriter writer = new StreamWriter(_socket.OutputStream.AsStreamForWrite());
                                        try
                                        {
                                            new XmlSerializer(p.GetType()).Serialize(writer, p);
                                            _socket.OutputStream.AsStreamForWrite().Flush();
                                            _mainServ.Storage.ServerData.Log.addLog("Sending Packet, Type = " + serializationType.ToString(), Logging.Log.LogTypes.User_Activity);
                                        }
                                        catch (Exception ex)
                                        {
                                            _mainServ.Storage.ServerData.Log.addLog(ex.Message, Logging.Log.LogTypes.User_Activity);
                                        }
                                    }
                                    else if (p is OneWayPacket)
                                    {
                                        handleOneWayPacket(p as OneWayPacket);
                                        //handleMessagePacket(p);
                                    }

                                }
                            }
                        }
                    }
                    catch (InvalidOperationException ex)
                    {
                        for (Exception message = ex; message.InnerException != null; message = message.InnerException)
                        {
                            Debug.WriteLine(message.InnerException);
                        }
                    }
                } catch (SocketException)
                {
                    this.Dispose();
                }

            }
        }

        private Packet handleQuestionPacket(Packet p)
        {
            if (p is QuestionPacket)
            {
                QuestionPacket q = p as QuestionPacket;
                if (q.Q == QuestionPacket.Questions.Valid_password)
                {
                    q.A = Storage.ServerData.Uman.Users.Exists(u => u.UserName == (string)q.Question_data[0] && u.Password == (string)q.Question_data[1]);

                    if (q.A)
                    {
                        User foundUser = Storage.ServerData.Uman.Users.First(u => u.UserName == (string)q.Question_data[0] && u.Password == (string)q.Question_data[1]);
                        foundUser.Mails = new ObservableCollection<Mail>(Storage.ServerData.MsgMan.MailMan.getMailFrom(foundUser.UserName).Item2);
                        q.Question_data[2] = foundUser;

                        CurrentUser = foundUser;
                        //public static QuestionPacket AskIfPasswordIsValid(string username, string password, bool withToken)
                        //{
                        //    // object: username, password, user, token? , token (optional:)
                        //    return new QuestionPacket(Questions.Valid_password, new object[] { username, password, null, withToken, null });
                        //}
                        
                        // Remember password functionality
                        if ((bool)q.Question_data[3])
                        {
                            q.Question_data[4] = createLoginToken((string)q.Question_data[1], (string)q.Question_data[0]);
                        }
                        
                    } 
                    return q;
                }
                else if (q.Q == QuestionPacket.Questions.Valid_token)
                {
                    //public static QuestionPacket AskIfTokenIsValid(string username, int token, string deviceID)
                    //{
                    //    // object: username, password, deviceID, user
                    //    return new QuestionPacket(Questions.Valid_token, new object[] { username, token, deviceID, null });
                    //}
                    q.A = Storage.ServerData.TokenMan.isValid((string)q.Question_data[0], (int)q.Question_data[1], (string)q.Question_data[2]);
                    //q.A = Storage.ServerData.Uman.Users.Exists(u => u.UserName == (string)q.Question_data[0] && u.Password == (string)q.Question_data[1]);

                    if (q.A)
                    {
                        User foundUser = Storage.ServerData.Uman.Users.First(u => u.UserName == (string)q.Question_data[0] && u.Password == (string)q.Question_data[1]);
                        foundUser.Mails = new ObservableCollection<Mail>(Storage.ServerData.MsgMan.MailMan.getMailFrom(foundUser.UserName).Item2);
                        q.Question_data[3] = foundUser;

                        CurrentUser = foundUser;

                        // Remember password functionality

                    }
                    return q;
                }
                else if (q.Q == QuestionPacket.Questions.Registration)
                {
                    User user = (User)q.Question_data[0];
                    Registration_Answer answer = Storage.ServerData.Uman.addUser(user);
                    q.A = (answer == Registration_Answer.SUCCEEDED);
                    q.Question_data[1] = answer;
                    _mainServ.Storage.ServerData.Log.addLog("User registered: " + user.ToString());
                    CurrentUser = user;
                    q.Question_data[3] = createLoginToken((string)q.Question_data[2], user.UserName);

                    return q;
                }
                else if (q.Q == QuestionPacket.Questions.Is_username_available)
                {
                    q.A = !Storage.ServerData.Uman.userExists((string)q.Question_data[0]);
                    _mainServ.Storage.ServerData.Log.addLog("Username " + (string)q.Question_data[0] + " available: " + q.A);
                    return q;
                }
                else if (q.Q == QuestionPacket.Questions.Is_Online)
                {
                    q.A = _mainServ.userClient((string)q.Question_data[0]).Item1;
                    return q;
                }
                else if (q.Q == QuestionPacket.Questions.Get_user)
                {
                    User foundUser = Storage.ServerData.Uman.Users.First(u => u.UserName == (string)q.Question_data[0]);

                    q.A = foundUser != null;

                    if (q.A)
                    {
                        q.Question_data[1] = foundUser;
                        CurrentUser = foundUser;
                    }
                }
                else if (q.Q == QuestionPacket.Questions.Sync_user)
                {
                    q.A = (CurrentUser != null);
                    
                    if (q.A)
                    {
                        User user = (User)q.Question_data[0];
                        CurrentUser.Mails = new ObservableCollection<Mail>(Storage.ServerData.MsgMan.MailMan.getMailFrom(CurrentUser.UserName).Item2);
                        Storage.ServerData.Log.addLog("Found Mails: " + CurrentUser.Mails.Count, Logging.Log.LogTypes.User_Activity);

                        CurrentUser.plan = CurrentUser.plan + user.plan;
                        user.plan = CurrentUser.plan;
                        q.Question_data[0] = user;
                    }
                }
                else if (q.Q == QuestionPacket.Questions.Valid_username)
                {
                    q.A = (Storage.ServerData.Uman.Users.Exists(u => u.UserName.Equals((string)q.Question_data[0])));
                }
            }
            return p;
        }

        private void handleOneWayPacket(OneWayPacket packet)
        {

            if (packet.Do == OneWayPacket.What.SEND_MESSAGE)
            {
                Mail mail = (Mail)packet.PacketData[0];
                Storage.ServerData.MsgMan.MailMan.addMail(Storage.ServerData.Uman, mail);
            }

            if (packet.Do == OneWayPacket.What.GRANT_PERMISSIONS)
            {
                List<object> permissions = (List<object>)packet.PacketData[1];
                string to = (string)packet.PacketData[0];
                // Add permissions if user exists
                if (Storage.ServerData.Uman.userExists(to)) {
                    // create new conctract (if not present)
                    Storage.ServerData.Uman.PermissionMan.createContractForUser(Storage.ServerData.Uman.getUser(to), CurrentUser);

                    permissions.ForEach(permission =>
                    {
                        Storage.ServerData.Uman.PermissionMan.addPermission(permission, CurrentUser, Storage.ServerData.Uman.getUser(to));
                        Debug.WriteLine("Writing {0} to {1} granted by {2}", permission.ToString(), to, CurrentUser.UserName);
                    });
                }
            }
            if (packet.Do == OneWayPacket.What.SEND_CHAT)
            {
                // get permissions
                
                //Storage.ServerData.MsgMan.ChatMan.addChat();
            }


        }

        private LoginToken createLoginToken(string deviceID, string username)
        {
            return Storage.ServerData.TokenMan.createToken(deviceID, username);
        }

        public Type xmlStringToType(string xml)
        {
            Windows.Data.Xml.Dom.XmlDocument document = new Windows.Data.Xml.Dom.XmlDocument();
            document.LoadXml(xml);

            return Type.GetType("DataLab.Server.Packets." + document.ChildNodes[1].LocalName + ", DataLab, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null");
        }

        public async void shutDown()
        {
            await _socket.CancelIOAsync();
            this.Dispose();
        }

        public void Dispose()
        {
            _socket.Dispose();            
            _thread.Dispose();
            _mainServ.removeClient(this);
        }

        ~ConnectedClient()
        {
            this.Dispose();
        }
    }
}
