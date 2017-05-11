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
using DataLab.Data.Planning;
using Planner.Data.Converters;
using Planner.Data.Notify;
using Planner;
using Planner.Data;
using Planner.Data.Styling;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Planner
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AddToDoItemPage : Page
    {
        
        public PlanningItemStorage Planning { get; set; }
        public SettingsStorage Settings { get; set; }

        public bool MultipleItems { get; set; }

        public ToDoItem CurrentTdi { get; set; }

        public AddToDoItemPage()
        {

            Planning = GeneralApplicationData.Planning;
            Settings = GeneralApplicationData.Settings;

            UserStyleFactory.addStyles(this.Resources, this.Settings.Settings);

            this.InitializeComponent();

            this.Loaded += AddToDoItemPage_Loaded;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            
            string s = e.Parameter as string;
            if (s != null)
            {
                if (s == "single")
                {
                    MultipleItems = false;
                    button1.Visibility = Visibility.Collapsed;
                }
                else {
                    MultipleItems = true;
                    CurrentTdi = new ToDoItemSet("", "");
                }
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            
            ToDoItem tdItem;

            DateTime dt = new DateTime(datePicker.Date.Year, datePicker.Date.Month, datePicker.Date.Day,
                                       timePicker.Time.Hours, timePicker.Time.Minutes, timePicker.Time.Seconds);


            if (deadLineCheckbox.IsChecked.GetValueOrDefault())
            {
                if (DateTime.Now < dt)
                {
                    tdItem = new ToDoItem(textBoxName.Text, textBoxDescription.Text);

                    if (deadLineCheckbox.IsChecked.GetValueOrDefault())
                    {
                        tdItem.Deadline = ClassConverters.DateAndTimeToDateTime(datePicker.Date, timePicker.Time);
                    }

                    if (!MultipleItems)
                    {
                        Planning.addPlanningItem(tdItem);
                        this.Frame.Navigate(typeof(ToDoPage));
                    }
                    else {
                        ToDoItemSet curtdi = CurrentTdi as ToDoItemSet;
                        curtdi.Children.Add(tdItem);

                        ToastNotifier.setuptoasts(Planning.plan);

                        this.Frame.Navigate(typeof(AddToDoSetPage), new Tuple<PlanningItemStorage, ToDoItemSet>(Planning, curtdi));

                    }

                }
            }
            else {
                tdItem = new ToDoItem(textBoxName.Text, textBoxDescription.Text);

                if (!MultipleItems)
                {
                    Planning.addPlanningItem(tdItem);
                    this.Frame.Navigate(typeof(ToDoPage));
                }
                else {
                    ToDoItemSet curtdi = CurrentTdi as ToDoItemSet;
                    curtdi.Children.Add(tdItem);
                    this.Frame.Navigate(typeof(AddToDoSetPage), curtdi);
                }

                
            }


        }

        private void clearInputs()
        {
            textBoxName.Text = "";
            textBoxDescription.Text = "";
        }


        private void Grid_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ToDoPage));
        }

        // Repeat adding item to list
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ToDoItem tdItem;

            DateTime dt = new DateTime(datePicker.Date.Year, datePicker.Date.Month, datePicker.Date.Day,
                                       timePicker.Time.Hours, timePicker.Time.Minutes, timePicker.Time.Seconds);
            
            if (deadLineCheckbox.IsChecked.GetValueOrDefault())
            {
                if (DateTime.Now < dt)
                {
                    tdItem = new ToDoItem(textBoxName.Text, textBoxDescription.Text);
                    ToDoItemSet set = CurrentTdi as ToDoItemSet;
                    if (set != null)
                    {
                        set.Children.Add(tdItem);
                    }


                    clearInputs();
                }
            }
            else {
                tdItem = new ToDoItem(textBoxName.Text, textBoxDescription.Text);

                ToDoItemSet set = CurrentTdi as ToDoItemSet;
                if (set != null)
                {
                    set.Children.Add(tdItem);
                }

                clearInputs();
            }
        }


        private void AddToDoItemPage_Loaded(Object sender, RoutedEventArgs e)
        {
            for (int a = 1; a < 120; a++)
                notifyMinutesBeforeListBox.Items.Add(a);
        }


    }
}
