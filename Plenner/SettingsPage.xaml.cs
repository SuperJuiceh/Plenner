using DataLab.Storage;
using Datalab.Server.Packets;
using DataLab.Data.Users;
using Plenner.Data;
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
using DataLab.NetworkPackaging;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Plenner
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SettingsPage : Page
    {

        private Point manipulationStartingPoint;

        public PlanningItemStorage plan { get; set; }

        public SettingsStorage Settings { get; set; }

        public SettingsPage()
        {
            try
            {
                this.InitializeComponent();
                
            }
            catch (Exception ex)
            {
                // Log error (including InnerExceptions!)
                // Handle exception
                Debug.WriteLine(ex.Message);
            }

            //setSettingsFromFile();

        }

        private void RelativePanel_ManipulationStarted(object sender, ManipulationStartedRoutedEventArgs e)
        {
            manipulationStartingPoint = e.Position;
        }

        private void RelativePanel_ManipulationCompleted(object sender, ManipulationCompletedRoutedEventArgs e)
        {
            if (Math.Abs(e.Position.X - manipulationStartingPoint.X) >= 75)
            {
                if (e.Position.X > manipulationStartingPoint.X)
                    this.Frame.Navigate(typeof(ActivitiesPage), plan);
                else
                    this.Frame.Navigate(typeof(ReflectionsPage), plan);
            }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            PlanningItemStorage planning = e.Parameter as PlanningItemStorage;

            if (planning != null)
            {
                this.plan = planning;
            }

            if (Settings == null)
                Settings = new SettingsStorage();
            
        }

        private void setSettingsFromFile()
        {
            // Load settings file
            Settings = new SettingsStorage();

            if (Settings.Settings.PlanningItemExperation != null)
            {
                Debug.Write("Found PIe: with hours: " + Settings.Settings.PlanningItemExperation.Hours);
                //DaysComboBox.SelectedItem = DaysComboBox.Items.Where(cbb => (cbb 
            }


        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (PacketClient.Connected)
                this.Frame.Navigate(typeof(UserPage), plan);
            else
                setPopup("Cannot navigate to userpage", "You have no connection to the server.");
        }

        private void checkBox2_Checked(object sender, RoutedEventArgs e)
        {

        }
        
        private void HoursComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            // Add values 1 to 100 to Days
            ComboBox cBox = sender as ComboBox;

            for (int number = 0; number < 24; number++)
            {
                cBox.Items.Add(number);
            }
        }

        private void MinutesComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            // Add values 1 to 100 to Days
            ComboBox cBox = sender as ComboBox;

            for (int number = 0; number < 59; number++)
            {
                cBox.Items.Add(number);
            }
        }

        private void SecondsComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            // Add values 1 to 100 to Days
            ComboBox cBox = sender as ComboBox;

            for (int number = 0; number < 59; number++)
            {
                cBox.Items.Add(number);
            }
        }

        private void DaysComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            // Add values 1 to 100 to Days
            ComboBox cBox = sender as ComboBox;

            for (int number = 0; number < 100; number++)
            {
                cBox.Items.Add(number);
            }
        }

        private void save_button_Click(object sender, RoutedEventArgs e)
        {
            //if (planningItemExperationCheckBox.IsChecked.Value)
            //{
            //    Settings.Settings.PlanningItemExperation = new TimeSpan(
            //         (int)((DaysComboBox.SelectedItem as ComboBoxItem).Content),
            //         (int)((HoursComboBox.SelectedItem as ComboBoxItem).Content),
            //         (int)((MinutesComboBox.SelectedItem as ComboBoxItem).Content),
            //         (int)((SecondsComboBox.SelectedItem as ComboBoxItem).Content)
            //    );
            //}

            if (planningItemExperationCheckBox.IsChecked.Value)
            {
                Settings.Settings.PlanningItemExperation = new TimeSpan(
                     (int)(DaysComboBox.SelectedItem),
                     (int)((HoursComboBox.SelectedItem)),
                     (int)((MinutesComboBox.SelectedItem)),
                     (int)((SecondsComboBox.SelectedItem))
                );
            }

            Settings.saveStorage();

            Debug.WriteLine("Saved Settings");

        }

        private void soundEnabledCheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void setPopup(string title, string message)
        {
            Debug.WriteLine("Setting popup");

            popupTitle.Text = title;
            popupMessage.Text = message;

            popup.IsOpen = true;
            //popup.UpdateLayout();
        }

        private void Button_Click_1(Object sender, RoutedEventArgs e)
        {
            popup.IsOpen = false;
            //popup.UpdateLayout();
        }
    }
}
