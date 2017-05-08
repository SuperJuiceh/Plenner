using DataLab.Storage;
using DataLab.Data.Planning;
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
using Planner.Data.Styling;
using Planner.Data;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Planner
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DiariesPage : Page
    {

        public PlanningItemStorage plan { get; set; }
        public SettingsStorage Settings { get; set; }

        public DiariesPage()
        {
            plan =     GeneralApplicationData.Planning;
            Settings = GeneralApplicationData.Settings;

            UserStyleFactory.addStyles(this.Resources, this.Settings.Settings);

            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            
        }

        private void removeDiaryButton_Click(object sender, RoutedEventArgs e)
        {
            Diary diary = (sender as Button).DataContext as Diary;

            if (diary != null)
            {
                plan.removeDiary(diary);
            }
        }

        private void Grid_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ReflectionsPage));
        }

        private void addDiaryButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AddDiaryPage));
        }

        private void show_history_button_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to: ???
        }
    }
}
