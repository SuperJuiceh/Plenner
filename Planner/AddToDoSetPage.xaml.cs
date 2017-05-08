﻿using System;
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

using System.ComponentModel;
using System.Diagnostics;
using DataLab.Data.Planning;
using DataLab.Storage;
using Planner.Data.Styling;
using Planner.Data;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Planner
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AddToDoSetPage : Page, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public PlanningItemStorage plan { get; set; }
        public SettingsStorage Settings { get; set; }

        public ToDoItemSet tdiSet { get; set; }

        public AddToDoSetPage()
        {

            plan = GeneralApplicationData.Planning;
            Settings = GeneralApplicationData.Settings;

            UserStyleFactory.addStyles(this.Resources, this.Settings.Settings);

            this.InitializeComponent();
        }

        private void confirm_button_Click(object sender, RoutedEventArgs e)
        {
            tdiSet.Name = nameTextBox.Text;

            plan.addPlanningItem(tdiSet);

            this.Frame.Navigate(typeof(ToDoPage));

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            ToDoItemSet tp = e.Parameter as ToDoItemSet;

            if (tp != null)
            {
                tdiSet = tp;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ToDoItem tdi = (sender as Button).DataContext as ToDoItem;

            if (tdi != null)
            {
                tdiSet.Children.Remove(tdi);

                // All items removed, go back a page
                if (tdiSet.Children.Count == 0)
                    this.Frame.Navigate(typeof(ToDoPage));
            }
        }

        public void Changed(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        private void delete_button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ToDoPage));
        }
    }
}
