using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Email;
using DataLab.Data.Planning;
using DataLab.Data.Users;

namespace DataLab.Tools.Connectivity
{
    public class MailClient
    {

        private string _senderUsernamé;
        private string _senderMailAddress;

        private string[] _receiverUsernames = new string[] { "bilel@live.nl" };
        private string[] _receiverMailAddresses = new string[] { "Bilel Bghiel" };

        public MailClient(string sender, string[] receiversMailAddresses , string[] receiverNames)
        {
            this._senderUsernamé = sender;
            this._receiverMailAddresses = receiversMailAddresses;
            this._receiverUsernames = receiverNames;
        }
        
        public async void sendMail(string title, string message)
        {
            EmailMessage mail = new EmailMessage();
            mail.Subject = title;
            mail.Body = message;

            for (int counter = 0; counter < _receiverMailAddresses.Count(); counter++)
            {
                // Add all receivers to list
                mail.To.Add(new EmailRecipient(_receiverMailAddresses[counter], _receiverUsernames[counter]));
            }

            await EmailManager.ShowComposeNewEmailAsync(mail);
            
        }

        public async void sendMail(User user, PlanningItem item)
        {
            EmailMessage mail = MessageFactory.AsMessage(user, item);
            sendMail(mail.Subject, mail.Body);
        }

    }
}
