using DataLab.Data.Planning;
using DataLab.Tools;
using Planner.Data.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;
using Windows.Devices.Geolocation.Geofencing;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Services.Maps;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace Planner
{
    public sealed partial class PlannerMapControl : UserControl, INotifyPropertyChanged
    {

        public object obb { get; set; }

        // Enums
        public enum MapControlMode {  SEARCH_VIEW, OBSERVANT_VIEW };
        public enum MOVEMENT_BY { FOOT, VEHICLE };

        // Properties
        public MapControlMode Mode { get; set; } = MapControlMode.SEARCH_VIEW;

        public MOVEMENT_BY MovementMode { get; set; } = MOVEMENT_BY.FOOT;

        public BasicGeoposition LastSelectedLocation { get { return _lastSelectedLocation; } set { _lastSelectedLocation = value; Changed("LastSelectedLocation"); setLastLocationAsAddressString(); } }

        private string _currentAddress = "";
        public string CurrentAddress { get { return _currentAddress; } set { _currentAddress = value; Changed("CurrentAddress"); } }

        private string _currentDestinationAddress = "";
        public string CurrentDestinationAddress { get { return _currentDestinationAddress; } set { _currentDestinationAddress = value; Changed("CurrentDestinationAddress"); } }

        public event PropertyChangedEventHandler PropertyChanged;
        private Activity _destinationActivity;

        public Activity DestinationActivity { get { return _destinationActivity; } set { _destinationActivity = value; Changed("DestinationActivity");  } }

        private bool _trackerBusy;


        // Page dependant
        private Geolocator _geo;

        private BasicGeoposition _lastSelectedLocation;
        

        private MapIcon activeIcon = new MapIcon();

        //private bool _routeTrackerRunning { get; set; } = false;

        private bool RouteTrackerRunning { get; set; } = false;




        private BackgroundWorker ProximityTrackerWorker = new BackgroundWorker();

        public PlannerMapControl()
        {
            this.InitializeComponent();
            setMode(Mode);



            // Set thread
            //ProximityTrackerWorker.WorkerSupportsCancellation = true;
            //ProximityTrackerWorker.WorkerReportsProgress = true;

            //ProximityTrackerWorker.DoWork += ProximityTrackerWorker_DoWork;

        }

        private void _geo_PositionChanged(Geolocator sender, PositionChangedEventArgs args)
        {
            if (RouteTrackerRunning)
            {
                if (GeoTools.DistanceBetweenBasicGeoPoints(ClassConverters.geopositiontobgp(args.Position), LastSelectedLocation) > 3)
                {
                    setRouteOnMap();
                    setLastLocationAsAddressString();
                }
            }
            // Change if distance changed longer than 3 meters

        }

        private void ProximityTrackerWorker_DoWork(Object sender, DoWorkEventArgs e)
        {
            //// Proximity holder
            //while (!e.Cancel)
            //{
            //    // Check if in range every 3 seconds
            //    setmaptogps(0);
            //    Task.Delay(3000);
            //}
        }

        private async void MapControl_Loaded(object sender, RoutedEventArgs e)
        {
            this.DestinationActivity = DataContext as Activity;
            
            Debug.WriteLine(await Geolocator.RequestAccessAsync());
            _geo = new Geolocator() { DesiredAccuracyInMeters = 10 };
            setmaptogps(16);

            if (Mode == MapControlMode.OBSERVANT_VIEW)
            {
                Debug.WriteLine(" Set loaded as observant viewer");
                _geo.PositionChanged += _geo_PositionChanged;

            }


        }

        public async void setmaptogps(int zoom)
        {
            try
            {
                if (_trackerBusy)
                    throw new InvalidOperationException("Tracker already busy");

                _trackerBusy = true;
                
                //Debug.WriteLine(" Called ");
                // Set location to our current gps
                var position = await _geo.GetGeopositionAsync();
                
                LastSelectedLocation = ClassConverters.geopositiontobgp(position);
                await mainMap.TrySetViewAsync(new Geopoint(LastSelectedLocation));
                if (zoom > 0 && 20 > zoom)
                {
                    
                    mainMap.ZoomLevel = zoom;
                    await mainMap.TryZoomInAsync();
                        

                    if (Mode == MapControlMode.OBSERVANT_VIEW)
                    {
                        if (!RouteTrackerRunning)
                            setRouteOnMap();

                        RouteTrackerRunning = !RouteTrackerRunning;
                    }

                }

                setDestinationAsAddressString();

                _trackerBusy = false;

            } catch (Exception e)
            {
                //User needs permissions to access location
                // ACTION REQUIRED, TELL THE USER
                Debug.WriteLine(e.Message);
            }
        }

        private async void okayButton_Click(object sender, RoutedEventArgs e)
        {
            //// Try because we can't check if struct is a NULL, nor an int.
            //try
            //{
            //    if (Mode == MapControlMode.OBSERVANT_VIEW)
            //    {

            //    }
            //} catch (Exception f)
            //{
            //    Debug.WriteLine(f.Message);
            //}



        }


        private async void setLastLocationAsAddressString()
        {
            
            MapLocationFinderResult result = await MapLocationFinder.FindLocationsAtAsync(new Geopoint(LastSelectedLocation));

            if (result.Status == MapLocationFinderStatus.Success)
            {
                if (result.Locations[0].Address.FormattedAddress != "")
                    CurrentAddress = result.Locations[0].Address.FormattedAddress;
                else
                    CurrentAddress = result.Locations[0].Address.FormattedAddress;

                Changed("CurrentAddress");
            }
        }

        private async void setDestinationAsAddressString()
        {
            Debug.WriteLine("setDestinationAsAddressString()");
            if (_destinationActivity != null)
            {
                Debug.WriteLine("Working");
                MapLocationFinderResult result = await MapLocationFinder.FindLocationsAtAsync(new Geopoint(_destinationActivity.Location));

                if (result.Status == MapLocationFinderStatus.Success)
                {
                    if (result.Locations[0].Address.FormattedAddress != "")
                    {
                        Debug.WriteLine(result.Locations[0].Address.FormattedAddress);
                        CurrentDestinationAddress = result.Locations[0].Address.FormattedAddress;

                    }

                    Changed("CurrentDestionationAddress");
                }
            }

        }


        private async void findMeGPSButton_Click(object sender, RoutedEventArgs e)
        {
            switch (Mode)
            {
                case MapControlMode.OBSERVANT_VIEW:
                    setmaptogps(2);
                    break;
                case MapControlMode.SEARCH_VIEW:
                    setmaptogps(2);


                    break;
            }
        }

        private void MapControl_MapTapped(MapControl sender, MapInputEventArgs args)
        {
            if (Mode == MapControlMode.SEARCH_VIEW)
            {
                sender.MapElements.Remove(activeIcon);

                LastSelectedLocation = args.Location.Position;
                activeIcon.Location = args.Location;

                sender.MapElements.Add(activeIcon);

                Debug.WriteLine("Added maptapped");
            }

        }

        private void MapControl_MapElementClick(Windows.UI.Xaml.Controls.Maps.MapControl sender, Windows.UI.Xaml.Controls.Maps.MapElementClickEventArgs args)
        {

        }

        public void Changed(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }


        private void proximityNotification_Click(Object sender, RoutedEventArgs e)
        {
            // Turn on tracker
            if ((sender as CheckBox).IsChecked.Value)
                enableProximityTracker();
            else
                disableProximityTracker();


        }
        
        private void disableProximityTracker()
        {
            ProximityTrackerWorker.CancelAsync();

        }

        private void enableProximityTracker()
        {
            ProximityTrackerWorker.RunWorkerAsync();

        }


        private async void setActivity()
        {
            Debug.WriteLine("Set Activity");
            Activity activity = DataContext as Activity;
            Debug.WriteLine("Activity is null? {0}", activity == null);

            if (activity != null)
            {
                await mainMap.TrySetViewAsync(activity.LocationAsGeopoint, 10D);

                while (mainMap.ZoomLevel < 19)
                {
                    await mainMap.TryZoomInAsync();
                }

                Geocircle geo = new Geocircle(activity.Location, 10);
                Geofence geofence = new Geofence(new Random().Next(1000).ToString(), geo,
                                                MonitoredGeofenceStates.Entered, true, TimeSpan.FromMilliseconds(20),
                                                DateTime.Now, TimeSpan.FromHours(1));

            }
        }

        public void setMode(MapControlMode mode)
        {
            switch (mode)
            {
                case MapControlMode.OBSERVANT_VIEW:
                    findMeGPSButton.Visibility = Visibility.Collapsed;
                    break;

                case MapControlMode.SEARCH_VIEW:
                    findMeGPSButton.Visibility = Visibility.Visible;
                    setDestinationAsAddressString();
                    break;
            }
        }


        private async Task<MapRouteFinderResult> planRoute(MOVEMENT_BY movementBy, Geopoint currentPosition, Geopoint destination)
        {
            switch (movementBy)
            {
                case MOVEMENT_BY.FOOT:
                    return await MapRouteFinder.GetWalkingRouteAsync(currentPosition, destination);
                    break;
                case MOVEMENT_BY.VEHICLE:
                    return await MapRouteFinder.GetDrivingRouteAsync(currentPosition, destination);
                    break;

            }

            throw new InvalidDataException("No Route Found");
        }

        private async void setRouteOnMap()
        {
            // Get gps coordinates
            //Geopoint position = ClassConverters.geopositiontogeopoint(await _geo.GetGeopositionAsync());

            try
            {
                MapRouteView route = new MapRouteView((await planRoute(MovementMode, new Geopoint(LastSelectedLocation), DestinationActivity.LocationAsGeopoint)).Route);
                route.RouteColor = Colors.Red;
                route.OutlineColor = Colors.Cyan;
                
                mainMap.Routes.Add(route);

                await mainMap.TrySetViewBoundsAsync(route.Route.BoundingBox,
                                                    null,
                                                    Windows.UI.Xaml.Controls.Maps.MapAnimationKind.Bow);

                distanceFromTextBlock.Text = route.Route.LengthInMeters.ToString() + " meters";

            } catch (InvalidDataException e)
            {
                // No route
            }
        }

    }
}
