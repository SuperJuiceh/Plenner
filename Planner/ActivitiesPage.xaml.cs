using System;
using System.Collections.Generic;
using System.Linq;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Navigation;
using System.Diagnostics;

using DataLab.Storage;
using Windows.UI.Xaml.Controls.Maps;
using Planner.Data;
using DataLab.Data.Planning;
using Windows.Devices.Geolocation.Geofencing;
using Windows.Devices.Geolocation;
using Windows.UI.Core;
using Planner.Data.Styling;
using DataLab.Tools.Connectivity;
using DataLab.Data.Users;
using Windows.UI.Xaml.Data;
using System.Collections.ObjectModel;
using DataLab.Tools;
using DataLab.Storage.Backups;
using System.Threading.Tasks;



// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Planner
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ActivitiesPage : Page
    {

        private int num;

        public PlanningItemStorage Planning { get { return GeneralApplicationData.Planning; } set { GeneralApplicationData.Planning = value; } }

        public SettingsStorage Settings { get { return GeneralApplicationData.Settings; } set { GeneralApplicationData.Settings = value; } }

        private bool singleActivityNameSortedAscending, singleActivityTimeSortedAscending, repeatingActivityNameSortedAscending, repeatingActivityTimeSortedAscending;

        private DateTime FilterStartTime { get { return filterStartDate.Date.Date; } }

        private DateTime FilterEndTime { get { return filterEndDate.Date.Date; } }
        private string _filterQuery;
        private string FilterQuery { get { return filterQueryTextBlock.Text; }  }

        public ObservableCollection<Activity> ActivitiesList { get; set; } = new ObservableCollection<Activity>();

        //public SolidColorBrush RandomColor { get { return new SolidColorBrush(RandomColorGenerator.randomColor()); } }

        public ActivitiesPage()
        {
            UserStyleFactory.addStyles(this.Resources, this.Settings.Settings);

            this.ActivitiesList = Planning.plan.Activities;
            this.InitializeComponent();
            
        }


        private void Grid_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AddToDoItemPage));
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            StorageBackups backups = await StorageBackups.Create();
            
            backups.SetBackUpAsDefault(0);

            
        }

        private void textBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            Activity act = button.DataContext as Activity;

            if (act != null)
            {
                Planning.removePlanningItem(act);
            }

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Planning.clear(Plan.Clear_Options.ALL);
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AddActivity));
        }

        private async void MapControl_Loaded(object sender, RoutedEventArgs e)
        {


            MapControl map = (MapControl)sender;
            Activity activity = map.DataContext as Activity;
            await map.TrySetViewAsync(activity.LocationAsGeopoint, 10D);

            while (map.ZoomLevel < 19)
            {
                await map.TryZoomInAsync();
            }

            // Geofence setup

            Geocircle geo = new Geocircle(activity.Location, 10);
            Geofence geofence = new Geofence(new Random().Next(1000).ToString(), geo,
                                            MonitoredGeofenceStates.Entered, true, TimeSpan.FromMilliseconds(20),
                                            DateTime.Now, TimeSpan.FromHours(1));


        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void slider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            RepeatingPlanningItem rpi = ((Button)sender).DataContext as RepeatingPlanningItem;

            if (rpi != null)
            {
                Planning.removePlanningItem(rpi);
            }
        }

        public void filterList()
        {
            // Orderedlist placeholder
            IOrderedEnumerable<Activity> ok;
            // How will we sort the data? (Asc/Desc)
            if (singleActivityNameSortedAscending)
                ok = Planning.plan.Activities.OrderBy(item => item.Name);
            else
                ok = Planning.plan.Activities.OrderByDescending(item => item.Name);

            // Flip state
            repeatingActivityNameSortedAscending = !repeatingActivityNameSortedAscending;

            List<Activity> items = null;

            if (!String.IsNullOrWhiteSpace(FilterQuery) && filterStartDate != null && filterEndDate != null)
                items = ok.Where(item => item.Start.isBetweenStartAndEnd(FilterStartTime, FilterEndTime) && (item.Name.Contains(FilterQuery) || item.Description.Contains(FilterQuery))).ToList();
            else
            {
                items = ok.ToList();

            }

            if (items.Count() > 0)
            {
                ActivitiesList.Clear();
                // Add all items from the list
                items.ToList().ForEach(item =>
                {
                    ActivitiesList.Add(item);
                });
            }

            repeatingActivityTimeSortedAscending = false;
        }


        private void repeatingNameHeader_Tapped(object sender, TappedRoutedEventArgs e)
        {
            // Orderedlist placeholder
            IOrderedEnumerable<RepeatingPlanningItem> ok;
            // How will we sort the data? (Asc/Desc)
            if (singleActivityNameSortedAscending)
                ok = Planning.plan.rpi.OrderBy(item => item.Name);
            else
                ok = Planning.plan.rpi.OrderByDescending(item => item.Name);

            // Flip state
            repeatingActivityNameSortedAscending = !repeatingActivityNameSortedAscending;

            List<RepeatingPlanningItem> items = ok.ToList();

            if (ok.Count() > 0)
            {
                Planning.plan.rpi.Clear();
                // Add all items from the list
                items.ForEach(item =>
                {
                    Planning.plan.rpi.Add(item);
                });
            }

            repeatingActivityTimeSortedAscending = false;
        }

        private void repeatingTimeHeader_Tapped(object sender, TappedRoutedEventArgs e)
        {
            // Orderedlist placeholder
            IOrderedEnumerable<RepeatingPlanningItem> ok;
            // How will we sort the data? (Asc/Desc)
            if (singleActivityNameSortedAscending)
                ok = Planning.plan.rpi.OrderBy(item => item.Time);
            else
                ok = Planning.plan.rpi.OrderByDescending(item => item.Time);

            // Flip state
            repeatingActivityTimeSortedAscending = !repeatingActivityTimeSortedAscending;

            List<RepeatingPlanningItem> items = ok.ToList();

            if (ok.Count() > 0)
            {
                Planning.plan.rpi.Clear();
                // Add all items from the list
                items.ForEach(item =>
                {
                    Planning.plan.rpi.Add(item);
                });
            }

            repeatingActivityNameSortedAscending = false;
        }

        private void editButton_Click(Object sender, RoutedEventArgs e)
        {

            Button but = sender as Button;
            
            this.Frame.Navigate(typeof(AddActivity), but.DataContext as Activity);
        }

        private void listBoxSingleItems_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            RelativePanel panel = sender as RelativePanel;
            if (panel != null)
            {

                TextBlock block = panel.FindName("descriptionTextBlock") as TextBlock;

                if (block.Visibility == Visibility.Collapsed)
                {
                    block.Visibility = Visibility.Visible;
                    panel.Height = 80;
                }
                else
                {
                    block.Visibility = Visibility.Collapsed;
                    panel.Height = 35;
                }
            }
        }

        private void mailActivityButton_Click(object sender, RoutedEventArgs e)
        {
            Activity activity = (sender as Button).Tag as Activity;

            if (activity != null)
            {
                MailClient.sendMailWithPlanning(Planning, activity);
            }

        }

        private void todoitemsButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ToDoPage));
        }

        private void reflectionsButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ReflectionsPage));
        }

        private void settingsButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SettingsPage));
        }

        private void splitViewOpenCloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.mainSplitView.IsPaneOpen = !this.mainSplitView.IsPaneOpen;
        }

        private void showActivitiesSingleCheckbox_Checked(object sender, RoutedEventArgs e)
        {
            if (Settings.Settings.ActivitiesSingleListVisible)
            {
                if (Settings.Settings.ToDoItemsSingleListVisible)
                {
                    listView.Height = 250;
                }
                else
                {
                    listView.Height = 500;
                }
            }

            Settings.saveStorage();
        }


        private void showRepeatingActivitiesCheckbox_Checked(object sender, RoutedEventArgs e)
        {
            if (Settings.Settings.ActivitiesRepeatingListVisible)
            {
                if (Settings.Settings.ActivitiesSingleListVisible)
                {
                    listView.Height = 250;
                }
                else
                {
                    listView.Height = 500;
                }
            }

            
            Settings.saveStorage();
        }

        private void name_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void filterButton_Closed(object sender, object e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(TimeFlowPage));
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }

        private void filterOkButton_Click(object sender, RoutedEventArgs e)
        {
            // Set filters
            filterList();
        }

        private void singleActivityNameTextBlock_Tapped(object sender, TappedRoutedEventArgs e)
        {
            // Orderedlist placeholder
            IOrderedEnumerable<Activity> ok;
            // How will we sort the data? (Asc/Desc)
            if (singleActivityNameSortedAscending)
                ok = Planning.plan.Activities.OrderBy(item => item.Name);
            else
                ok = Planning.plan.Activities.OrderByDescending(item => item.Name);

            // Flip state
            singleActivityNameSortedAscending = !singleActivityNameSortedAscending;

            List<Activity> items = ok.ToList();

            if (ok.Count() > 0)
            {
                Planning.plan.Activities.Clear();
                // Add all items from the list
                items.ForEach(item =>
                {
                    Planning.plan.Activities.Add(item);
                });
            }

            singleActivityTimeSortedAscending = false;
        }


        private void singleActivityTimeTextBlock_Tapped(object sender, TappedRoutedEventArgs e)
        {

            // Orderedlist placeholder
            IOrderedEnumerable<Activity> ok;
            // How will we sort the data? (Asc/Desc)
            if (singleActivityTimeSortedAscending)
                ok = Planning.plan.Activities.OrderBy(item => item.Start);
            else
                ok = Planning.plan.Activities.OrderByDescending(item => item.Start);

            // Flip state
            singleActivityTimeSortedAscending = !singleActivityTimeSortedAscending;

            List<Activity> items = ok.ToList();

            if (ok.Count() > 0)
            {
                Planning.plan.Activities.Clear();
                // Add all items from the list
                items.ForEach(item =>
                {
                    Planning.plan.Activities.Add(item);
                });
            }

            singleActivityNameSortedAscending = false;
        }


        public async void OnGeofenceStateChanged(GeofenceMonitor sender, object e)
        {
            var reports = sender.ReadReports();

            await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                foreach (GeofenceStateChangeReport report in reports)
                {
                    GeofenceState state = report.NewState;

                    Geofence geofence = report.Geofence;

                    if (state == GeofenceState.Removed)
                    {
                        // Remove the geofence from the geofences collection.
                        GeofenceMonitor.Current.Geofences.Remove(geofence);
                    }
                    else if (state == GeofenceState.Entered)
                    {
                        // Your app takes action based on the entered event.

                        // NOTE: You might want to write your app to take a particular
                        // action based on whether the app has internet connectivity.

                    }
                    else if (state == GeofenceState.Exited)
                    {
                        // Your app takes action based on the exited event.

                        // NOTE: You might want to write your app to take a particular
                        // action based on whether the app has internet connectivity.

                    }
                }
            });
        }

    }
}
