using DataLab.Storage;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerServer.Server
{
    public class ServerStorage: Storage<ServerDataContainer>
    {

        public ServerDataContainer ServerData { get { return StorageObject; } set { this.StorageObject = value; } } 

        public ServerStorage(): base("server.pln")
        {
            //Debug.WriteLine(this.SaveLocation.Path);

        }
        
    }
}
