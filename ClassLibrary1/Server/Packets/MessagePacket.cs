using Datalab.Server.Packets;
using DataLab.Data.Users.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataLab.Server.Packets
{
    public class MessagePacket: Packet
    {

        public Message Message { get; set; }

        public MessagePacket(Message msg)
        {
            this.Message = msg;
            
        }


    }
}
