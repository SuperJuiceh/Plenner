using DataLab.Storage;
using DataLab.Server.Packets;
using Planner.Data;
using DataLab.NetworkPackaging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using Datalab.Server.Packets;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Planner
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class FriendsPage : Page, INotifyPropertyChanged
    {

        public DynamicPlanningItemStorage plan { get; set; }

        public string Filter { get { return username_text_box.Text; } }

        public FriendsPage()
        {
            this.InitializeComponent();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            DynamicPlanningItemStorage storage = e.Parameter as DynamicPlanningItemStorage;

            if (storage != null)
            {

                plan = storage;

            } else
            {
                this.Frame.GoBack();
            }
        }

        private void username_text_box_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Does the user exist?
            Changed("Filter");

            if (!plan.CurrentUser.Friends.Contains(username_text_box.Text))
            {
                add_friend_button.Visibility = Visibility.Visible;
            }
            else
            {
                add_friend_button.Visibility = Visibility.Collapsed;
            }
        }

        private void add_friend_button_Click(object sender, RoutedEventArgs e)
        {
            if (username_text_box.Text != "" && username_text_box.Text != "Search for friends..." && !plan.CurrentUser.Friends.Contains(username_text_box.Text))
            {
                // Does the user exist?
                QuestionPacket qPack = QuestionPacket.IsUserNameAvailable(username_text_box.Text);
                qPack.A = true;

                QuestionPacket packet = PacketClient.SendAndReceive(qPack) as QuestionPacket;

                if (!packet.A)
                {
                    plan.CurrentUser.Friends.Add(username_text_box.Text);
                    Debug.WriteLine("Found Exists! "+ username_text_box.Text);
                }
            }

            // Sync user
            Tuple<bool, DynamicPlanningItemStorage> content = PacketClientLibrary.SyncUser(plan);
            if (content.Item1)
            {
                plan = content.Item2;
                Debug.WriteLine("Synced user after adding friend");
            }

        }

        private void Grid_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(UserPage), plan);
            

        }

        private void Changed(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private void addPermissionsToFriend_Tapped(object sender, TappedRoutedEventArgs e)
        {
            string username = (sender as TextBlock).Text;

            if (username != null)
            {
                this.Frame.Navigate(typeof(GrantPermissionsPage), new Tuple<PlanningItemStorage, string>(plan, username));
            }

        }
    }
}
