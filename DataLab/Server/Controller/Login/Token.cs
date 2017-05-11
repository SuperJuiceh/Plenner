using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataLab.Server.Controller.Login
{
    [XmlRoot("Login")]
    public abstract class Token
    {
        public string deviceID { get; set; }

        public DateTime RegisteredAt { get; set; }

        public int ID { get; set; }
        
        public TimeSpan LeaseTime { get; set; }

        public DateTime ValidUntil { get { return RegisteredAt.Add(LeaseTime); } }
        
        public Token(int ID, TimeSpan leaseTime, string deviceID)
        {
            RegisteredAt = DateTime.Now;
            this.deviceID = deviceID;
        }


        public Token() { }
    }
}
