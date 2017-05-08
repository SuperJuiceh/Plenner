using DataLab.Data.Planning;
using DataLab.Data.Users.Message.Chat;
using System.Collections.ObjectModel;
using System.Linq;
using System.Xml.Serialization;

namespace DataLab.Data.Users.Message
{
    public class ChatManager
    {
        [XmlArray("ChatRooms"), XmlArrayItem(typeof(ChatRoom), ElementName = "ChatRoom")]
        public ObservableCollection<ChatRoom> ChatRooms { get; set; } = new ObservableCollection<ChatRoom>();
        [XmlArray("ChatHistory"), XmlArrayItem(typeof(ChatRoom), ElementName = "ChatRoom")]
        public ObservableCollection<ChatRoom> ChatHistory { get; set; } = new ObservableCollection<ChatRoom>();

        public ChatManager()
        {
            
        }

        public int genID()
        {
            // Start from 1 and count up untill we have an ID that isn't used yet
            int ID = 1;
            for (; ChatRooms.First(cr => cr.ID == ID) != null; ID++)
            {

            }
            return ID;
        }

        public ChatRoom addChat(string name, int size)
        {
            ChatRoom chat = new ChatRoom(size, name);
            chat.ID = genID();

            ChatRooms.Add(chat);

            return chat;
        }

        public void storeOld()
        {
            ChatRooms.ToList().ForEach(cr => ChatHistory.Add(cr));
            ChatRooms.Clear();
        }
        
    }
}