using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Services.Maps;

using DataLab.Storage;

using System.Diagnostics;
using Windows.Devices.Geolocation;
using Windows.UI.Xaml.Controls.Maps;
using Planner.Data.Converters;
using Planner.Data.Notify;
using DataLab.Data.Planning;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Planner
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AddActivity : Page
    {

        public PlanningItemStorage Storage { get; set; }

        private Geolocator _geo;

        private BasicGeoposition _lastSelectedLocation;

        private MapControl mainMap;

        private MapIcon activeIcon = new MapIcon();

        private DateTime? CurrentStartTime, CurrentEndTime;

        private bool editMode;

        private Activity EditableActivity;

        public AddActivity()
        {
            this.InitializeComponent();

            for (int i = 0; i < 60; i++)
                listBoxMinutes.Items.Add(i);

            listBoxMinutes.SelectedIndex = 0;

        }

        public void setActivity(Activity a)
        {
            // Tell the App we're editing, NOT ADDING.
            editMode = true;
            EditableActivity = a;
            // Set visual data to class repre
            _lastSelectedLocation = a.basicgeoloc;
            CurrentStartTime = a.Start;
            CurrentEndTime = a.End;
            nameTextBox.Text = a.Name;

            if (a.Description != null)
                descriptionTextBox.Text = a.Description;
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            if (!editMode)
            {
                // Activity time
                DateTime startTime = getStartTime();
                DateTime endTime = getEndTime();

                if (startTime > DateTime.Now.AddMinutes(-listBoxMinutes.SelectedIndex))
                {
                    // Are we making a repeatable item? (If any day is checked)
                    if (mondayEnabledCheckedBox.IsChecked.GetValueOrDefault() || tuesdayEnabledCheckedBox.IsChecked.GetValueOrDefault() || wednesdayEnabledCheckedBox.IsChecked.GetValueOrDefault() ||
                        thursdayEnabledCheckedBox.IsChecked.GetValueOrDefault() || fridayEnabledCheckedBox.IsChecked.GetValueOrDefault() || saturdayEnabledCheckedBox.IsChecked.GetValueOrDefault() || sundayEnabledCheckedBox.IsChecked.GetValueOrDefault())
                    {
                        List<DayOfWeek> daysSet = new List<DayOfWeek>();
                        // Check which days are checked and add them to our item
                        if (mondayEnabledCheckedBox.IsChecked.GetValueOrDefault())
                            daysSet.Add(DayOfWeek.Monday);
                        if (tuesdayEnabledCheckedBox.IsChecked.GetValueOrDefault())
                            daysSet.Add(DayOfWeek.Tuesday);
                        if (wednesdayEnabledCheckedBox.IsChecked.GetValueOrDefault())
                            daysSet.Add(DayOfWeek.Wednesday);
                        if (thursdayEnabledCheckedBox.IsChecked.GetValueOrDefault())
                            daysSet.Add(DayOfWeek.Thursday);
                        if (fridayEnabledCheckedBox.IsChecked.GetValueOrDefault())
                            daysSet.Add(DayOfWeek.Friday);
                        if (saturdayEnabledCheckedBox.IsChecked.GetValueOrDefault())
                            daysSet.Add(DayOfWeek.Saturday);
                        if (sundayEnabledCheckedBox.IsChecked.GetValueOrDefault())
                            daysSet.Add(DayOfWeek.Sunday);

                        RepeatingPlanningItem repPlanItem = new RepeatingPlanningItem(new Activity(nameTextBox.Text, descriptionTextBox.Text, getStartTime(), getEndTime()), daysSet, new TimeSpan(getStartTime().Hour, getStartTime().Minute, getStartTime().Second));
                        repPlanItem.Silent = checkBox1.IsChecked.GetValueOrDefault();
                        repPlanItem.MinutesToAlertBeforeActualAlarm = listBoxMinutes.SelectedIndex;

                        Storage.addPlanningItem(repPlanItem);
                        ToastNotifier.setuptoasts(Storage.plan);
                    }
                    else
                    {
                        Activity activity = new Activity(nameTextBox.Text, descriptionTextBox.Text, getStartTime(), getEndTime(), _lastSelectedLocation);
                        activity.Silent = checkBox1.IsChecked.GetValueOrDefault();
                        activity.MinutesToAlertBeforeActualAlarm = listBoxMinutes.SelectedIndex;

                        Storage.addPlanningItem(activity);


                        ToastNotifier.setuptoasts(Storage.plan);
                        // To ActivitiesPage
                    }
                    this.Frame.Navigate(typeof(ActivitiesPage), Storage);
                }
            } else
            {
                editActivity();
            }
        }

        private void editActivity() {
            
            if (EditableActivity != null)
            {
                Debug.WriteLine(EditableActivity.Name);
                Storage.removePlanningItem(EditableActivity);


                EditableActivity.Name = nameTextBox.Text;
                EditableActivity.Description = descriptionTextBox.Text;

                Storage.addPlanningItem(EditableActivity);

                this.Frame.Navigate(typeof(ActivitiesPage), Storage);
            }
            
        }

        private DateTime getStartTime()
        {
            return new DateTime(startdatePicker.Date.Year, startdatePicker.Date.Month, startdatePicker.Date.Day, starttimePicker.Time.Hours, starttimePicker.Time.Minutes, starttimePicker.Time.Seconds);
        }

        private DateTime getEndTime()
        {
            return new DateTime(enddatePicker.Date.Year, enddatePicker.Date.Month, enddatePicker.Date.Day, endtimePicker.Time.Hours, endtimePicker.Time.Minutes, endtimePicker.Time.Seconds);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            nameTextBox.Text = "";
            descriptionTextBox.Text = "";
            
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            PlanningItemStorage p = e.Parameter as PlanningItemStorage;

            if (p != null)
            {
                Storage = p;
            } else
            {
                Tuple<PlanningItemStorage, Activity> t = e.Parameter as Tuple<PlanningItemStorage, Activity>;

                if (t != null) {
                    Storage = t.Item1;
                    setActivity(t.Item2);
                }
            }
        }

        private void MapControl_MapElementClick(Windows.UI.Xaml.Controls.Maps.MapControl sender, Windows.UI.Xaml.Controls.Maps.MapElementClickEventArgs args)
        {
        }
        

        private void Grid_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ActivitiesPage));
        }

        private async void MapControl_Loaded(object sender, RoutedEventArgs e)
        {
            MapControl map = sender as MapControl;

            this.mainMap = map;

            Debug.WriteLine(await Geolocator.RequestAccessAsync());
            _geo = new Geolocator() { DesiredAccuracyInMeters = 10 };
            //setmaptogps(map, await _geo.GetGeopositionAsync());
        }

        private async void setmaptogps(MapControl map, Geoposition pos)
        {
            Debug.WriteLine("In setmaptogps()");
            // Set location to our current gps
            _lastSelectedLocation = ClassConverters.geopositiontobgp(await _geo.GetGeopositionAsync());
            Debug.WriteLine("lsl changed "+ _lastSelectedLocation.Altitude);

            
            Debug.WriteLine("Tried setview async "+ await map.TrySetViewAsync(new Geopoint(_lastSelectedLocation), 10D));

            //while (map.ZoomLevel < 18)
            //{
            //    await map.TryZoomInAsync();
            //};
        }

        private async void button3_Click(object sender, RoutedEventArgs e)
        {
            
            MapLocationFinderResult result = await MapLocationFinder.FindLocationsAtAsync(new Geopoint(_lastSelectedLocation));

            if (result.Status == MapLocationFinderStatus.Success)
            {
                if (result.Locations[0].Description != "")
                    selectedLocationTextBlock.Text = result.Locations[0].Description;
                else
                    selectedLocationTextBlock.Text = result.Locations[0].Address.FormattedAddress;
            }
            
        }
        

        private async void button4_Click(object sender, RoutedEventArgs e)
        {
            setmaptogps(mainMap, await _geo.GetGeopositionAsync());
        }

        private void MapControl_MapTapped(MapControl sender, MapInputEventArgs args)
        {
            sender.MapElements.Remove(activeIcon);

            _lastSelectedLocation = args.Location.Position;
            activeIcon.Location = args.Location;

            sender.MapElements.Add(activeIcon);
        }

        private void mondayEnabledCheckedBox_Checked(object sender, RoutedEventArgs e)
        {
            if (mondayEnabledCheckedBox.IsChecked.GetValueOrDefault() || tuesdayEnabledCheckedBox.IsChecked.GetValueOrDefault() ||
                wednesdayEnabledCheckedBox.IsChecked.GetValueOrDefault() || thursdayEnabledCheckedBox.IsChecked.GetValueOrDefault() ||
                fridayEnabledCheckedBox.IsChecked.GetValueOrDefault() || saturdayEnabledCheckedBox.IsChecked.GetValueOrDefault() || sundayEnabledCheckedBox.IsChecked.GetValueOrDefault())
            {
                startRadioButton.Visibility = Visibility.Collapsed;
                endRadioButton.Visibility = Visibility.Collapsed;

                standardTimePicker.Visibility = Visibility.Visible;

            }
            else
            {
                startRadioButton.Visibility = Visibility.Visible;
                endRadioButton.Visibility = Visibility.Visible;

                standardTimePicker.Visibility = Visibility.Collapsed;
            }
        }

        private void endRadioButton_Click(Object sender, RoutedEventArgs e)
        {
            var rButton = sender as CheckBox;

            if (rButton.ContextFlyout != null)
            {
                rButton.ContextFlyout.ShowAt(rButton);
            }
        }

        private void startRadioButton_Click(Object sender, RoutedEventArgs e)
        {
            var rButton = sender as CheckBox;

            if (rButton.ContextFlyout != null)
            {
                rButton.ContextFlyout.ShowAt(rButton);
            }
        }

        private void startRadioButtonFlyout_Closed(Object sender, Object e)
        {
            startRadioButton.IsChecked = false;

            DateTime dt = new DateTime(startdatePicker.Date.Year, startdatePicker.Date.Month, startdatePicker.Date.Day, starttimePicker.Time.Hours, starttimePicker.Time.Minutes, starttimePicker.Time.Seconds);

            if (dt > DateTime.Now)
            {
                if (CurrentEndTime.HasValue)
                    if (CurrentEndTime.GetValueOrDefault() > dt)
                        return;

                startRadioButton.IsChecked = true;
                CurrentStartTime = dt;

                if (CurrentEndTime.HasValue && CurrentEndTime < CurrentStartTime)
                {
                    endRadioButton.IsChecked = false;
                    CurrentEndTime = null;
                }
            }
        }

        private void endRadioButtonFlyout_Closed(Object sender, Object e)
        {
            endRadioButton.IsChecked = false;
            startRadioButton.IsChecked = true;

            DateTime dt = new DateTime(enddatePicker.Date.Year, enddatePicker.Date.Month, enddatePicker.Date.Day, endtimePicker.Time.Hours, endtimePicker.Time.Minutes, endtimePicker.Time.Seconds);
            
            if (dt > DateTime.Now)
            {
                if (CurrentStartTime.HasValue)
                    if (CurrentStartTime.GetValueOrDefault() > dt)
                        return;

                endRadioButton.IsChecked = true;
                CurrentEndTime = dt;

                if (CurrentStartTime.HasValue && CurrentEndTime < CurrentStartTime)
                {
                    startRadioButton.IsChecked = false;
                    CurrentStartTime = null;
                }
            }
        }

        private void standardTimePicker_Loaded(Object sender, RoutedEventArgs e)
        {
            (sender as TimePicker).Visibility = Visibility.Collapsed;
        }
        

    }
}
