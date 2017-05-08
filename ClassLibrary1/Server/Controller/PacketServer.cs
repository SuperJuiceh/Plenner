
using DataLab.Data.Users;
using DataLab.Data.Users.Message;
using DataLab.Server.Controller.Logging;
using DataLab.Tools;
using PlennerServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Core;
using Windows.Networking;
using Windows.Networking.Sockets;

namespace DataLab.Server.Controller
{
    public sealed class PacketServer : INotifyPropertyChanged, IDisposable
    {
        // Our Database
        public ServerStorage Storage { get; set; } = new ServerStorage();

        private List<ConnectedClient> ConnectedClients { get; set; } = new List<ConnectedClient>();

        public bool Running { get; set; }

        private StreamSocketListener _socket = new StreamSocketListener();

        public event PropertyChangedEventHandler PropertyChanged;

        public int UsersOnline { get { return ConnectedClients.Count(); } }

        public PacketServer()
        {
        }

        public async void Activate()
        {
            //await _socket.BindServiceNameAsync("6001");
            await _socket.BindServiceNameAsync("8882");
            _socket.ConnectionReceived += Socket_ConnectionReceived;
            Storage.ServerData.Info.start();
            Storage.ServerData.Log.addLog("Started server", DataLab.Server.Controller.Logging.Log.LogTypes.Server_Status);
        }

        private async void Socket_ConnectionReceived(StreamSocketListener sender, StreamSocketListenerConnectionReceivedEventArgs args)
        {
            // Register every new client
            Storage.ServerData.Log.addLog("Clent connected: " + args.Socket.Information.LocalAddress, Log.LogTypes.User_Activity);
            if (Storage.ServerData.Info.RunStatus == ServerInfo.RunningStatus.RUNNING)
            {
                ConnectedClients.Add(new ConnectedClient(args.Socket, Storage, this));
                try
                {
                    await CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.High, () =>
                    {
                        Changed("UsersOnline");
                    });
                }
                catch (Exception ex)
                {
                    Storage.ServerData.Log.addLog(ex.Message);
                }
            }
        }


        public void pause()
        {
            Storage.ServerData.Info.pause();
        }

        public async void stop()
        {
            // End all current sessions with connected clients
            ConnectedClients.ForEach(client => client.shutDown());
            // Remove them from our list
            ConnectedClients.Clear();
            
            await _socket.CancelIOAsync();

            Storage.ServerData.Info.stop();
        }

        private void removeUnused()
        {
            //ConnectedClients.RemoveAll(ConnectedClients.Where(client => client.isRunning));
        }

        public void getOnlineUsers()
        {
            List<string> onlineUsers = new List<string>();

            ConnectedClients.ForEach(client =>
            {
                if (client.CurrentUser != null) {
                    onlineUsers.Add(client.CurrentUser.UserName);

                }
            });

            Storage.ServerData.Log.addLog("Users online: ", DataLab.Server.Controller.Logging.Log.LogTypes.Command_result);
            onlineUsers.ForEach(u => Storage.ServerData.Log.addLog(u));
        }

        public void userCommands(string filter, string filterParams)
        {
            List<string> onlineUsers = new List<string>();

            if (filter == "name")
            {
                Storage.ServerData.Uman.Users.Where(u => u.UserName.Contains(filterParams)).ToList().ForEach(us =>
               {
                   onlineUsers.Add(us.UserName);
               });
                if (onlineUsers.Count > 0)
                    Storage.ServerData.Log.addLog("Users Found: ", DataLab.Server.Controller.Logging.Log.LogTypes.Command_result);
            }
            else if (filter == "online")
            {
                ConnectedClients.ForEach(client =>
                {
                    if (client.CurrentUser != null)
                    {
                        if (client.CurrentUser.UserName.Contains(filterParams))
                        {
                            onlineUsers.Add(client.CurrentUser.UserName);
                        }
                    }
                });
                if (onlineUsers.Count > 0)
                    Storage.ServerData.Log.addLog("Users online: ", DataLab.Server.Controller.Logging.Log.LogTypes.Command_result);
            }
            else if (filter == "delete")
            {
                this.removeUser(filterParams);
            }
            else if (filter == "edit" || filter == "edit")
            {
                // Can we do the operation?
                if (Storage.ServerData.Uman.userExists(filterParams))
                {
                    Storage.ServerData.Uman.Users.ElementAt(0).UserName = "haha";

                }
            }

            // Add logs for all found users
            onlineUsers.ForEach(u => Storage.ServerData.Log.addLog(u));

        }

        public void createStuff(string[] data)
        {
            if (data.Length == 4 && data[0] == "new")
            {
                // new user Username Password
                if (data[1] == "user" && !Storage.ServerData.Uman.userExists(data[2]))
                {
                    Storage.ServerData.Uman.addUser(new User(data[2], PasswordHasher.hashPassword(data[3])));
                    Storage.ServerData.Log.addLog("User added: " + data[2]);
                }

            }

            // new mail From To Content
            if (data[1] == "mail" && Storage.ServerData.Uman.userExists(data[2]))
            {
                Storage.ServerData.MsgMan.MailMan.addMail(Storage.ServerData.Uman, new Mail(data[2], new List<string> { data[3] }, data[4]));
                Storage.ServerData.Log.addLog(String.Format("{0} sent mail to {1}", data[2], data[3]), Log.LogTypes.User_Activity);
            }
        }
        
        private void removeUser(string name)
        {
            bool canRemove = Storage.ServerData.Uman.userExists(name);

            if (canRemove)
            {
                Storage.ServerData.Uman.Users.Remove(Storage.ServerData.Uman.Users.First(u => u.UserName == "name"));
                Storage.ServerData.Log.addLog("Removed user: " + name, DataLab.Server.Controller.Logging.Log.LogTypes.Command_result);
                // Disconnect the client if in use
                try
                {
                    Tuple<bool, ConnectedClient> ownedClient = userClient(name);
                    if (ownedClient.Item1)
                    {
                        ownedClient.Item2.shutDown();
                        ConnectedClients.Remove(ownedClient.Item2);
                    }
                }
                catch (Exception) { }
            }
        }


        public Tuple<bool, ConnectedClient> userClient(string username)
        {
            bool b = ConnectedClients.Exists(cl => cl.CurrentUser.UserName == username);
            ConnectedClient client = null;

            if (b) 
                client = ConnectedClients.First(cl => cl.CurrentUser.UserName == username);
            
            return new Tuple<bool, ConnectedClient>(b, client);
        }

        public void removeClient(ConnectedClient cl)
        {
            ConnectedClients.Remove(cl);
        }

        public void Changed(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public void Dispose()
        {
            _socket.Dispose();
        }
    }
}
