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
using Windows.Management;
using System.Diagnostics;

using DataLab.Storage;

using Planner.Data.Notify;
using Windows.UI.Xaml.Controls.Maps;
using Planner.Data.Converters;
using Planner.Data;
using DataLab.Data.Planning;
using System.Collections.ObjectModel;
using Windows.Security.ExchangeActiveSyncProvisioning;
using Windows.System.Profile;
using System.Threading.Tasks;
using Planner;



// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Planner
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ActivitiesPage : Page
    {
        
        private Point manipulationStartingPoint;
         
        public PlanningItemStorage Planning { get; set; }

        public SettingsStorage Storage { get; set; }

        private bool singleActivityNameSortedAscending, singleActivityTimeSortedAscending, repeatingActivityNameSortedAscending, repeatingActivityTimeSortedAscending;

        //public SolidColorBrush RandomColor { get { return new SolidColorBrush(RandomColorGenerator.randomColor()); } }

        public ActivitiesPage()
        {
            
            // Connect the client to the server
            //plan.plan.cleanOldItems(new SettingsStorage().Settings.PlanningItemExperation);
            
            this.InitializeComponent();

            this.FontFamily = new FontFamily("Times New Roman");
            this.FontSize = 11;

        }
        

        private void Grid_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AddToDoItemPage), Planning);
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            PlanningItemStorage p = e.Parameter as PlanningItemStorage;

            if (p != null)
            {
                Planning = p;
            } else
            {
                Planning = new PlanningItemStorage();
                Storage = new SettingsStorage();                
            }

            //Planning.plan.Activities.Add(null);
            //Planning.plan.Activities.RemoveAt(Planning.plan.Activities.Count - 1);
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
            this.Frame.Navigate(typeof(AddActivity), Planning);
        }

        private async void MapControl_Loaded(object sender, RoutedEventArgs e)
        {
            MapControl map  = (MapControl)sender;
            Activity activity = map.DataContext as Activity;

            await map.TrySetViewAsync(activity.Location, 10D);

            while (map.ZoomLevel < 19) {
                await map.TryZoomInAsync();
            }
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

        private void Grid_ManipulationStarted(object sender, ManipulationStartedRoutedEventArgs e)
        {
            manipulationStartingPoint = e.Position;
        }

        private void Grid_ManipulationCompleted(object sender, ManipulationCompletedRoutedEventArgs e)
        {
            if (Math.Abs(e.Position.X - manipulationStartingPoint.X) >= 75)
            {
                // Right
                if (e.Position.X > manipulationStartingPoint.X)
                    this.Frame.Navigate(typeof(ToDoPage), Planning);
                else // Left 
                    this.Frame.Navigate(typeof(SettingsPage), Planning);
            }
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

            Debug.WriteLine(but.DataContext is Activity);

            this.Frame.Navigate(typeof(AddActivity), new Tuple<PlanningItemStorage, Activity>(Planning, but.DataContext as Activity));
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
                else {
                    block.Visibility = Visibility.Collapsed;
                    panel.Height = 35;
                }
            }
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
    }
}
