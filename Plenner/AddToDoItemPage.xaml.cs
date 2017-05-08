using Plenner.Data.Converters;
using Plenner.Data.Notify;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Plenner
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AddToDoItemPage : Page
    {


        public PlanningItemStorage plan { get; set; }

        public bool MultipleItems { get; set; }

        public ToDoItem CurrentTdi { get; set; }

        public AddToDoItemPage()
        {
            this.InitializeComponent();

            this.Loaded += AddToDoItemPage_Loaded;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            
            Tuple<PlanningItemStorage, string> tup = e.Parameter as Tuple<PlanningItemStorage, string>;
            if (tup != null)
            {
                plan = tup.Item1 as PlanningItemStorage;

                if (tup.Item2 == "single")
                {
                    MultipleItems = false;
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
                        plan.addPlanningItem(tdItem);
                        this.Frame.Navigate(typeof(ToDoPage), plan);
                    }
                    else {
                        ToDoItemSet curtdi = CurrentTdi as ToDoItemSet;
                        curtdi.Children.Add(tdItem);

                        ToastNotifier.setuptoasts(plan.plan);

                        this.Frame.Navigate(typeof(AddToDoSetPage), new Tuple<PlanningItemStorage, ToDoItemSet>(plan, curtdi));

                    }

                }
            }
            else {
                tdItem = new ToDoItem(textBoxName.Text, textBoxDescription.Text);

                if (!MultipleItems)
                {
                    plan.addPlanningItem(tdItem);
                    this.Frame.Navigate(typeof(ToDoPage), plan);
                }
                else {
                    ToDoItemSet curtdi = CurrentTdi as ToDoItemSet;
                    curtdi.Children.Add(tdItem);
                    this.Frame.Navigate(typeof(AddToDoSetPage), new Tuple<PlanningItemStorage, ToDoItemSet>(plan, curtdi));
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
