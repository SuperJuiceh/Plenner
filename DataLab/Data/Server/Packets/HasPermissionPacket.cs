using Datalab.Server.Packets;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLab.Server.Packets
{
    public class HasPermissionPacket: Packet
    {


        public string Requesting_user { get; set; }

        public string Destination_user { get; set; }

        public List<object> Permissions { get; set; }

        public List<object> Answers { get; set; }


        public HasPermissionPacket(string req, string dest, List<object> Permissions)
        {
            this.Requesting_user = req;
            this.Destination_user = dest;
            this.Permissions = Permissions;
            this.Answers = new List<object>(Permissions.Count);
        }



        public static HasPermissionPacket CreatePermissionsPacket(string username, string dest_user, params object[] permissions)
        {
            List<object> pList = new List<object>();

            foreach (object obj in permissions) {
                pList.Add(obj);
            }

            return new HasPermissionPacket(username, dest_user, pList);

        }


    }
}
