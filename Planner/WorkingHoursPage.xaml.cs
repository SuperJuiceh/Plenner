using DataLab.Data.Work;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Planner
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class WorkingHoursPage : Page
    {

        public WorkingPlace Place { get; set; } = new WorkingPlace("Schaopskooi");

        public DateTime? CurrentStartTime { get; set; }
        public DateTime? CurrentEndTime { get; set; }


        public WorkingHoursPage()
        {
            this.InitializeComponent();
        }

        private void addNewHoursButton_Click(object sender, RoutedEventArgs e)
        {



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

        private void endRadioButtonFlyout_Closed(Object sender, Object e)
        {
            endRadioButton.IsChecked = false;
            startRadioButton.IsChecked = true;

            DateTime dt = new DateTime(enddatePicker.Date.Year, enddatePicker.Date.Month, enddatePicker.Date.Day, endtimePicker.Time.Hours, endtimePicker.Time.Minutes, endtimePicker.Time.Seconds);


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

        private void addTheHoursButton_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentStartTime.HasValue && CurrentEndTime.HasValue)
            {
                WorkingHours hours = new WorkingHours(CurrentStartTime.Value, CurrentEndTime.Value);

                Place.addWorkingHours(hours);

                Debug.WriteLine("Hours added");
            }
        }
    }
}
