using DataLab.Data.Planning;
using DataLab.Storage;
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

        public ShowDiaryPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            PlanningItemStorage piStorage = e.Parameter as PlanningItemStorage;

            if (piStorage != null)
            {
                plan = piStorage;

                return;
            }
            // Navigated from diary creation
            Tuple<PlanningItemStorage, Diary> sdTuple = e.Parameter as Tuple<PlanningItemStorage, Diary>;

            if (plan != null)
            {
                plan = sdTuple.Item1;
                Journal = sdTuple.Item2;

                return;
            }

        }

        private void Grid_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DiariesPage), plan);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
