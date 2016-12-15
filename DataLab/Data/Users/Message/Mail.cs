using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLab.Data.Users.Message
{
    public class Mail: Message
    {

        //public List<Attachment> Attachments { get; set; }
        public DateTime SentOn { get; set; }

        public string Subject { get; set; }

        public bool wasRead { get; set; }

        public Mail(string Sender, List<string> recepients, string message) : base(Sender, recepients)
        {
            this.SentOn =   DateTime.Now;
            this.Msg    =   message;
        }

        public Mail()
        {
            
        }
    }
}
