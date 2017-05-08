using DataLab.Storage;
using DataLab.Data.Users.Message;
using DataLab.Server.Packets;
using Plenner.Data;
using System;
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
using DataLab.NetworkPackaging;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Plenner
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SendMailPage : Page
    {

        public DynamicPlanningItemStorage plan { get; set; }

        public SendMailPage()
        {
            this.InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void send_mail_button_Click(object sender, RoutedEventArgs e)
        {
            if (recepients_textbox.Text != "" && message_text_box.Text != "")
            {
                MessagePacket mPacket = new MessagePacket(new Mail(plan.CurrentUser.UserName, new List<string>() { recepients_textbox.Text }, message_text_box.Text));
                PacketClient.sendPacket(mPacket);

                this.Frame.Navigate(typeof(MailPage), plan);
            }
        }

        private void Grid_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MailPage));
        }
    }
}
