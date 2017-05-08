using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLab.Data.Users.Message
{
    public class MessageManager
    {
        public MailManager MailMan { get; set; } = new MailManager();

        public ChatManager ChatMan { get; set; } = new ChatManager();

        public MessageManager()
        {
            MailMan.Mails.Add(new Mail("lol", new List<string>() { "Ok" }, "hahahahahaha"));
        }

    }
}
