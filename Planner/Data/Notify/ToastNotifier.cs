using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Windows.UI.Notifications;
using Windows.Data.Xml;
using Windows.Data.Xml.Dom;

using System.Diagnostics;
using DataLab.Data.Planning;
using DataLab.Storage;

namespace Planner.Data.Notify
{
    public static class ToastNotifier
    {

        public static void setuptoasts(Plan p)
        {

            // Lets get our settings first
            //SettingsStorage storage = new SettingsStorage();
            //storage.waitToLoad(2);

            //if (storage.Settings.EnableNotifications)
            //{
                // Remove all current toasts
                ToastNotificationManager.History.Remove("Planner");

                List<Activity> tempA = new List<Activity>();
                // Add all repeating activities
                int counter = (int)DateTime.Now.DayOfWeek;

            foreach (RepeatingPlanningItem rpItem in p.rpi)
                {
                    foreach (DayOfWeek day in Enum.GetValues(typeof(DayOfWeek)))
                    {
                    Debug.WriteLine("Trying a day");
                        if (rpItem.Days.Contains(day))
                        {
                            DateTime setTime = DateTime.Now;

                            if (counter > 0)
                            {
                                setTime = DateTime.Now.Subtract(TimeSpan.FromDays(counter));
                                setTime = new DateTime(setTime.Year, setTime.Month, setTime.Day, rpItem.Time.Hours, rpItem.Time.Minutes, rpItem.Time.Seconds);

                            }
                            else if (counter < 0)
                            {
                                setTime = DateTime.Now.Add(TimeSpan.FromDays(counter));
                                
                            }

                            setTime = new DateTime(setTime.Year, setTime.Month, setTime.Day, rpItem.Time.Hours, rpItem.Time.Minutes, rpItem.Time.Seconds);
                            tempA.Add(new Activity(rpItem.Item.Name, ((Activity)rpItem.Item).Description, setTime, setTime));
                        }
                        
                        counter--;

                    }
                }

                p.Activities.Where(pi => pi.Start.Subtract(TimeSpan.FromMinutes(pi.MinutesToAlertBeforeActualAlarm)) > DateTime.Now).ToList().ForEach(e => tempA.Add(e));

                foreach (Activity a in tempA)
                {
                    //XmlDocument xml = ToastNotificationManager.GetTemplateContent(ToastTemplateType.ToastText02);
                    XmlDocument xml = ToastNotificationManager.GetTemplateContent(ToastTemplateType.ToastImageAndText02);
                    XmlNodeList xmlNodes = xml.GetElementsByTagName("text"),
                                xmlNode2 = xml.GetElementsByTagName("image");

                    if (!a.Silent)
                    {
                        XmlElement xmlNode3 = xml.CreateElement("audio");
                        xmlNode3.SetAttribute("src", "ms-winsoundevent:Notification.Looping.Alarm");
                    }

                    xmlNodes[0].AppendChild(xml.CreateTextNode(a.Name));
                    xmlNodes[1].AppendChild(xml.CreateTextNode(a.Description));

                    ((XmlElement)xmlNode2[0]).SetAttribute("src", "ms-appx:///Assets/delete.png");

                    ScheduledToastNotification toast = new ScheduledToastNotification(xml, a.Start);
                    toast.Tag = "Planner";

                    ToastNotificationManager.CreateToastNotifier().AddToSchedule(toast);
                    a.Start.AddMinutes(a.MinutesToAlertBeforeActualAlarm);
                }
                // To do items
                foreach (ToDoItem tdi in p.ToDoItems)
                {
                    // Do we need to notify?
                    if (tdi.HasDeadline && !tdi.IsDone && tdi.Deadline.Subtract(TimeSpan.FromMinutes(15)) > DateTime.Now)
                    {
                        XmlDocument xml = ToastNotificationManager.GetTemplateContent(ToastTemplateType.ToastImageAndText02);
                        XmlNodeList xmlNodes = xml.GetElementsByTagName("text"),
                                    xmlNode2 = xml.GetElementsByTagName("image");

                        XmlElement xmlNode3 = xml.CreateElement("audio");
                        xmlNode3.SetAttribute("src", "ms-winsoundevent:Notification.Looping.Alarm");

                        xmlNodes[0].AppendChild(xml.CreateTextNode(tdi.Name));
                        xmlNodes[1].AppendChild(xml.CreateTextNode(tdi.Description));

                        ((XmlElement)xmlNode2[0]).SetAttribute("src", "ms-appx:///Assets/delete.png");

                        ScheduledToastNotification toast = new ScheduledToastNotification(xml, tdi.Deadline - TimeSpan.FromMinutes(15));
                        toast.Tag = "Planner";
                        

                        ToastNotificationManager.CreateToastNotifier().AddToSchedule(toast);
                    }
                //}
            }
        }

    }
}
