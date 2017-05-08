using DataLab.Data.Cijfers;
using DataLab.Data.Cijfers.CijferTaak;
using DataLab.Data.Planning;
using DataLab.Storage;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Plenner
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CijfersPage : Page
    {

        public PlanningItemStorage plan { get; set; }

        public Point manipulationStartingPoint { get; set; }

        public CijfersPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            PlanningItemStorage p = e.Parameter as PlanningItemStorage;

            if (p != null)
            {
                plan = p;
                // Test cijferlijst dates
                DateTime start = new DateTime(2017, 1, 31);
                DateTime end = new DateTime(2017, 4, 8);

                CijferPeriode periode = 
                    new CijferPeriode("Periode 3", start, end,
                            new Cijfertaak("Microcontrollers", 5.5, 10),
                            new Cijfertaak("P&OC 2.3", 5.5, 10),
                            new Cijfertaak("Wiskunde 1.4", 5.5, 10)
                    );

                periode.ToComplete[2].addPoging(new Cijfer(5));
               
                // Create cijferlijst
                CijferLijst lijst =
                    new CijferLijst("Periode 3",
                        periode
                );

                plan.plan.CijferLijsten.Add(lijst);
            } else
            {
                this.Frame.GoBack();
            }
        }

        private void Cijferlijstpressed_PointerPressed(Object sender, TappedRoutedEventArgs e)
        {
            RelativePanel panel = (sender as TextBlock).Parent as RelativePanel;
            
            if (panel != null)
            {
                ListView periodesListView = panel.FindName("periodesListView") as ListView;

                if (periodesListView != null)
                {
                    if (periodesListView.Visibility == Visibility.Collapsed)
                        periodesListView.Visibility = Visibility.Visible;
                    else
                        periodesListView.Visibility = Visibility.Collapsed;
                    

                }
                
            }
        }

        private void Periodepressed_PointerPressed(Object sender, TappedRoutedEventArgs e)
        {
            
            RelativePanel panel = (sender as TextBlock).Parent as RelativePanel;
            
            if (panel != null)
            {
                ListView periodesListView = panel.FindName("cijferTakenListView") as ListView;

                if (periodesListView != null)
                {
                    if (periodesListView.Visibility == Visibility.Collapsed)
                        periodesListView.Visibility = Visibility.Visible;
                    else
                        periodesListView.Visibility = Visibility.Collapsed;

                    

                }
                
            }
        }

        private void Vak_PointerPressed(Object sender, TappedRoutedEventArgs e)
        {
            RelativePanel panel = (sender as TextBlock).Parent as RelativePanel;
            
            if (panel != null)
            {
                ListView periodesListView = panel.FindName("attemptsListView") as ListView;

                if (periodesListView != null)
                {
                    if (periodesListView.Visibility == Visibility.Collapsed)
                        periodesListView.Visibility = Visibility.Visible;
                    else
                        periodesListView.Visibility = Visibility.Collapsed;

                }
            }
        }

        private void Grid_DoubleTapped(Object sender, DoubleTappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ActivitiesPage), plan);
        }
        
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            plan.clear(Plan.Clear_Options.ALL);
        }

        private void removeCijferLijstButton_Click(object sender, RoutedEventArgs e)
        {
            plan.plan.CijferLijsten.Remove((sender as Button).Tag as CijferLijst);
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AddCijferLijstPage), plan);
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
                    this.Frame.Navigate(typeof(ReflectionsPage), plan);
            }
        }
    }
}
