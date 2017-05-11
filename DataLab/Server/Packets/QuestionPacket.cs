using DataLab.Data.Users;
using DataLab.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Datalab.Server.Packets
{
    [XmlInclude(typeof(User))]
    [XmlInclude(typeof(QuestionPacket))]
    // QuestinPacket is for normal 'yes/no' questions.
    public class QuestionPacket: Packet
    {
        // All Questions that can be asked
        public enum Questions {
            Valid_username,
            Valid_password,
            Is_Online,
            Permissions_check,
            Registration,
            Is_username_available,
            Get_user,
            Sync_user,
            Valid_token
        }
        
        // Ask a question
        public Questions Q { get; set; }
        // Send data to use for verification
        public object[] Question_data { get; set; }
        // The Wise Owl's answer
        public bool A { get; set; } = false;
        // 

        private QuestionPacket(Questions whatidliketoknow, object[] question_data) {
            this.Q = whatidliketoknow;
            this.Question_data = question_data;
        }
                
        public static QuestionPacket AskIfUserNameIsValid(string username) {
            return new QuestionPacket(Questions.Valid_username, new object[] { username });
        }

        public static QuestionPacket AskIfPasswordIsValid(string username, string password, bool withToken)
        {
            // object: username, password, user, token? , token (optional:)
            return new QuestionPacket(Questions.Valid_password, new object[] { username, password, null, withToken, null });
        }

        public static QuestionPacket AskIfTokenIsValid(string username, int token, string deviceID)
        {
            // object: username, password, deviceID, user
            return new QuestionPacket(Questions.Valid_token, new object[] { username, token, deviceID, null });
        }

        public static QuestionPacket TryRegistration(User user)
        {
            return new QuestionPacket(Questions.Registration, new object[] { user, null, null });
        }

        public static QuestionPacket IsUserNameAvailable(string username)
        {
            return new QuestionPacket(Questions.Is_username_available, new object[] { username });
        }

        public static QuestionPacket GetUserData(string username)
        {
            return new QuestionPacket(Questions.Get_user, new object[] { username, null });

        }

        public static QuestionPacket SyncUserData(User user)
        {
            return new QuestionPacket(Questions.Sync_user, new object[] { user });
        }

        public static QuestionPacket PermissionCheck(string username, string destuser, object permission)
        {
            return new QuestionPacket(Questions.Permissions_check, new object[] { destuser, permission });
        }

        public static QuestionPacket Is_Online(string username)
        {
            return new QuestionPacket(Questions.Is_Online, new object[] { null });
        }

        public QuestionPacket()
        {
        }

    }
}
