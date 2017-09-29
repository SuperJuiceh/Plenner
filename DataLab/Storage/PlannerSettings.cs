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
        // Online User activity
        [XmlIgnore]
        private bool _autoSyncAccount;
        public bool AutoSyncAccount { get { return _autoSyncAccount; } set { _autoSyncAccount = value; Changed("AutoSyncAccount"); } }

        public LoginToken LognToken { get; set; }


        [XmlIgnore]
        public bool AutoLogIn { get { return LognToken != null; } }
        
        [XmlIgnore]
        public TimeSpan PlanningItemExperation { get { return new TimeSpan(PlanningItemExperationLong); } set { this.PlanningItemExperationLong = value.Ticks; Changed("PlanningItemExperation"); } }

        public long PlanningItemExperationLong { get; set; }

        // Global
        [XmlIgnore]
        private bool _enableNotifications = true;
        public bool EnableNotifications { get { return _enableNotifications; } set { _enableNotifications = value; Changed("EnableNotifications"); } }

        [XmlIgnore]
        private string _fontTypeUser;
        public string FontTypeUser { get { return _fontTypeUser; } set { _fontTypeUser = value; Changed("FontTypeUser"); } }

        [XmlIgnore]
        private int _fontSizeUser;
        public int FontSizeUser { get {  return _fontSizeUser; } set { _fontSizeUser = value; Changed("FontSizeUser"); } }

        [XmlIgnore]
        private string _notificationIconString;
        public string NotificationIconString { get { return _notificationIconString != null ? _notificationIconString : "/Assets/NotificationIcons/Notif_icon_1.png"; } set { _notificationIconString = value; Changed("NotificationIconNumber"); } }

        // ActivityPage
        private bool _activitiesSingleListVisible;
        public bool ActivitiesSingleListVisible { get { return _activitiesSingleListVisible; } set { _activitiesSingleListVisible = value; Changed("ActivitiesSingleListVisible"); } }

        private bool _activitiesRepeatingListVisible;
        public bool ActivitiesRepeatingListVisible { get { return _activitiesRepeatingListVisible; } set { _activitiesRepeatingListVisible = value; Changed("ActivitiesRepeatingListVisible"); } }

        // ToDoPage
        private bool _toDoItemsSingleListVisible;
        public bool ToDoItemsSingleListVisible { get { return _toDoItemsSingleListVisible; } set { _toDoItemsSingleListVisible = value; Changed("ToDoItemsSingleListVisible"); } }

        private bool _toDoItemsSetListVisible;
        public bool ToDoItemsSetListVisible { get { return _toDoItemsSetListVisible; } set { _toDoItemsSetListVisible = value; Changed("ToDoItemsSetListVisible"); } }

        public PlannerSettings()
        {

        }

        public void Changed(string name)
        {
            Debug.WriteLine("Changed {0}", name);
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
