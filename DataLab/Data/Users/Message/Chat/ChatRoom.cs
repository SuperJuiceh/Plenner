using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataLab.Data.Users.Message.Chat
{
    public class ChatRoom
    {
        [XmlArray("Participants"), XmlArrayItem(typeof(User), ElementName = "User")]
        public ObservableCollection<User> Participants { get; set; } = new ObservableCollection<User>();
        [XmlArray("ChatMessages"), XmlArrayItem(typeof(Message), ElementName = "Message")]
        public ObservableCollection<Message> ChatMessages { get; set; } = new ObservableCollection<Message>();

        public int ID { get; set; }

        public string Name { get; set; }

        public int MaxSize { get; set; }

        public ChatRoom(int maxsize, string Name)
        {
            this.MaxSize    =   maxsize;
            this.Name       =   Name;
        }

        public bool addChatMessage(Message m)
        {
            ChatMessages.Add(m);

            return true;
        }

        public bool addUser(User u)
        {
            // Max size not reached already?
            if (Participants.Count == MaxSize)
                return false;

            Participants.Add(u);
            return true;
        }

        public ChatRoom() { }
        
    }
}
