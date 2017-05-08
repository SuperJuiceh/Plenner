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
using System.Collections.ObjectModel;
using System.ComponentModel;
using Planner.Data.Styling;
using Planner.Data;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Planner
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ToDoPage : Page
    {

        private Point manipulationStartingPoint;

        public PlanningItemStorage  Planning { get; private set; }
        public SettingsStorage      Settings { get; private set; }

        public bool nameSortAscending, timeSortAscending;

        public ToDoPage()
        {
            Planning = GeneralApplicationData.Planning;
            Settings = GeneralApplicationData.Settings;

            UserStyleFactory.addStyles(this.Resources, this.Settings.Settings);

            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            
        }

        private void Grid_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Planning.clear(Plan.Clear_Options.TODO);
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
                    this.Frame.Navigate(typeof(ReflectionsPage));
                else
                    this.Frame.Navigate(typeof(ActivitiesPage));
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AddToDoItemPage));
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.Planning.clear(Plan.Clear_Options.TODO);
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            this.Planning.saveStorage();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ToDoItem tdi = (sender as Button).DataContext as ToDoItem;
            
            if (tdi != null)
            {
                if (Planning.plan.ToDoItems.Contains(tdi))
                    Planning.removePlanningItem(tdi);
                else
                    Planning.plan.tdiSets.ToList().ForEach(tds =>
                    {
                        if (tds.Children.Contains(tdi))
                            tds.Children.Remove(tdi);
                    });
            }
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox lb = sender as ListBox;

            if (lb != null)
            {
                ListBoxItem lbi = lb.SelectedItem as ListBoxItem;
                
                if (lbi != null)
                {
                    if ((string)lbi.Content == "Single")
                    {
                        this.Frame.Navigate(typeof(AddToDoItemPage), "single");
                    }
                    else if ((string)lbi.Content == "Set")
                    {
                        this.Frame.Navigate(typeof(AddToDoItemPage), "set");
                    }
                }
            }

        }

        private void tdiset_remove_button_Click(object sender, RoutedEventArgs e)
        {
            ToDoItemSet set = (sender as Button).DataContext as ToDoItemSet;

            if (set != null)
            {
                Planning.removePlanningItem(set);
            }
        }

        private void toDoItemNameHeaderTextBlock_Tapped(object sender, TappedRoutedEventArgs e)
        {
            // Orderedlist placeholder
            IOrderedEnumerable<ToDoItem> ok;
            // How will we sort the data? (Asc/Desc)
            if (nameSortAscending)
                ok = Planning.plan.ToDoItems.OrderBy(item => item.Name);
            else
                ok = Planning.plan.ToDoItems.OrderByDescending(item => item.Name);

            // Flip state
            nameSortAscending = !nameSortAscending;

            List<ToDoItem> items = ok.ToList();

            if (ok.Count() > 0)
            {
                Planning.plan.ToDoItems.Clear();
                // Add all items from the list
                items.ForEach(item =>
                {
                    Planning.plan.ToDoItems.Add(item);
                });
            }

            timeSortAscending = false;
        }

        private void toDoItemTimeHeaderTextBlock_Tapped(object sender, TappedRoutedEventArgs e)
        {
            // Orderedlist placeholder
            IOrderedEnumerable<ToDoItem> ok;
            // How will we sort the data? (Asc/Desc)
            if (timeSortAscending)
                ok = Planning.plan.ToDoItems.OrderBy(item => item.Deadline);
            else
                ok = Planning.plan.ToDoItems.OrderByDescending(item => item.Deadline);

            // Flip state
            timeSortAscending = !timeSortAscending;

            List<ToDoItem> items = ok.ToList();

            if (ok.Count() > 0)
            {
                Planning.plan.ToDoItems.Clear();
                // Add all items from the list
                items.ForEach(item =>
                {
                    Planning.plan.ToDoItems.Add(item);
                });
            }

            nameSortAscending = false;
        }
    }
}
