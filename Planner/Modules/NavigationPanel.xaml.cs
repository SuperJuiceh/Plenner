using Planner.Data;
using Planner.Data.Styling;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace Planner.Modules
{
    public sealed partial class NavigationPanel : UserControl, INotifyPropertyChanged
    {
        
        public event PropertyChangedEventHandler PropertyChanged;


        private bool _activitiesButtonEnabled = true;
        public bool ActivitiesButtonEnabled { get { return _activitiesButtonEnabled; } set { _activitiesButtonEnabled = value; Changed("ActivitiesButtonEnabled"); } }

        private bool _reflectionsButtonEnabled = true;
        public bool ReflectionsButtonEnabled { get { return _reflectionsButtonEnabled; } set { _reflectionsButtonEnabled = value; Changed("ReflectionsButtonEnabled"); } }

        private bool _todoButtonEnabled = true;
        public bool ToDoButtonEnabled { get { return _todoButtonEnabled; } set { _todoButtonEnabled = value; Changed("ToDoButtonEnabled"); } }

        private bool _timeflowButtonEnabled = true;
        public bool TimeFlowButtonEnabled { get { return _timeflowButtonEnabled; } set { _timeflowButtonEnabled = value; Changed("TimeFlowButtonEnabled"); } }


        private bool _settingButtonEnabled = true;
        public bool SettingsButtonEnabled { get { return _timeflowButtonEnabled; } set { _settingButtonEnabled = value; Changed("SettingsButtonEnabled"); } }



        public NavigationPanel()
        {
            UserStyleFactory.addStyles(this.Resources, GeneralApplicationData.Settings.Settings);
            
            this.InitializeComponent();
        }

        private void splitViewOpenCloseButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            (Window.Current.Content as Frame).Navigate(typeof(TimeFlowPage));
        }

        private void todoitemsButton_Click(object sender, RoutedEventArgs e)
        {
            (Window.Current.Content as Frame).Navigate(typeof(ToDoPage));
        }

        private void reflectionsButton_Click(object sender, RoutedEventArgs e)
        {
            (Window.Current.Content as Frame).Navigate(typeof(ReflectionsPage));
        }

        private void settingsButton_Click(object sender, RoutedEventArgs e)
        {
            (Window.Current.Content as Frame).Navigate(typeof(SettingsPage));
        }

        private void activitiesButton_Click(object sender, RoutedEventArgs e)
        {
            (Window.Current.Content as Frame).Navigate(typeof(ActivitiesPage));
        }

        private void Changed(string name)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }


    }
}
