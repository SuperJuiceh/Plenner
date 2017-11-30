using DataLab.Data.Planning;
using DataLab.Storage;
using Planner.Data;
using Planner.Data.Tools.GUI;
using Planner.Data.Tools.TimeFlow;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace Planner.Modules
{
    public sealed partial class TimeFlowPanel : UserControl
    {

        public PlanningItemStorage Planning { get { return GeneralApplicationData.Planning; } set { GeneralApplicationData.Planning = value; } }

        public SettingsStorage Settings { get { return GeneralApplicationData.Settings; } set { GeneralApplicationData.Settings = value; } }

        public double MainPanelWidth { get { return MainPanel.Width; } set { MainPanel.Width = value; } }
        public double MainPanelHeight { get { return MainPanel.Height; } set { MainPanel.Height = value; } }

        public Plan PanelPlanning { get; set; }

        private int[] NumbersTo24Array = Enumerable.Range(0, 24).ToArray();

        public TimeFlow MainTimeFlow { get; set; }

        public enum PanelMode { AllItems, SetItems }
        public PanelMode CurrentMode { get; set; }


        public TimeFlowPanel()
        {
            this.InitComponents();
        }

        public void InitComponents()
        {
            this.InitializeComponent();

            MainPanelWidth = DeviceResolution.GetDeviceResolution().Width - 50; // Take 50 pixels space due to navigation pane
            MainPanelWidth = DeviceResolution.GetDeviceResolution().Height;

            TextBlock block = null;

            NumbersTo24Array.ToList().ForEach(num => {
                double a = MainPanelWidth / 24.0;
                numbersTableHeaderPanel.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(a) });

                block = new TextBlock() { Width = a, Text = num.ToString(), Height = 420.0 };
                
                Border border = new Border() { Width = a, Height = 420.0 };
                border.Background = new SolidColorBrush(Colors.White);
                border.Background.Opacity = 0.5;
                border.BorderThickness = new Thickness(1, 1, 1, 1);
                border.SetValue(Grid.ColumnProperty, num);

                border.Child = block;
                
                numbersTableHeaderPanel.Children.Add(border);
            });

            SetTimeFlowPanel();

        }

        public void SetTimeFlowPanel()
        {
            switch (CurrentMode)
            {
                case PanelMode.AllItems:
                    Planning = PlanningItemStorage.GetConcreteStorage();
                    //Planning.plan.clear(Plan.Clear_Options.ALL);
                    MainTimeFlow = new TimeFlow(DateTime.Now, this.Planning.plan, TimeFlowConstraints.AllowAll());
                    break;
                case PanelMode.SetItems:
                    MainTimeFlow = new TimeFlow(DateTime.Now, PanelPlanning, TimeFlowConstraints.AllowAll());
                    break;
            }                
            
        }

        private void setPickerDate()
        {
            if (MainTimeFlow == null || timeFlowDatePicker.Date == null)
            {
                DateTime now = DateTime.Now;

                MainTimeFlow = new TimeFlow(true, true , true , timeFlowDatePicker.Date.Date, PanelPlanning, TimeFlowConstraints.AllowAll());
            }
            else
            {
                MainTimeFlow.FilterDate = timeFlowDatePicker.Date.Date;
                MainTimeFlow.configLists();
            }

            this.UpdateLayout();
            //timeLineActivitiesItemsControl.UpdateLayout();
        }

        private void timeFlowDatePicker_DateChanged(object sender, DatePickerValueChangedEventArgs e)
        {
            if (MainTimeFlow != null)
                MainTimeFlow.FilterDate = e.NewDate.Date;

            setPickerDate();
            
        }

        private void configFlyoutOpenButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
