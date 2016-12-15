using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;
using System.Xml.Serialization;

using System.ComponentModel;

using System.Collections.ObjectModel;
using System.Globalization;
using Windows.UI.Notifications;
using DataLab.Data.Users.Message;

namespace DataLab.Data.Planning
{
    [XmlRoot("Plan")]
    public class Plan: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [XmlArray("ToDoItems"), XmlArrayItem(typeof(ToDoItem), ElementName="ToDoItem")]
        public ObservableCollection<ToDoItem> ToDoItems { get; set; } = new ObservableCollection<ToDoItem>();
        [XmlArray("Activities"), XmlArrayItem(typeof(Activity), ElementName = "Activity")]
        public ObservableCollection<Activity> Activities { get; set; } = new ObservableCollection<Activity>();
        [XmlIgnore]
        public ObservableCollection<Activity> IcomingActivities { get { return new ObservableCollection<Activity>(getLastActivities(1, 5)); } }
        [XmlArray("rpi"), XmlArrayItem(typeof(RepeatingPlanningItem), ElementName = "RepeatingPlanningItem")]
        public ObservableCollection<RepeatingPlanningItem> rpi { get; set; } = new ObservableCollection<RepeatingPlanningItem>();
        [XmlArray("tdiSets"), XmlArrayItem(typeof(ToDoItemSet), ElementName = "ToDoItemSet")]
        public ObservableCollection<ToDoItemSet> tdiSets { get; set; } = new ObservableCollection<ToDoItemSet>();
        [XmlArray("Reflections"), XmlArrayItem(typeof(Reflection), ElementName = "Reflection")]
        public ObservableCollection<Reflection> Reflections { get; set; } = new ObservableCollection<Reflection>();
        [XmlArray("Diaries"), XmlArrayItem(typeof(Diary), ElementName = "Diary")]
        public ObservableCollection<Diary> Diaries { get; set; } = new ObservableCollection<Diary>();

        [XmlArray("Archive")]
        public Plan Archive { get; set; } = new Plan();

        [XmlIgnore]
        public List<PlanningItem> AllItems { get { return getAllItems(); } }
        [XmlArray("Mails"), XmlArrayItem(typeof(Mail), ElementName = "Mail")]
        public ObservableCollection<Mail> Mails { get; set; } = new ObservableCollection<Mail>();
        [XmlIgnore]
        private TimeSpan archiveAfter = TimeSpan.FromDays(1);

        public Plan()
        {
            //Activities.Add(new Activity("lol", "ha", DateTime.Now));
        }

        private List<Activity> getLastActivities(int start, int range) {
            // List
            List<Activity> tempA = new List<Activity>();

            // Add all repeating activities
            int startPos = (int)new DateTime().DayOfWeek;
            int counter  = 0;

            foreach (RepeatingPlanningItem rpItem in rpi) {
                foreach (DayOfWeek day in Enum.GetValues(typeof(DayOfWeek)))
                {
                    if (rpItem.Days.Contains(day))
                    {
                        tempA.Add((Activity)Activator.CreateInstance(rpItem.Item.GetType(), rpItem.Name, ((Activity)rpItem.Item).Description, DateTime.Now.AddDays(counter)));
                    }
                    
                    startPos++;
                    counter++;

                    if (startPos == 6)
                        startPos = 0;

                }

            }

            // Loop
            if (range > 0 && start > 0 && start + range < Activities.Count)
            {
                foreach (Activity act in tempA) {

                    if (counter >= start && counter < start + range)
                        tempA.Add(act);

                    counter++;
                }
            }
            return tempA;
        }

        public void removeReflectionAndPhoto(Reflection reflection)
        {
            if (Reflections.Contains(reflection))
            {
                reflection.deleteReflectionPhoto();
                Reflections.Remove(reflection);
            }
        }
        
        public enum Clear_Options
        {
            ALL,
            ACTIVITIES,
            TODO,
            REFLECTIONS,
            DIARIES
        }

        private void archiveOldActivities()
        {
            // Find Activities older than a day
            List<Activity> archivableActivities = Activities.Where(a => a.End < DateTime.Now.Subtract(TimeSpan.FromDays(1))).ToList();
            // Remove those activities from the current 
            // After aadding then to the archive ofcourse
            archivableActivities.ForEach(a =>
            {
                Archive.Activities.Add(a);
                Activities.Remove(a);
            });
            
        }

        // Clear Plan with Clear_Options
        // Enum names should say enough
        public void clear(Clear_Options options)
        {
            if (options == Clear_Options.ALL || options == Clear_Options.ACTIVITIES)
            {
                Activities.Clear();
                rpi.Clear();
            }
            if (options == Clear_Options.ALL || options == Clear_Options.TODO)
            {
                ToDoItems.Clear();
                tdiSets.Clear();
            }
            if (options == Clear_Options.ALL || options == Clear_Options.REFLECTIONS)
            {
                Reflections.Clear();
            }
            
            // Clear open notifications
            ToastNotificationManager.History.Remove("Planner");
        }

        public void Changed(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        private List<PlanningItem> getAllItems()
        {
            List<PlanningItem> All = new List<PlanningItem>();

            All.AddRange(Activities);
            All.AddRange(Reflections);
            All.AddRange(rpi);
            All.AddRange(ToDoItems);
            All.AddRange(tdiSets);

            return All;
        }

        ~Plan()
        {
            if (PropertyChanged != null)
            {
                foreach (Delegate del in PropertyChanged.GetInvocationList()) {
                    PropertyChanged -= (PropertyChangedEventHandler)del;
                }
            }
        }

        public void cleanOldItems()
        {
            
            archiveOldActivities();

            archiveToDoItems();

        }

        public void archiveToDoItems()
        {
            ToDoItems.Where(tdi => tdi.hasDeadline())
                     .Where(tdi => tdi.Deadline < DateTime.Now.Subtract(archiveAfter))
                     .ToList()
                     .ForEach(tdi => {
                         Archive.ToDoItems.Remove(tdi);
                         ToDoItems.Remove(tdi);

                     });

        }

        public static Plan operator +(Plan first, Plan second)
        {
            // 
            second.Activities.ToList().ForEach(act =>
            {
                if (!first.Activities.Contains(act))
                    first.Activities.Add(act);

            });

            second.Reflections.ToList().ForEach(refl =>
            {
                if (!first.Reflections.Contains(refl))
                    first.Reflections.Add(refl);

            });

            second.ToDoItems.ToList().ForEach(tdi =>
            {
                if (!first.ToDoItems.Contains(tdi))
                    first.ToDoItems.Add(tdi);

            });

            second.Diaries.ToList().ForEach(diary =>
            {
                if (!first.Diaries.Contains(diary))
                    first.Diaries.Add(diary);

            });

            return first;
        }
        
    }
}
