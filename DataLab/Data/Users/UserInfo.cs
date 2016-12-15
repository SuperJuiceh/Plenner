using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Xml.Serialization;

namespace DataLab.Data.Users
{
    [XmlRoot("UserInfo")]
    public class UserInfo: INotifyPropertyChanged
    {
        [XmlIgnore]
        private string _firstName;
        [XmlAttribute("FirstName")]
        public string FirstName { get { return _firstName; } set { _firstName = value; Changed("FirstName"); Changed("FullName"); } }

        [XmlIgnore]
        public string _lastName;

        public event PropertyChangedEventHandler PropertyChanged;

        [XmlAttribute("LastName")]
        public string LastName { get { return _lastName; } set { _lastName = value; Changed("LastName"); Changed("FullName"); } }

        [XmlIgnore]
        public string FullName { get { return FirstName + " " + LastName; } }


        [XmlAttribute("BirthDay")]
        public DateTime BirthDay { get; set; }

        [XmlArray("Hobbies"), XmlArrayItem(typeof(string), ElementName = "Hobbie")]
        public ObservableCollection<string> Hobbies { get; set; } = new ObservableCollection<string>();

        public string BirthCountry { get; set; }

        public string CountryOfLiving { get; set; }

        public string Language { get; set; }

        public List<string> FriendNames { get; set; } = new List<string>();

        public UserInfo(string fname, string lname, DateTime bday, List<string> hobbies, string birthCountry, string countryOfLiving, string language, List<string> friendNames)
        {
            this.FirstName = fname;
            this.LastName = lname;
            this.BirthDay = bday;
            this.Hobbies = new ObservableCollection<string>(hobbies);
            this.BirthCountry = birthCountry;
            this.CountryOfLiving = countryOfLiving;
            this.Language = language;
            this.FriendNames = friendNames;
        }

        private void Changed(string v)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(v));
        }

        public UserInfo()
        {

        }
        
     }
}
