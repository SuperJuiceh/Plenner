using DataLab.Server.Packets;
using DataLab.Data.Users;
using Planner.Data;
using Planner.Data.Converters;
using DataLab.Storage;
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
using DataLab.Tools;
using static DataLab.Data.Users.UserManager;
using System.Collections.ObjectModel;
using DataLab.NetworkPackaging;
using Datalab.Server.Packets;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Planner
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class RegistrationPage : Page
    {
        public PlanningItemStorage plan { get; set; }

        public RegistrationPage()
        {
            this.InitializeComponent();
            this.initCountriesInList();
        }
        
        private async void check_username_availability_button_Click(object sender, RoutedEventArgs e)
        {
            if (!PacketClient.Connected)
                await PacketClient.Connect();

            if (username_textBox.Text != "")
            {
                QuestionPacket qpacket = QuestionPacket.IsUserNameAvailable(username_textBox.Text);
                PacketClient.sendPacket(qpacket);
                QuestionPacket packet = PacketClient.receivePacket() as QuestionPacket;

                if (packet.A)
                {
                    username_textBox.Background = new SolidColorBrush(Colors.LawnGreen);
                }
                else {
                    username_textBox.Background = new SolidColorBrush(Colors.IndianRed);
                }

            }
        }

        private void create_button_Click(object sender, RoutedEventArgs e)
        {
            if (username_textBox.Text != "" && password_textBox.Text != "" && fname_textbox.Text != "" && fname_textbox.Text != "" &&
                DateTime.Now > ClassConverters.DateTimeOffsetToDateTime(birthdate_picker.Date))
            {
                try
                {
                    User createdUser = new User(username_textBox.Text, PasswordHasher.hashPassword(password_textBox.Text), fname_textbox.Text, lname_textbox.Text, ClassConverters.DateTimeOffsetToDateTime(birthdate_picker.Date), (string)selected_country_listbox.SelectedItem);
                    //Debug.WriteLine("Found "+ new string(current_hobbies_textbox.Text.ToCharArray().Where(c => !c.Equals(' ')).ToArray()).Split(','));
                    createdUser.UserInfo.Hobbies = new ObservableCollection<string>(new string(current_hobbies_textbox.Text.ToCharArray().Where(c => !c.Equals(' ')).ToArray()).Split(',').ToList());

                    // Packet to send
                    QuestionPacket qpacket = QuestionPacket.TryRegistration(createdUser);
                    PacketClient.sendPacket(qpacket);
                    QuestionPacket packet = PacketClient.receivePacket() as QuestionPacket;
                    
                    if (packet.A)
                    {
                        // We created a new, yay!
                        this.Frame.Navigate(typeof(UserPage), new DynamicPlanningItemStorage(plan, createdUser));
                    }
                    else
                    {
                        registrationResultTextBox.Text = ((Registration_Answer)packet.Question_data[1]).ToString();
                    }
                }
                catch (NullReferenceException ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            } else
            {
                registrationResultTextBox.Text = "Is all required(*) Info filled in?";
            }
        }


        private void Grid_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(UserPage));
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            PlanningItemStorage planning = e.Parameter as PlanningItemStorage;

            if (planning != null)
            {
                plan = planning;
            }
        }
        
        private void initCountriesInList()
        {
            string[] listOfCountries = new string[] { "Germany", "Netherlands", "USA" };

            listOfCountries.ToList().ForEach(s => selected_country_listbox.Items.Add(s));
        }

        private void add_hobby_button_Click(object sender, RoutedEventArgs e)
        {
            
            if (newHobbyTextBox.Text != "")
            {
                if (current_hobbies_textbox.Text == "")
                {
                    current_hobbies_textbox.Text = newHobbyTextBox.Text;
                }
                else {
                    current_hobbies_textbox.Text += ", " + newHobbyTextBox.Text;
                }
            }

            newHobbyTextBox.Text = "";
        }
    }
}
