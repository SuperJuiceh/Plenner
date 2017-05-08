using DataLab.Storage;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlennerServer.Server
{
    public class ServerStorage: Storage
    {

        public ServerDataContainer ServerData { get { return (ServerDataContainer)StorageObject; } set { this.StorageObject = value; } } 

        public ServerStorage(): base("server.pln", typeof(ServerDataContainer))
        {
            Debug.WriteLine(this.SaveLocation.Path);

        }
        
    }
}
