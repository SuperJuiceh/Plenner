using DataLab.Data.Planning;
using Planner.Data.Converters;
using DataLab.Storage;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using DataLab.Tools.Connectivity;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Planner
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ReflectionsPage : Page
    {
        public PlanningItemStorage plan { get; set; }
        public Point manipulationStartingPoint { get; set; }

        private bool sortByNameAscending, sortByFeelingAscending;

        public ReflectionsPage()
        {
            this.InitializeComponent();
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
                    this.Frame.Navigate(typeof(SettingsPage), plan);
                else
                    this.Frame.Navigate(typeof(ToDoPage), plan);
            }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            if (e.Parameter is PlanningItemStorage)
            {
                plan = e.Parameter as PlanningItemStorage;
            }
        }

        private void addReflectionButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AddReflectionPage), plan);
        }

        private void showJournalButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DiariesPage), plan);
        }

        private void Flyout_Opened(object sender, object e)
        {
               
        }

        private void MapControl_MapTapped(Windows.UI.Xaml.Controls.Maps.MapControl sender, Windows.UI.Xaml.Controls.Maps.MapInputEventArgs args)
        {
            // Niets
        }

        private void MapControl_Loaded(object sender, RoutedEventArgs e)
        {
            MapControl map = sender as MapControl;

            if (map != null)
            {
                try
                {
                    BasicGeoposition point = (BasicGeoposition)map.DataContext;
                    setmaptogps(map, point);
                }
                catch (InvalidCastException)
                {
                    Debug.WriteLine("Cannot cast to bgp");
                }
            }            
        }

        private void MapControl_MapElementClick(Windows.UI.Xaml.Controls.Maps.MapControl sender, Windows.UI.Xaml.Controls.Maps.MapElementClickEventArgs args)
        {

        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            //setmaptogps(mainMap, await _geo.GetGeopositionAsync());
        }
        

        private async void setmaptogps(MapControl map, BasicGeoposition pos)
        {
            await map.TrySetViewAsync(new Geopoint(pos));
            while (map.ZoomLevel < 18)
            {
                await map.TryZoomInAsync();
            };
        }

        private void deleteReflectionButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            Reflection reflection = button.DataContext as Reflection;

            if (reflection != null)
            {
                plan.removePlanningItem(reflection);
            }
        }

        private void nameHeaderTextBlock_Tapped(object sender, TappedRoutedEventArgs e)
        {
            // Orderedlist placeholder
            IOrderedEnumerable<Reflection> ok;
            // How will we sort the data? (Asc/Desc)
            if (sortByNameAscending)
                ok = plan.plan.Reflections.OrderBy(item => item.Name);
            else
                ok = plan.plan.Reflections.OrderByDescending(item => item.Name);

            // Flip state
            sortByNameAscending = !sortByNameAscending;

            List<Reflection> items = ok.ToList();

            if (ok.Count() > 0)
            {
                plan.plan.Reflections.Clear();
                // Add all items from the list
                items.ForEach(item =>
                {
                    plan.plan.Reflections.Add(item);
                });
            }

            sortByFeelingAscending = false;


        }

        private void feelingHeaderTextBlock_Tapped(object sender, TappedRoutedEventArgs e)
        {
            // Orderedlist placeholder
            IOrderedEnumerable<Reflection> ok;
            // How will we sort the data? (Asc/Desc)
            if (sortByFeelingAscending)
                ok = plan.plan.Reflections.OrderBy(item => item.Feeling.ToString());
            else
                ok = plan.plan.Reflections.OrderByDescending(item => item.Feeling.ToString());

            // Flip state
            sortByFeelingAscending = !sortByFeelingAscending;

            List<Reflection> items = ok.ToList();

            if (ok.Count() > 0)
            {
                plan.plan.Reflections.Clear();
                // Add all items from the list
                items.ForEach(item =>
                {
                    plan.plan.Reflections.Add(item);
                });
            }

            sortByNameAscending = false;
        }

        private void listViewRelativePanel_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            RelativePanel panel = sender as RelativePanel;

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

        private void mailActivityButton_Click(object sender, RoutedEventArgs e)
        {
            Reflection reflection = (sender as Button).Tag as Reflection;

            if (reflection != null)
            {
                MailClient.sendMailWithPlanning(plan, reflection);
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            plan.clear(Plan.Clear_Options.REFLECTIONS);
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void todoitemsButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ToDoPage));
        }

        private void activitiesButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ActivitiesPage));
        }

        private void splitViewOpenCloseButton_Click(object sender, RoutedEventArgs e)
        {
            mainSplitView.IsPaneOpen = !mainSplitView.IsPaneOpen;
        }

        private void settingsButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SettingsPage));
        }
    }
}
