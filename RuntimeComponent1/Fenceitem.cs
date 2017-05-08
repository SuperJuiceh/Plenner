using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Background;
using Windows.Devices.Geolocation;
using Windows.Devices.Geolocation.Geofencing;
using Windows.UI.Notifications;

namespace RuntimeComponent1
{
    public sealed class FenceItem
    {

        string name;
        BasicGeoposition position;
        //double lat;
        //double lon;

        public FenceItem(string name, BasicGeoposition position)
        {
            /**
            Task.Run(async () =>
            {
                var accessStatus = await Geolocator.RequestAccessAsync();
                IList<Windows.Devices.Geolocation.Geofencing.Geofence> geofences = Windows.Devices.Geolocation.Geofencing.GeofenceMonitor.Current.Geofences;

                FillRegisteredGeofenceListBoxWithExistingGeofences();
                FillEventListBoxWithExistingEvents();

                Windows.Foundation.TypedEventHandler<Windows.Devices.Geolocation.Geofencing.GeofenceMonitor, object> OnGeofenceStateChanged = null;
                Windows.Foundation.TypedEventHandler<Windows.Devices.Geolocation.Geofencing.GeofenceMonitor, object> OnGeofenceStatusChanged = null;
                 Register for state change events.
                Windows.Devices.Geolocation.Geofencing.GeofenceMonitor.Current.GeofenceStateChanged += OnGeofenceStateChanged;
                Windows.Devices.Geolocation.Geofencing.GeofenceMonitor.Current.StatusChanged += OnGeofenceStatusChanged;

            }).Wait();
            **/

            this.name = name;
            this.position = position;
            //this.lat = lat;
            //this.lon = lon;
            //ShowToast(name, "You have arrived at "+ name);
            SetupGeofence(name, position);

        }

        public static async void SetupGeofence(string name, BasicGeoposition position)
        {

            RegisterBackgroundTasks(name);

            if (IsTaskRegistered(name))
            {

                //BasicGeoposition position = new BasicGeoposition();
                //position.Latitude = lat;
                //position.Longitude = lon;

                double radius = 10; //radius of the geofence
                Geocircle geocircle = new Geocircle(position, radius);
                MonitoredGeofenceStates monitoredStates = MonitoredGeofenceStates.Entered;

                Geofence geofence = new Geofence(name, geocircle, monitoredStates, false);

                GeofenceMonitor monitor = GeofenceMonitor.Current;

                var existingFence = monitor.Geofences.SingleOrDefault(f => f.Id == name);

                if (existingFence != null)
                    monitor.Geofences.Remove(existingFence);

                monitor.Geofences.Add(geofence);

                //ShowToast("Geofence succesfully added", IsTaskRegistered(name).ToString());
                Debug.WriteLine("Debug.WriteLine test SetupGeofence()");
            }
        }

        static async void RegisterBackgroundTasks(string name)
        {
            var access = await BackgroundExecutionManager.RequestAccessAsync();


            if (access == BackgroundAccessStatus.Denied)
            {
                ShowToast("Background access ", "denied");
            }
            else
            {

                ShowToast("", typeof(RuntimeComponent1.GeofenceTask).FullName);

                var taskBuilder = new BackgroundTaskBuilder();
                taskBuilder.Name = name;

                //taskBuilder.AddCondition(new SystemCondition(SystemConditionType.InternetAvailable));
                taskBuilder.SetTrigger(new LocationTrigger(LocationTriggerType.Geofence));
                //taskBuilder.SetTrigger(new SystemTrigger(SystemTriggerType.NetworkStateChange, true));

                //Petsnikker.Windows.Background
                taskBuilder.TaskEntryPoint = typeof(RuntimeComponent1.GeofenceTask).FullName;

                try
                {
                    var registration = taskBuilder.Register();
                    Debug.WriteLine("Registering background task...");
                    registration.Completed += (sender, e) =>
                    {
                        try
                        {
                            e.CheckResult();
                            Debug.WriteLine("Background result checked");
                        }
                        catch (Exception error)
                        {
                            Debug.WriteLine("Something went very wrong");
                            Debug.WriteLine(error);
                        }
                    };
                    Debug.WriteLine("Background task should be registered {0}", IsTaskRegistered(name));
                    Debug.WriteLine("Amount: " + BackgroundTaskRegistration.AllTasks.Count.ToString());
                }
                catch (Exception e)
                {
                    ShowToast("Exception", e.GetBaseException().ToString());
                }

            }

        }

        static bool IsTaskRegistered(string name)
        {
            var Registered = false;
            var entry = BackgroundTaskRegistration.AllTasks.FirstOrDefault(keyval => keyval.Value.Name == name);
            if (entry.Value != null)
                Registered = true;
            return Registered;
        }

        public static void ShowToast(string firstLine, string secondLine)
        {
            var toastXmlContent =
              ToastNotificationManager.GetTemplateContent(ToastTemplateType.ToastText02);

            var txtNodes = toastXmlContent.GetElementsByTagName("text");
            txtNodes[0].AppendChild(toastXmlContent.CreateTextNode(firstLine));
            txtNodes[1].AppendChild(toastXmlContent.CreateTextNode(secondLine));

            var toast = new ToastNotification(toastXmlContent);
            var toastNotifier = ToastNotificationManager.CreateToastNotifier();
            toastNotifier.Show(toast);

            Debug.WriteLine("Toast: {0} {1}", firstLine, secondLine);
        }
    }

    public sealed class GeofenceTask : IBackgroundTask
    {
        //BackgroundTaskDeferral deferral;


        public GeofenceTask()
        {
            Debug.WriteLine("GeofenceTask constructor called");

        }

        void IBackgroundTask.Run(IBackgroundTaskInstance taskInstance)
        {
            var deferral = taskInstance.GetDeferral();
            ShowToast("Arrived", "You have in 5 meters");
            //deferral = taskInstance.GetDeferral();

            var monitor = GeofenceMonitor.Current;
            if (monitor.Geofences.Any())
            {
                Debug.WriteLine("Run loop");
                var reports = monitor.ReadReports();
                foreach (var report in reports)
                {
                    switch (report.NewState)
                    {
                        case GeofenceState.Entered:
                            {

                                ShowToast("Approaching Home", ":-)");
                                break;
                            }
                        case GeofenceState.None:
                            {

                                ShowToast("Home", ":-)");
                                break;
                            }

                    }
                }
            }
            deferral.Complete();
        }

        private static void ShowToast(string firstLine, string secondLine)
        {
            var toastXmlContent =
              ToastNotificationManager.GetTemplateContent(ToastTemplateType.ToastText02);

            var txtNodes = toastXmlContent.GetElementsByTagName("text");
            txtNodes[0].AppendChild(toastXmlContent.CreateTextNode(firstLine));
            txtNodes[1].AppendChild(toastXmlContent.CreateTextNode(secondLine));
            //toastXmlContent.Attributes.GetNamedItem("launch").InnerText = "whahahahahaha";


            var toast = new ToastNotification(toastXmlContent);
            toast.Content.CreateAttribute("launch").Value = "lolololo";

            var toastNotifier = ToastNotificationManager.CreateToastNotifier();

            toastNotifier.Show(toast);

            Debug.WriteLine("Toast: {0} {1}", firstLine, secondLine);
        }
    }
}
