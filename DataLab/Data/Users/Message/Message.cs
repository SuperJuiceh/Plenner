using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataLab.Data.Users.Message
{
    public abstract class Message
    {
        public string Sender { get; set; }
        [XmlArray("Recepients"), XmlArrayItem(typeof(string))]
        public List<string> Recepients { get; set; } = new List<string>();

        public string Msg { get; set; }

        public string TimeSent { get; set; }

        public Message(string Sender, List<string> recepients)
        {
            this.Sender = Sender;
            this.Recepients = recepients;

        }

        public Message()
        {
        }
    }
}
