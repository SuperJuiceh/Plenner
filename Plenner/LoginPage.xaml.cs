using Datalab.Server.Packets;
using DataLab.Data.Users;
using Plenner.Data;
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
using DataLab.Tools;

using DataLab.NetworkPackaging;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Plenner
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoginPage : Page
    {

        

        public PlanningItemStorage plan { get; set; }
        
        public LoginPage()
        {
            this.InitializeComponent();
        }

        private void login_button_Click(object sender, RoutedEventArgs e)
        {
            if (username_textBox.Text != "" && password_textBox.Text != "")
            {
                // Try login
                QuestionPacket qPacket = QuestionPacket.AskIfPasswordIsValid(username_textBox.Text, PasswordHasher.hashPassword(password_textBox.Text));
                QuestionPacket packet = PacketClient.SendAndReceive(qPacket) as QuestionPacket;

                if (packet.A)
                {
                    DynamicPlanningItemStorage p = new DynamicPlanningItemStorage(plan, (User)packet.Question_data[2]);
                    plan.plan = p.CurrentUser.plan;
                    this.Frame.Navigate(typeof(UserPage), plan);
                }
            }
        }

        private void Grid_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(UserPage));
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            PlanningItemStorage item = e.Parameter as PlanningItemStorage;

            if (item != null)
            {
                plan = item;

            }

        }
    }
}
