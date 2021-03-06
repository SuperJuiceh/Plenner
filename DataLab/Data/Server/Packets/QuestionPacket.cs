﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using DataLab.Server.Users;

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
            Get_user
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

        public static QuestionPacket AskIfPasswordIsValid(string username, string password)
        {
            return new QuestionPacket(Questions.Valid_password, new object[] { username, password, null });
        }
        
        public static QuestionPacket TryRegistration(User user)
        {
            return new QuestionPacket(Questions.Registration, new object[] { user });
        }

        public static QuestionPacket IsUserNameAvailable(string username)
        {
            return new QuestionPacket(Questions.Is_username_available, new object[] { username });
        }

        public static QuestionPacket GetUserData(string username)
        {
            return new QuestionPacket(Questions.Get_user, new object[] { username, null });

        }

        public static QuestionPacket PermissionCheck(string username, string destuser)
        {
            return null;
        }

        public static QuestionPacket Is_Online(string username, string destuser)
        {
            return null;
        }

        public QuestionPacket()
        {
        }

    }
}
