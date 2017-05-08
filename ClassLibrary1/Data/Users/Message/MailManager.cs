using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataLab.Data.Users.Message
{
    [XmlRoot("MailManager")]
    public class MailManager
    {
        [XmlArray("Mails"), XmlArrayItem(typeof(Mail), ElementName = "Mail")]
        public List<Mail> Mails { get; set; } = new List<Mail>();

        public MailManager()
        {

        }

        public Tuple<List<Mail>, List<Mail>> getMailFrom(string username)
        {
            // return tuple with list of sent mails and received mails
            return new Tuple<List<Mail>, List<Mail>>
            (
                Mails.Where(mail => mail.Sender == username).ToList(),
                Mails.Where(Mail => Mail.Recepients.Contains(username)).ToList()
            );
        }

        public List<Mail> getMailsBetweenTimes(DateTime start, DateTime end)
        {
            return Mails.Where(mail => mail.SentOn > start && end > mail.SentOn).ToList();
        }

        public Tuple<List<Mail>, List<Mail>> getMailsFromUserBetweenTimes(string username, DateTime start, DateTime end)
        {
            Tuple<List<Mail>, List<Mail>> returnMails = getMailFrom(username);

            return new Tuple<List<Mail>, List<Mail>>
            (
                returnMails.Item1.Where(mail => mail.SentOn > start && end > mail.SentOn).ToList(),
                returnMails.Item2.Where(mail => mail.SentOn > start && end > mail.SentOn).ToList()
            );
        }

        public bool addMail(UserManager uman, Mail m)
        {
            // Check if users exists ('can we send the mail?')
            if (uman.userExists(m.Sender) && uman.userExists(m.Recepients[0])){
                Mails.Add(m);

                return true;
            }

            return false;
        }

        public bool removeMail(UserManager uman, Mail m)
        {
            return Mails.Remove(m);
        }

    }
}
