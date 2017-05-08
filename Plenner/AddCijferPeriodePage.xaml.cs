using DataLab.Data.Cijfers;
using DataLab.Data.Cijfers.CijferTaak;
using DataLab.Storage;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public sealed partial class AddCijferPeriodePage : Page
    {

        public PlanningItemStorage Plan { get; set; }

        public CijferLijst CijfLijst { get; set; }

        public CijferPeriode Periode { get; set; }

        private Queue<CijferPeriode> PeriodesLeft { get; set; } = new Queue<CijferPeriode>();

        public AddCijferPeriodePage()
        {
            this.InitializeComponent();

            int[] numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            numbers.ToList().ForEach(number => teBehalenComboBoxMin.Items.Add(number));
            numbers.ToList().ForEach(number => teBehalenComboBoxMax.Items.Add(number));
            
        }

        private void processCijferTakenInPeriode()
        {
            if (Periode != null)
            {
                // Remove and re-add periode
                CijfLijst.Periodes.Remove(Periode);
                CijfLijst.Periodes.Add(Periode);
            }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Tuple<PlanningItemStorage, CijferLijst> storage = e.Parameter as Tuple<PlanningItemStorage, CijferLijst>;

            if (storage != null)
            {

                arrowRightButton.Visibility = Visibility.Visible;
                createPeriodButton.Visibility = Visibility.Collapsed;

                Plan = storage.Item1;
                CijfLijst = storage.Item2;
                CijfLijst.Periodes.ForEach(periode => PeriodesLeft.Enqueue(periode));

                if (storage.Item1.plan.CijferLijsten != null)
                    Debug.WriteLine("Storage niet is null");


                setNewQueueAsCurrentPeriode();
            }

        }

        private void setNewQueueAsCurrentPeriode()
        {
            processCijferTakenInPeriode();
            
            // Nieuwe periode verkrijgen uit queue
            CijferPeriode periode = PeriodesLeft.Dequeue();
            Periode = periode;
            // GUI aanpassingen op basis van nieuwe informatie
            listView.ItemsSource = Periode.ToComplete;
            vakNameTextBox.Text = Periode.Name;

            if (PeriodesLeft.Count == 0)
            {
                // No more periodes to set, lets wrap this up
                // Edit gui elements        
                arrowRightButton.Visibility = Visibility.Collapsed;
                createPeriodButton.Visibility = Visibility.Visible;
            }
        }

        private void createPeriodButton_Click(object sender, RoutedEventArgs e)
        {
            // We are done, add to Planning and go back to CijfersPage
            Plan.plan.CijferLijsten.Add(CijfLijst);
            this.Frame.Navigate(typeof(CijfersPage), Plan);
        }

        private void addVakButton_Click(object sender, RoutedEventArgs e)
        {
            // Create Vak 
            if (vakNameTextBox.Text != "" && teBehalenComboBoxMin.SelectedItem != null && teBehalenComboBoxMax.SelectedItem != null)
            {
                Cijfertaak taak = new Cijfertaak(vakNameTextBox.Text, (int)teBehalenComboBoxMin.SelectedItem, (int)teBehalenComboBoxMax.SelectedItem);
                Periode.ToComplete.Add(taak);

                vakNameTextBox.Text = "";

                
            }
        }

        private void vakDeleteButton_Click(object sender, RoutedEventArgs e)
        {
            Cijfertaak selectedTaak = (sender as Button).Tag as Cijfertaak;

            if (selectedTaak != null)
            {
                Periode.ToComplete.Remove(selectedTaak);
            }
        }

        private void arrowRightButton_Click(object sender, RoutedEventArgs e)
        {
            setNewQueueAsCurrentPeriode();
        }
    }
}
