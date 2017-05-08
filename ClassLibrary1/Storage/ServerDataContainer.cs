using DataLab.Data.Users;
using DataLab.Data.Users.Message;
using DataLab.Server.Controller;
using DataLab.Server.Controller.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PlennerServer.Server
{
    [XmlRoot("ServerDataContainer")]
    public class ServerDataContainer
    {
        public ServerDataContainer() { }
        public ServerInfo Info { get; set; } = new ServerInfo();
        public ServerLog Log { get; set; }   = new ServerLog();
        public UserManager Uman { get; set; } = new UserManager();
        public MessageManager MsgMan { get; set; } = new MessageManager();
    }
}
