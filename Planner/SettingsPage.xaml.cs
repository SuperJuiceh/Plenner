using DataLab.Storage;
using DataLab.Server.Packets;
using DataLab.Data.Users;
using Planner.Data;
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
using Windows.Globalization.Fonts;
using Planner.Data.Styling;
using DataLab.Tools.Connectivity;
using DataLab.Data.Planning;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Planner
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
            this.plan = GeneralApplicationData.Planning;
            this.Settings = GeneralApplicationData.Settings;

            this.Settings.Settings.PropertyChanged += Settings_PropertyChanged;

            UserStyleFactory.addStyles(this.Resources, Settings.Settings);
            
            this.InitializeComponent();

        }

        private void Settings_PropertyChanged(Object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            this.Settings.saveStorage();
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
            

        }

        private void setSettingsFromFile()
        {
            // Load settings file
            //Settings = new SettingsStorage();

            if (Settings.Settings.PlanningItemExperation != null)
            {
                
                if (Settings.Settings.PlanningItemExperation.Days + Settings.Settings.PlanningItemExperation.Hours + Settings.Settings.PlanningItemExperation.Minutes > 0)
                {
                    planningItemExperationCheckBox.IsChecked = true;

                    DaysComboBox.SelectedItem = Settings.Settings.PlanningItemExperation.Days;
                    DaysComboBox.SelectedItem = Settings.Settings.PlanningItemExperation.Hours;
                    DaysComboBox.SelectedItem = Settings.Settings.PlanningItemExperation.Minutes;
                    
                }

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

            if (planningItemExperationCheckBox.IsChecked.Value && DaysComboBox.SelectedIndex > -1 && HoursComboBox.SelectedIndex > -1 && MinutesComboBox.SelectedIndex > -1)
            {
                Settings.Settings.PlanningItemExperation = new TimeSpan(
                     (int)(DaysComboBox.SelectedItem),
                     (int)((HoursComboBox.SelectedItem)),
                     (int)((MinutesComboBox.SelectedItem)),
                     0
                );
            }

            Settings.saveStorage();

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



        private void selectedFont_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string text = (string)(sender as ComboBox).SelectedValue;
            try
            {
                FontFamily font = new FontFamily(text);
                Settings.Settings.FontTypeUser = text;

                UpdateLayout();
                InvalidateArrange();
            } catch (Exception)
            {
                Debug.WriteLine("font " + text + " does not exist");
            }
            
        }

        private void selectedFontSize_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int fontSize = (sender as ComboBox).SelectedIndex + 1;
            
            Settings.Settings.FontSizeUser = fontSize;
            
        }

        

        private void selectedFont_SizeChanged(object sender, SizeChangedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int iconNum = int.Parse((string)(sender as Button).Tag);

            // We have 4 icons
            if (iconNum > 0 && iconNum < 5)
            {
                Settings.Settings.NotificationIconString = "/Assets/NotificationIcons/notif_icon_" + iconNum.ToString() + ".png";

                Settings.saveStorage();

                currentImageButton.UpdateLayout();
            }
            
        }

        private void todoitemsButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ToDoPage));
        }

        private void activitiesButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ActivitiesPage));
        }


        private void reflectionsButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ReflectionsPage));
        }


        private void splitViewOpenCloseButton_Click(object sender, RoutedEventArgs e)
        {
            mainSplitView.IsPaneOpen = !mainSplitView.IsPaneOpen;
        }
    }
}
