using DataLab.Data.Cijfers;
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
    public sealed partial class AddCijferLijstPage : Page
    {

        // Used for building class in partials (build as one on finish)
        public ObservableCollection<CijferPeriode> CreatedPeriodes { get; set; }

        private DateTime? _startDate, _endDate;

        public PlanningItemStorage Plan { get; set; }


        public AddCijferLijstPage()
        {
            CreatedPeriodes = new ObservableCollection<CijferPeriode>();
            CreatedPeriodes.Add(new CijferPeriode("lol", DateTime.Now, DateTime.Now));
            this.InitializeComponent();
        }

        private void startRadioButton_Click(Object sender, RoutedEventArgs e)
        {
            startRadioButton.ContextFlyout.ShowAt(startRadioButton);
        }

        private void endRadioButton_Click(Object sender, RoutedEventArgs e)
        {
            endRadioButton.ContextFlyout.ShowAt(endRadioButton);
        }
                
        private void startRadioButtonFlyout_Closed(Object sender, Object e)
        {
            DateTime dt = new DateTime(startdatePicker.Date.Year, startdatePicker.Date.Month, startdatePicker.Date.Day, starttimePicker.Time.Hours, starttimePicker.Time.Minutes, starttimePicker.Time.Seconds);

            if (_endDate != null && dt > DateTime.Now && dt < _endDate || _endDate == null && dt > DateTime.Now)
            {
                startRadioButton.IsChecked = true;
                _startDate = dt;
            } else
            {
                startRadioButton.IsChecked = false;
                _startDate = null;
            }

        }

        private void endRadioButtonFlyout_Closed(Object sender, Object e)
        {
            DateTime dt = new DateTime(enddatePicker.Date.Year, enddatePicker.Date.Month, enddatePicker.Date.Day, endtimePicker.Time.Hours, endtimePicker.Time.Minutes, endtimePicker.Time.Seconds);

            if (dt > DateTime.Now && _startDate != null && dt > _startDate)
            {
                endRadioButton.IsChecked = true;
                _endDate = dt;
            }
            else
            {
                Debug.WriteLine("end radio, false");
                endRadioButton.IsChecked = false;
                _endDate = null;
            }

        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            // Create Periode from GUI input
            if (startRadioButton.IsChecked.GetValueOrDefault() && endRadioButton.IsChecked.GetValueOrDefault())
            {
                CijferPeriode tempPeriode = new CijferPeriode(newPeriodeTitleTextBox.Text,
                                                AddCijferLijstPage.PickersToDateTime(startdatePicker, starttimePicker),
                                                AddCijferLijstPage.PickersToDateTime(enddatePicker, endtimePicker));

                CreatedPeriodes.Add(tempPeriode);

                newPeriodeTitleTextBox.Text = "";
                


            }
        }

        private void deletePeriodeButton_Click(object sender, RoutedEventArgs e)
        {
            // Get element
            CijferPeriode periode = (sender as Button).Tag as CijferPeriode;

            if (periode != null)
            {
                CreatedPeriodes.Remove(periode);
            }
            
        }
        

        private void createPeriodButton_Click(object sender, RoutedEventArgs e)
        {
            // Create CijferLijst
            if (newCijferLijstName.Text != null && CreatedPeriodes.Count > 0)
            {
                CijferLijst lijst = new CijferLijst(newCijferLijstName.Text, CreatedPeriodes.ToArray());

                // Navigate to configure the periods
                this.Frame.Navigate(typeof(AddCijferPeriodePage), new Tuple<PlanningItemStorage, CijferLijst>(Plan, lijst));
                
            }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            PlanningItemStorage storage = e.Parameter as PlanningItemStorage;

            if (storage != null)
            {
                Plan = storage;
            }
        }

        private static DateTime PickersToDateTime(DatePicker dPicker, TimePicker tPicker)
        {
            return new DateTime(dPicker.Date.Year, dPicker.Date.Month, dPicker.Date.Day, tPicker.Time.Hours, tPicker.Time.Minutes, tPicker.Time.Seconds);
        }
    }
}
