using DataLab.Server.Controller.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataLab.Storage
{
    public class PlannerSettings: INotifyPropertyChanged
    {
        [XmlIgnore]
        private bool _soundEnabled;
        // Settings
        public bool SoundEnabled { get { return _soundEnabled; } set { _soundEnabled = value; Changed("SoundEnabled"); } }
        [XmlIgnore]
        private bool _autoSyncAccount;
        public bool AutoSyncAccount { get { return _autoSyncAccount; } set { _autoSyncAccount = value; Changed("AutoSyncAccount"); } }

        public LoginToken LognToken { get; set; }


        [XmlIgnore]
        public bool AutoLogIn { get { return LognToken != null; } }
        
        [XmlIgnore]
        public TimeSpan PlanningItemExperation { get { return new TimeSpan(PlanningItemExperationLong); } set { this.PlanningItemExperationLong = value.Ticks; Changed("PlanningItemExperation"); } }

        public long PlanningItemExperationLong { get; set; }

        [XmlIgnore]
        private bool _enableNotifications;
        public bool EnableNotifications { get { return _enableNotifications; } set { _enableNotifications = value; Changed("EnableNotifications"); } }

        [XmlIgnore]
        private string _fontTypeUser;
        public string FontTypeUser { get { return _fontTypeUser; } set { _fontTypeUser = value; Changed("FontTypeUser"); } }

        [XmlIgnore]
        private int _fontSizeUser;
        public int FontSizeUser { get {  return _fontSizeUser; } set { _fontSizeUser = value; Changed("FontSizeUser"); } }

        public PlannerSettings()
        {

        }

        public void Changed(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        ~PlannerSettings()
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.GetInvocationList().ToList().ForEach(pl =>
                {
                    PropertyChanged -= (PropertyChangedEventHandler)pl;

                });
            }
        }
    }
}
