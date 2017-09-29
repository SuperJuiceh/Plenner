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
using System.ComponentModel;
using System.Threading.Tasks;
using Planner.Data.Styling;
using Planner.Data;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Planner
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AddActivity : Page
    {

        public PlanningItemStorage Planning { get { return GeneralApplicationData.Planning; } set { GeneralApplicationData.Planning = value; } }

        public SettingsStorage Settings { get { return GeneralApplicationData.Settings; } set { GeneralApplicationData.Settings = value; } }



        private DateTime? CurrentStartTime, CurrentEndTime;

        private bool editMode;

        private Activity EditableActivity;

        private bool proximityTrackingOn, gpsFlyoutIsOpened;


        public AddActivity()
        {

            UserStyleFactory.addStyles(this.Resources, this.Settings.Settings);

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
            mapControl.LastSelectedLocation = a.Location;
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

                        Planning.addPlanningItem(repPlanItem);
                        ToastNotifier.setuptoasts(Planning.plan);
                    }
                    else
                    {
                        Activity activity = new Activity(nameTextBox.Text, descriptionTextBox.Text, getStartTime(), getEndTime(), mapControl.LastSelectedLocation);
                        activity.Silent = checkBox1.IsChecked.GetValueOrDefault();
                        activity.MinutesToAlertBeforeActualAlarm = listBoxMinutes.SelectedIndex;
                        //if (proximityNotification.IsChecked.GetValueOrDefault())
                        //{
                        //    activity.setGeoFence();
                        //}
                        Planning.addPlanningItem(activity);


                        ToastNotifier.setuptoasts(Planning.plan);
                        // To ActivitiesPage
                    }
                    this.Frame.Navigate(typeof(ActivitiesPage));
                }
            } else
            {
                editActivity();
            }
        }

        private void editActivity() {
            
            if (EditableActivity != null)
            {
                //Debug.WriteLine(EditableActivity.Name);
                Planning.removePlanningItem(EditableActivity);


                EditableActivity.Name = nameTextBox.Text;
                EditableActivity.Description = descriptionTextBox.Text;

                Planning.addPlanningItem(EditableActivity);

                this.Frame.Navigate(typeof(ActivitiesPage));
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
            
            Activity t = e.Parameter as Activity;

            if (t != null) {
                setActivity(t);
            }
        }
        

        private void Grid_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ActivitiesPage));
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


        private void addLocationFlyout_Closed(Object sender, Object e)
        {
            //(sender as Flyout).FlyoutPresenterStyle.

            gpsFlyoutIsOpened = false;

        }

        private void addLocationFlyout_Opened(Object sender, Object e)
        {
            //(sender as Flyout).FlyoutPresenterStyle.

            gpsFlyoutIsOpened = true;
            
        }

    }
}
