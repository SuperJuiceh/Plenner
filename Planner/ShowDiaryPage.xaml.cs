using DataLab.Data.Planning;
using DataLab.Storage;
using Planner.Data;
using Planner.Data.Styling;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Planner
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ShowDiaryPage : Page
    {

        public Diary Journal { get; set; }

        public PlanningItemStorage plan { get; set; }
        public SettingsStorage Settings { get; set; }

        public ShowDiaryPage()
        {
            plan = GeneralApplicationData.Planning;
            Settings = GeneralApplicationData.Settings;

            UserStyleFactory.addStyles(this.Resources, this.Settings.Settings);

            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            
            // Navigated from diary creation
            Diary diary = e.Parameter as Diary;

            if (plan != null)
            {
                Journal = diary;

                return;
            }

        }

        private void Grid_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DiariesPage));
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
