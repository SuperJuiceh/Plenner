using DataLab.Data.Planning;
using DataLab.Data.Users.Contracts;
using DataLab.Data.Users.Message;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;
using System.Xml.Serialization;

namespace DataLab.Data.Users
{
    [XmlRoot("User")]
    public class User : INotifyPropertyChanged
    {
        private string _userName;
        [XmlAttribute("UserName")]
        public string UserName { get { return _userName; } set { _userName = value; Changed("UserName"); } }

        [XmlAttribute("password")]
        public string Password { get; set; }

        [XmlElement("Plan")]
        public Plan plan { get; set; } = new Plan();

        [XmlArray("Mails"), XmlArrayItem(typeof(Mail), ElementName = "Mail")]
        public ObservableCollection<Mail> Mails { get; set; } = new ObservableCollection<Mail>();
        [XmlIgnore]
        public  ContractManager ContractManager { get; set; } = new ContractManager();

        public DateTime LastDataSync { get; set; }

        public UserInfo UserInfo { get; set; } = new UserInfo();
        
        [XmlArray("Friends"), XmlArrayItem(typeof(string), ElementName = "Friend")]
        public ObservableCollection<string> Friends { get; set; } = new ObservableCollection<string>();

        public User(string username, string password, string fname, string lname, DateTime birthday, string countryname)
        {
            // Set user
            this.UserName = username;
            this.Password = password;

            // Set user info
            this.UserInfo.FirstName = fname;
            this.UserInfo.LastName = lname;
            this.UserInfo.BirthDay = birthday;
            this.UserInfo.CountryOfLiving = countryname;
            
            UserInfo.PropertyChanged += UserInfo_PropertyChanged;

            //Friends.Add("haha");
        }

        private void UserInfo_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Changed("UserInfo." + e.PropertyName);
        }

        public User(string username, string password)
        {
            this.UserName = username;
            this.Password = password;
        }

        public User() {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void Changed(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        public override string ToString()
        {
            return "User Name   " + UserName + "\n" +
                    "First Name: " + UserInfo.FirstName + "\n" +
                    "Last Name:  " + UserInfo.LastName + "\n" +
                    "Born " + UserInfo.BirthDay + " in " + UserInfo.BirthCountry;
        }
    }
}
