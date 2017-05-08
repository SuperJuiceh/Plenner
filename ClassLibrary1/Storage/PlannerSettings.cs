using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [XmlIgnore]
        private bool _autoLogIn;
        public bool AutoLogIn { get { return _autoLogIn; } set { _autoLogIn = value; Changed("AutoLogIn"); } }

        [XmlIgnore]
        public TimeSpan PlanningItemExperation { get; set; }
        // Convertable array for the unserializable 'TimeSpan' class (int[4]-array of Days, Hours, Minutes and Seconds
        public int[] PlanningItemExperationTimeSpanAsIntArray {
            get {
                return new int[] { PlanningItemExperation.Days, PlanningItemExperation.Hours, PlanningItemExperation.Minutes,
                                                                                         PlanningItemExperation.Seconds };
            }
            set
            {
                PlanningItemExperation = new TimeSpan(value[0], value[1], value[2], value[3]);
            }
        }

        [XmlIgnore]
        private bool _enableNotifications;
        public bool EnableNotifications { get { return _enableNotifications; } set { _enableNotifications = value; Changed("EnableNotifications"); } }
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
