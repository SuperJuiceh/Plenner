using DataLab.Data.Planning;
using DataLab.Storage;
using DataLab.Tools;
using Planner.Data;
using Planner.Data.Styling;
using Planner.Data.TimeFlowTools;
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

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace Planner
{
    public sealed partial class TimeFlowPage : Page
    {
        public PlanningItemStorage Planning { get { return GeneralApplicationData.Planning; } set { GeneralApplicationData.Planning = value; } }

        public SettingsStorage Settings { get { return GeneralApplicationData.Settings; } set { GeneralApplicationData.Settings = value; } }

        private List<PlanningItem> items;

        private int[] NumbersTo24Array { get { return Enumerable.Range(0, 24).ToArray(); } }

        public TimeFlow MainTimeFlow { get; set; }

        public TimeFlowPage()
        {
            UserStyleFactory.addStyles(this.Resources, this.Settings.Settings);
            
            this.InitializeComponent();

            setPickerDate();


        }

        private void setPickerDate()
        {

            if (MainTimeFlow == null || timeFlowDatePicker.Date == null)
            {
                DateTime now = DateTime.Now;
                MainTimeFlow = new TimeFlow(true, true, true, DateTime.Now, Planning.plan.AllItems.Where(item => item.Start != null && item.Start.IsSameDay(now)).ToList());
            }
            else
            {
                MainTimeFlow.configLists(Planning.plan.AllItems.Where(item => item.Start.IsSameDay(timeFlowDatePicker.Date)).ToList());
            }

            Debug.WriteLine(MainTimeFlow.TimeLineActivities.Count().ToString());

            this.UpdateLayout();
            timeLineActivitiesItemsControl.UpdateLayout();
        }

        private void timeFlowDatePicker_DateChanged(object sender, DatePickerValueChangedEventArgs e)
        {
            if (!e.OldDate.Date.IsSameDay(e.NewDate))
                MainTimeFlow.FilterDate = e.NewDate.Date;

            setPickerDate();

        }
    }
}
