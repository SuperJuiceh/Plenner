using DataLab.Data.Planning;
using DataLab.Storage;
using DataLab.Tools;
using Planner.Data;
using Planner.Data.Styling;
using Planner.Data.Tools.TimeFlow;
using Planner.Data.Tools.GUI;
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
using Newtonsoft.Json.Serialization;
using Windows.Data.Json;
using Newtonsoft.Json;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace Planner
{
    public sealed partial class TimeFlowPage : Page
    {

        public PlanningItemStorage Planning { get { return GeneralApplicationData.Planning; } set { GeneralApplicationData.Planning = value; } }

        public SettingsStorage Settings { get { return GeneralApplicationData.Settings; } set { GeneralApplicationData.Settings = value; } }



        public TimeFlowPage()
        {
            UserStyleFactory.addStyles(this.Resources, this.Settings.Settings);
            
            this.InitializeComponent();

               
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            
        }
    }
}
