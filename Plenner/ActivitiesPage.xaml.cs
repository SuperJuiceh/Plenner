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

using Plenner.Data.Notify;
using Windows.UI.Xaml.Controls.Maps;
using Plenner.Data.Converters;
using Plenner.Data;
using DataLab.Data.Planning;
using System.Collections.ObjectModel;
using Windows.Security.ExchangeActiveSyncProvisioning;
using Windows.System.Profile;
using System.Threading.Tasks;
using Windows.Storage.Streams;
using Windows.Devices.Geolocation;
using Windows.Services.Maps;
using Windows.UI;
using DataLab.Tools;
using Windows.ApplicationModel.Core;
using DataLab.Data;
using RuntimeComponent1;



// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Plenner
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ActivitiesPage : Page
    {
        
        private Point manipulationStartingPoint;
         
        public PlanningItemStorage Planning { get; set; }

        public SettingsStorage Storage { get; set; }

        private bool    singleActivityNameSortedAscending,      singleActivityTimeSortedAscending, 
                        repeatingActivityNameSortedAscending,   repeatingActivityTimeSortedAscending;

        private bool    _mapRunning = false;

        private Geocoordinate _lastGeoPosition;

        private MapControl _currentMap;

        private Activity CurrentActivity;

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

            Tuple<PlanningItemStorage, string> ps = e.Parameter as Tuple<PlanningItemStorage, string>;

            if (ps != null)
            {
                Planning = ps.Item1;

                // Open correct flyout and show result in map
                
            }

            //Planning.plan.Activities.Add(null);
            //Planning.plan.Activities.RemoveAt(Planning.plan.Activities.Count - 1);
        }

        private void textBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
        // Delete activity button
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
            
            //// DUMMY CODE, BROKEN APPLICATION DUE TO THIS
            //Geolocator locator = new Geolocator();
            //locator.PositionChanged += Locator_PositionChanged;
            //locator.DesiredAccuracy = PositionAccuracy.High;
            //locator.ReportInterval = 1000;
            //locator.DesiredAccuracyInMeters = 1;

            //new FenceItem("Location One", ClassConverters.geopositiontobgp(await locator.GetGeopositionAsync()));

            //Application.Current.Exit();     
            //// END DUMMY CODE
            
            MapControl map = sender as MapControl;
            
            //map.Style = MapStyle.Aerial3DWithRoads;

            map.MapElements.Clear();
            

            CurrentActivity = map.DataContext as Activity;
            //(map.Parent as RelativePanel).dire
            //Debug.WriteLine("Trying to set view, location is {0}:{1}:{2}", activity.Location.Position.Altitude, activity.Location.Position.Latitude, activity.Location.Position.Longitude);
            
            await map.TrySetViewAsync(CurrentActivity.Location);
            // Set location in GUI
            await CoreApplication.GetCurrentView().CoreWindow.Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, async () =>
            {
                RelativePanel panel = map.Parent as RelativePanel;

                MapLocationFinderResult result = await MapLocationFinder.FindLocationsAtAsync(CurrentActivity.Location);

                if (result.Status == MapLocationFinderStatus.Success)
                {
                    if (result.Locations[0]?.Description != "")
                        (panel.FindName("destinationTextBlockInput") as TextBlock).Text = result.Locations[0].Description;
                    else
                        (panel.FindName("destinationTextBlockInput") as TextBlock).Text = result.Locations[0].Address.FormattedAddress;
                }
                
            });
            
            // Set mapicon
            //Debug.WriteLine("View was set {0}", map.ZoomLevel.ToString());
            // Set to zoomlevel 10, to reduce overal zoom-in time
            //map.ZoomLevel = 6;
            while (map.ZoomLevel > 5)
            {
                await map.TryZoomInAsync();
            }

            runMapControlWithRouteWalking(map, CurrentActivity.Location);
            //map.ZoomLevel = 20;


        }

        private async void runMapControlWithRouteWalking(MapControl map, Geopoint goToLocation)
        {
            Geolocator locator = new Geolocator();
            locator.PositionChanged += Locator_PositionChanged;
            locator.DesiredAccuracy = PositionAccuracy.High;
            locator.ReportInterval = 1000;
            locator.DesiredAccuracyInMeters = 1;

            _mapRunning = true;
            _currentMap = map;

            // Show go-to location on map
            MapIcon element = new MapIcon();
            element.Image = RandomAccessStreamReference.CreateFromUri(new Uri("ms-appx:///Assets/pinpoint_gps_small.png"));
            element.Location = goToLocation;

            _currentMap.MapElements.Add(element);
            
            while (_mapRunning)
            {
                // Wait until flyout closed
                //Debug.WriteLine("Map running");
                await Task.Delay(500);
                
            }

            locator.PositionChanged -= Locator_PositionChanged;
            _currentMap.MapElements.Clear();
            _currentMap.Routes.Clear();

            _currentMap = null;
            

        }

        private async void Locator_PositionChanged(Geolocator sender, PositionChangedEventArgs args)
        {
            bool firstTimeMap = false;
            Geocoordinate newPosition = args.Position.Coordinate;

            if (_lastGeoPosition == null)
            {
                _lastGeoPosition = newPosition;
                firstTimeMap = true;
            }
            if (GPSCalculations.distanceBetween(newPosition, _lastGeoPosition) > 1 || firstTimeMap)
            {
                newPosition = _lastGeoPosition;
                

                _lastGeoPosition = args.Position.Coordinate;
                await Windows.ApplicationModel.Core.CoreApplication.MainView.Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, async () =>
                {
                    try
                    {
                        while (_currentMap.MapElements.Count > 1)
                            _currentMap.MapElements.Remove(_currentMap.MapElements.Last());

                        // Add current location to map
                        MapIcon icon = new MapIcon();
                        icon.Image = RandomAccessStreamReference.CreateFromUri(new Uri("ms-appx:///Assets/YouAreHere.png"));

                        Geopoint location = new Geopoint(ClassConverters.geopositiontobgp(await sender.GetGeopositionAsync()));

                        icon.Location = location;

                        _currentMap.MapElements.Add(icon);

                        // Create route
                        MapRouteFinderResult route = await MapRouteFinder.GetWalkingRouteAsync(location, CurrentActivity.Location);
                        if (route.Status == MapRouteFinderStatus.Success)
                        {
                            _currentMap.Routes.Clear();
                            // Use the route to initialize a MapRouteView.
                            MapRouteView viewOfRoute = new MapRouteView(route.Route);
                            viewOfRoute.RouteColor = Colors.Cyan;
                            viewOfRoute.OutlineColor = Colors.Black;

                            // Add the new MapRouteView to the Routes collection
                            // of the MapControl.
                            _currentMap.Routes.Add(viewOfRoute);
                            
                            // Fit the MapControl to the route.
                            await _currentMap.TrySetViewBoundsAsync(
                                  route.Route.BoundingBox,
                                  null,
                                  Windows.UI.Xaml.Controls.Maps.MapAnimationKind.Default);
                            
                            // Set GUI elements
                            ((_currentMap.Parent as RelativePanel).FindName("distanceToGoTextBlock") as TextBlock).Text = (double)(viewOfRoute.Route.LengthInMeters / 1000) + "km";
                            
                            MapLocationFinderResult result = await MapLocationFinder.FindLocationsAtAsync(location);

                            if (result.Status == MapLocationFinderStatus.Success)
                            {
                                if (result.Locations[0].Description != "")
                                    ((_currentMap.Parent as RelativePanel).FindName("currentLocationTextBlockInput") as TextBlock).Text = result.Locations[0].Description;
                                else
                                    ((_currentMap.Parent as RelativePanel).FindName("currentLocationTextBlockInput") as TextBlock).Text = result.Locations[0].Address.FormattedAddress;
                            }
                        }
                    } catch (Exception e)
                    {
                        Debug.WriteLine(e.Message);
                    }
                });                
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

        private void button3_Click_1(Object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CijfersPage), Planning);
        }

        private async void Flyout_Opened(object sender, object e)
        {
            Flyout fOut = sender as Flyout;

            if (fOut != null)
            {
                //fOut.ShowAt(mainGrid);
                
            }
            //Debug.WriteLine("Flyout opened");

            //RelativePanel rp = (RelativePanel)VisualTreeHelper.GetChild(sender as Flyout, 0);

            //MapControl map = (MapControl)VisualTreeHelper.GetChild(rp, 1);

            //Activity activity = map.DataContext as Activity;
            //Debug.WriteLine("Trying to set view, location is {0}:{1}:{2}", activity.Location.Position.Altitude, activity.Location.Position.Latitude, activity.Location.Position.Longitude);

            //await map.TrySetViewAsync(activity.Location);
            //Debug.WriteLine("View was set ");

            //while (map.ZoomLevel < 19)
            //{
            //    await map.TryZoomInAsync();
            //}
        }

        private void proximity_standy_button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void proximity_standy_button_Click_1(object sender, RoutedEventArgs e)
        {
            // Check proximity check
            Button button = sender as Button;

            if (button != null)
            {
                Tuple<string, BasicGeoposition> info = button.Tag as Tuple<string, BasicGeoposition>;

                if (info != null)
                {
                    FenceItem item = new FenceItem(info.Item1, info.Item2);

                    // Close app
                    //Application.Current.Exit();
                }
            }

        }

        private void Flyout_Closed(object sender, object e)
        {
            _mapRunning = false;
        }

        private void Button_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private async void zoomInButton_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await _currentMap?.TryZoomInAsync();
        }

        private async void zoomOutButton_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await _currentMap?.TryZoomOutAsync();
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
