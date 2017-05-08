using DataLab.Storage;
using DataLab.Server.Packets;
using DataLab.Data.Users;
using Planner.Data;
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
using DataLab.NetworkPackaging;
using Datalab.Server.Packets;
using Planner.Data.Styling;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Planner
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class UserPage : Page
    {

        public DynamicPlanningItemStorage plan { get; set; }
        public SettingsStorage Settings { get; set; }

        public UserPage()
        {
            plan = GeneralApplicationData.DynamicPlanning;
            Settings = GeneralApplicationData.Settings;

            UserStyleFactory.addStyles(this.Resources, this.Settings.Settings);

            this.InitializeComponent();
        }

        private void sync_button_Click(object sender, RoutedEventArgs e)
        {
            plan.CurrentUser.plan = plan.plan;
            // Create packet
            QuestionPacket qpack = QuestionPacket.SyncUserData(plan.CurrentUser);
            // Send packet
            PacketClient.sendPacket(qpack);
            QuestionPacket packet = PacketClient.receivePacket() as QuestionPacket;
            if (qpack.A)
            {
                // Get content
                User user = (User)qpack.Question_data[0];
                plan.plan = user.plan;
                plan.CurrentUser = user;
            }
            // Sync data
        }

        private void Grid_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SettingsPage));
        }


        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            DynamicPlanningItemStorage planning = e.Parameter as DynamicPlanningItemStorage;

            if (planning != null)
            {
                this.plan = planning;
            } else
            {
                this.Frame.GoBack();
            }

        }

        private void user_button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(LoginPage));
        }

        private void registration_button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(RegistrationPage));
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MailPage));
        }

        private void show_friends_button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(FriendsPage));
        }

        private void sync_button_Click_1(object sender, RoutedEventArgs e)
        {
            //plan.CurrentUser.plan = plan.plan;
            //// Send packet
            Tuple<bool, DynamicPlanningItemStorage> content = PacketClientLibrary.SyncUser(plan);
            if (content.Item1)
            {
                plan = content.Item2;
                Debug.WriteLine("I now have {0} friends and {1} is my name", plan.CurrentUser.Friends.Count, plan.CurrentUser.UserInfo.FullName);
            }

        }
    }
}
