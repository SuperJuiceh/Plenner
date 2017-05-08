using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Activation;
using Windows.UI.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Diagnostics;
using Plenner.Data;

using DataLab.NetworkPackaging;
using DataLab.Storage;
using System.Threading.Tasks;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Plenner
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ExtendedSplash : Page
    {

        private SplashScreen _splash;

        private Frame rootFrame;

        public string LaunchParameters = "";

        public ExtendedSplash()
        {
            this.InitializeComponent();
        }

        public ExtendedSplash(SplashScreen splashscreen, Frame root)
        {
            this.InitializeComponent();

            sb1.Begin();

            this.rootFrame = root;

            _splash = splashscreen;

            this.Loaded += ExtendedSplash_Loaded;
        }

        private async void ExtendedSplash_Loaded(object sender, RoutedEventArgs e)
        {
            if (_splash != null)
            {
                loadingStatusTextBlock.Text = "Attempting servercomunication, patience please";
                //await PacketClient.Connect();

                // Register an event handler to be executed when the splash screen has been dismissed.
                _splash.Dismissed += new TypedEventHandler<SplashScreen, Object>(DismissedEventHandler);

            }
        }

        // Include code to be executed when the system has transitioned from the splash screen to the extended splash screen (application's first view).
        async void DismissedEventHandler(SplashScreen sender, object e)
        {
            // Navigate to ActivitiesPage
            await Windows.ApplicationModel.Core.CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(CoreDispatcherPriority.High, () => {

                //if (!PacketClient.Connected)
                //    PacketClient.Stop();
                // Place the frame in the current Window
                var planning = new PlanningItemStorage();
                loadingStatusTextBlock.Text = "Loading Planner XML Data";

                if (planning.waitToLoad(5)) // Wait until the plan is loaded 
                {
                    if (LaunchParameters == "")
                    {
                        this.rootFrame.Navigate(typeof(ActivitiesPage), planning);
                    } else
                    {
                        Debug.WriteLine("Launch parameters are {0}", LaunchParameters);
                        this.rootFrame.Navigate(typeof(ActivitiesPage), new Tuple<PlanningItemStorage, string>(planning, LaunchParameters));
                        
                    }

                    Window.Current.Content = rootFrame;

                } 

            });
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
        }

        private void Grid_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            _splash.Dismissed += new TypedEventHandler<SplashScreen, Object>(DismissedEventHandler);
        }
    }
}
