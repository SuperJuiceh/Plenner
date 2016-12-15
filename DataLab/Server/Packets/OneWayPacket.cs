using Datalab.Server.Packets;
using DataLab.Data.Planning;
using DataLab.Data.Users;
using DataLab.Data.Users.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLab.Server.Packets
{
    public class OneWayPacket : Packet
    {
        public enum What
        {
            GRANT_PERMISSIONS,
            SEND_CHAT,
            SEND_MESSAGE,
            ADD_USER_ITEM
        }

        public What Do;

        public object[] PacketData { get; set; }

        public OneWayPacket(What Do, object[] data) {
            this.PacketData  =  data;
            this.Do = Do;
        }

        public static OneWayPacket sendMail(Mail mail)
        {
            return new OneWayPacket(What.SEND_MESSAGE, new object[] { mail });
        }

        public static OneWayPacket sendChat(Message msg)
        {
            return new OneWayPacket(What.SEND_CHAT, new object[] { msg });
        }

        public static OneWayPacket sendPermission(string to, object o)
        {
            return new OneWayPacket(What.GRANT_PERMISSIONS, new object[] { to, o });
        }

        public static OneWayPacket addItemToUser(object o)
        {
            return new OneWayPacket(What.ADD_USER_ITEM, new object[] { o });
        }
    }
}
