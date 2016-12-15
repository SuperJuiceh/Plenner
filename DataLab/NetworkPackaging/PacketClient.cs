using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using DataLab.Server.Packets;
using System.Xml.Serialization;
using System.IO;
using Windows.Networking.Sockets;
using Windows.Networking;
using Windows.Foundation;
using System.Xml;
using Windows.Data.Xml.Dom;
using Datalab.Server.Packets;
using System.Threading;

namespace DataLab.NetworkPackaging
{
    public class PacketClient
    {
        public static StreamSocket _client;

        public static bool Connected { get; set; } = false;

        public static bool Locked { get; set; } = false;

        public static bool DataAvailable { get { return new StreamReader(_client.InputStream.AsStreamForRead()).Peek() != 0; } }

        public static async Task Connect()
        {
            if (!Locked)
            {
                Locked = true;
                
                connect_start:
                try
                {
                    _client = new StreamSocket();

                    CancellationTokenSource cancelToken = new CancellationTokenSource(5000);

                    await _client.ConnectAsync(new HostName("192.168.1.132"), "8882").AsTask(cancelToken.Token);

                    Connected = true;
                }
                catch (Exception e)
                {
                    if (e is TaskCanceledException)
                        return;

                    await Task.Delay(1000);
                    goto connect_start;
                }

                Locked = false;
            }
        }

        public static async Task Disconnect()
        {
            if (!Locked)
            {
                Locked = true;
                await _client.CancelIOAsync();
                _client.Dispose();

                Connected = Locked = false;
                
            }

        }
        
        public static void sendPacket(Packet p)
        {
            if (Connected && !Locked)
            {
                Locked = true;
                try
                {
                    XmlSerializer serializer = new XmlSerializer(p.GetType());

                    StreamWriter writer = new StreamWriter(_client.OutputStream.AsStreamForWrite());
                    serializer.Serialize(writer, p);
                }
                catch (InvalidOperationException ex)
                {
                    for (Exception message = ex; message.InnerException != null; message = message.InnerException)
                    {
                        Debug.WriteLine(message.InnerException);
                    }

                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
                Locked = false;
            }
            // Wait for return packet   
        }
        
        public static Packet receivePacket()
        {
            if (Connected && !Locked)
            {
                Locked = true;
                try
                {
                    //Debug.WriteLine("Trying stuff with Write Stream. Can read: {0}, Can Write: {1}. Length: {2}, Position: {3}", _client.InputStream.AsStreamForRead().CanRead, _client.InputStream.AsStreamForRead().CanWrite, _client.InputStream.AsStreamForRead().Length, _client.InputStream.AsStreamForRead().Position);
                    StreamReader reader = new StreamReader(_client.InputStream.AsStreamForRead());
                    StringBuilder lol = new StringBuilder();
                    while (reader.Peek() > 0)
                    {
                        lol.Append((char)reader.Read());
                    }
                    // Get the type
                    Type serializationType = xmlStringToType(lol.ToString());
                    // Do we have a recognized type?
                
                    if (serializationType != null)
                    {
                        Packet packet = new XmlSerializer(serializationType).Deserialize(new StringReader(lol.ToString())) as Packet;

                        if (packet != null)
                        {
                            Locked = false;
                            return packet;
                        }
                    }
                    lol.Clear();
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.Message);
                }
            }

            Locked = false;
            // Wait for return packet         
            return null;
        }

        public static Packet SendAndReceive(Packet p)
        {
            sendPacket(p);
            return receivePacket();
        }

        //public static User SyncUser(Packet p)
        //{
        //}

        public static Type xmlStringToType(string xml)
        {
            Windows.Data.Xml.Dom.XmlDocument document = new Windows.Data.Xml.Dom.XmlDocument();
            document.LoadXml(xml);

            // Get the type
            return Type.GetType("DataLab.Server.Packets." + document.ChildNodes[1].LocalName + ", DataLab, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null");
        }


    }
}
