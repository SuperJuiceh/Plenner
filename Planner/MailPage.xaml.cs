using DataLab.Storage;
using DataLab.Data.Users.Message;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Planner
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MailPage : Page
    {

        public DynamicPlanningItemStorage plan { get; set; }

        public MailPage()
        {
            this.InitializeComponent();

            //    
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            DynamicPlanningItemStorage p = e.Parameter as DynamicPlanningItemStorage;

            if (p != null)
            {
                Debug.WriteLine("Mails: "+ p.CurrentUser.Mails.Count());
                plan = p;
            }
        }

        private void Grid_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(UserPage), plan);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            // Go to mail send page
            this.Frame.Navigate(typeof(SendMailPage));
        }

        private void delete_mail_button_Click(object sender, RoutedEventArgs e)
        {
            Mail mail = sender as Mail;

            if (mail != null)
            {
                // Remove mail from list
                plan.CurrentUser.plan.Mails.Remove(mail);

                // Remove mail package?
            }
        }
    }
}
