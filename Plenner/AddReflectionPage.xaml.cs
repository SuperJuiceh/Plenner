using Plenner.Data.Converters;
using Plenner.Data.Notify;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Imaging;
using Windows.Media.Capture;
using Windows.Services.Maps;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using DataLab.Data.Planning;
using DataLab.Storage;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Plenner
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AddReflectionPage : Page, INotifyPropertyChanged
    {
        public SoftwareBitmapSource _poto;
        public SoftwareBitmapSource Poto { get { return _poto; } set { _poto = value; Changed("Poto"); } }

        public StorageFile Photo { get; set; }

        public PlanningItemStorage plan { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private Geolocator _geo;

        private BasicGeoposition _lastSelectedLocation;

        private MapControl mainMap;

        private MapIcon activeIcon = new MapIcon();

        private Reflection.Feelings SelectedFeeling { get; set; } = Reflection.Feelings.NEUTRAL;

        public AddReflectionPage()
        {
            this.InitializeComponent();
        }

        private void photoButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private async void Flyout_Opened(object sender, object e)
        {
            Flyout fOut = sender as Flyout;

            if (Photo == null)
            {
                fOut.Hide();
                CameraCaptureUI camera = new CameraCaptureUI();
                camera.PhotoSettings.CroppedAspectRatio = new Size(300, 250);
                camera.PhotoSettings.Format = CameraCaptureUIPhotoFormat.Png;
                
                StorageFile tempPhoto = await camera.CaptureFileAsync(CameraCaptureUIMode.Photo);

                //var files = (await (await tempPhoto.GetParentAsync()).GetFilesAsync());
                // files.ToList().ForEach(async file => await file.DeleteAsync());
                                                
                if (tempPhoto != null)
                {
                    Debug.WriteLine(tempPhoto.Path);
                    
                    Photo = tempPhoto;
                    
                    Poto = new SoftwareBitmapSource();
                    
                    using (IRandomAccessStream stream = await Photo.OpenAsync(FileAccessMode.ReadWrite))
                    {
                        // Get the bitmap from file
                        try
                        {

                        BitmapDecoder decoder = await BitmapDecoder.CreateAsync(stream);
                        
                        // Transform the image
                        BitmapEncoder encoder = await BitmapEncoder.CreateForTranscodingAsync(stream, decoder);
                        encoder.BitmapTransform.Rotation = BitmapRotation.Clockwise90Degrees;
                        //await encoder.FlushAsync();

                        await Poto.SetBitmapAsync(SoftwareBitmap.Convert(await decoder.GetSoftwareBitmapAsync(), BitmapPixelFormat.Bgra8, BitmapAlphaMode.Premultiplied));
                        potoImage.Source = Poto;
                        }
                        catch (Exception ee)
                        {
                            Debug.WriteLine(ee.Message);
                        }

                        stream.Dispose();
                    }
                }
                
            }
        }

        private void createButton_Click(object sender, RoutedEventArgs e)
        {
            if (nameTextBox.Text != "" && descriptionTextBox.Text != "")
            {
                Reflection newReflection;
                

                if (Photo != null && _lastSelectedLocation.Altitude != 0)
                {
                    newReflection = new Reflection(nameTextBox.Text, descriptionTextBox.Text, Photo, _lastSelectedLocation);
                }
                else if (Photo != null)
                {
                    newReflection = new Reflection(nameTextBox.Text, descriptionTextBox.Text, Photo);
                }
                else if (_lastSelectedLocation.Altitude != 0)
                {
                    newReflection = new Reflection(nameTextBox.Text, descriptionTextBox.Text, _lastSelectedLocation);
                }
                else {
                    newReflection = new Reflection(nameTextBox.Text, descriptionTextBox.Text);
                }

                newReflection.Feeling = SelectedFeeling;
                plan.addPlanningItem(newReflection);

                ToastNotifier.setuptoasts(plan.plan);

                this.Frame.Navigate(typeof(ReflectionsPage), plan);
            }
        }

        private void Grid_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ReflectionsPage), plan);
        }

        public void Changed(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        ~AddReflectionPage()
        {
            if (PropertyChanged != null)
            {
                foreach (Delegate del in PropertyChanged.GetInvocationList())
                {
                    PropertyChanged -= (PropertyChangedEventHandler)del;
                }
            }

        }

        private async void locationButton_Click(object sender, RoutedEventArgs e)
        {
            setmaptogps(mainMap, await _geo.GetGeopositionAsync());
        }

        private void MapControl_MapTapped(Windows.UI.Xaml.Controls.Maps.MapControl sender, Windows.UI.Xaml.Controls.Maps.MapInputEventArgs args)
        {
            sender.MapElements.Remove(activeIcon);

            _lastSelectedLocation = args.Location.Position;
            activeIcon.Location = args.Location;

            sender.MapElements.Add(activeIcon);
        }

        private async void MapControl_Loaded(object sender, RoutedEventArgs e)
        {
            MapControl map = sender as MapControl;

            this.mainMap = map;

            Debug.WriteLine(await Geolocator.RequestAccessAsync());
            _geo = new Geolocator() { DesiredAccuracyInMeters = 10 };
            //setmaptogps(map, await _geo.GetGeopositionAsync());
        }

        private void MapControl_MapElementClick(Windows.UI.Xaml.Controls.Maps.MapControl sender, Windows.UI.Xaml.Controls.Maps.MapElementClickEventArgs args)
        {

        }

        private async void acceptLocationButton_Click(object sender, RoutedEventArgs e)
        {
            MapLocationFinderResult result = await MapLocationFinder.FindLocationsAtAsync(new Geopoint(_lastSelectedLocation));

            if (result.Status == MapLocationFinderStatus.Success)
            {
                if (result.Locations[0].Description != "")
                    selectedLocationTextBlock.Text = result.Locations[0].Description;
                else
                    selectedLocationTextBlock.Text = result.Locations[0].Address.FormattedAddress;
            }
        }


        private async void setmaptogps(MapControl map, Geoposition pos)
        {
            // Set location to our current gps
            _lastSelectedLocation = ClassConverters.geopositiontobgp(await _geo.GetGeopositionAsync());

            await map.TrySetViewAsync(new Geopoint(_lastSelectedLocation));
            while (map.ZoomLevel < 18)
            {
                await map.TryZoomInAsync();
            };
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            PlanningItemStorage p = e.Parameter as PlanningItemStorage;

            if (p != null)
            {
                plan = p;
            }
        }

        private void happyEmoticonButton_Click(object sender, RoutedEventArgs e)
        {
            SelectedFeeling = Reflection.Feelings.HAPPY;
        }

        private void madEmoticonButton_Click(object sender, RoutedEventArgs e)
        {
            SelectedFeeling = Reflection.Feelings.MAD;
            
        }

        private void neutralEmoticonButton_Click(object sender, RoutedEventArgs e)
        {
            SelectedFeeling = Reflection.Feelings.NEUTRAL;
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);

            
            Poto = null;

            Photo = null;
            
            
        }
    }
}
