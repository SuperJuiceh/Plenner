using DataLab.Server.Controller;
using DataLab.Server.Controller.Logging;
using DataLab.Tools;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PlennerServerConsole
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Console : Page
    {

        public PacketServer Server { get; set; } = new PacketServer();

        public Console()
        {
            this.InitializeComponent();
            
            Server.Storage.ServerData.Log.clearLogs(DataLab.Server.Controller.Logging.ServerLog.LogClearingOptions.CLEAR_AND_STORE);

        }
        
        private void send_command_button_Click(object sender, RoutedEventArgs e)
        {
            sendCommand();
        }

        private void sendCommand()
        {
            string message = commandTextBox.Text;

            if (message != "")
            {
                handleCommandString(message);
                commandTextBox.Text = "";
            }
        }

        private void commandTextBox_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter)
            {
                sendCommand();
            }
        }

        private void handleCommandString(string command)
        {

            string[] splitCommand = command.Split(' ');

            if (splitCommand[0] == "Start" || splitCommand[0] == "start")
            {
                startServer();
            }
            else if (splitCommand[0] == "Stop" || splitCommand[0] == "stop")
            {
                stopServer();

            }
            else if (splitCommand[0] == "Pause" || splitCommand[0] == "pause")
            {
                pauseServer();
            }
            else if (splitCommand[0] == "Save" || splitCommand[0] == "save")
            {
                Server.Storage.saveStorage();
            }
            else if (splitCommand[0] == "Clear" || splitCommand[0] == "clear")
            {
                Server.Storage.ServerData.Log.clearLogs(DataLab.Server.Controller.Logging.ServerLog.LogClearingOptions.CLEAR_CURRENT);
            }
            else if (splitCommand[0] == "Help" || splitCommand[0] == "help" || splitCommand[0] == "?" || splitCommand[0] == "/?")
            {
                Server.Storage.ServerData.Log.addLog(HelpString, DataLab.Server.Controller.Logging.Log.LogTypes.Command_result);
            }
            else if (splitCommand[0] == "users" || splitCommand[0] == "users")
            {
                if (splitCommand[1] == "registered"){
                    Server.Storage.ServerData.Log.addLog(Server.Storage.ServerData.Uman.Users.Count.ToString(), Log.LogTypes.Command_result);
                }

                if (command.Split(' ').Length == 2 && command.Split(' ')[1] == "online")
                {
                    Server.getOnlineUsers();
                }
                else if (command.Split(' ').Length == 3)
                {
                    Server.userCommands(command.Split(' ')[1], command.Split(' ')[2]);
                }
            }
            else if (splitCommand[0] == "new")
            {
                Server.createStuff(splitCommand);
            }
            else {
                Server.Storage.ServerData.Log.addLog("Unknown Command", DataLab.Server.Controller.Logging.Log.LogTypes.Warning);
            }

            ObservableCollection<Log> logs = listView.DataContext as ObservableCollection<Log>;
            if (logs != null)
                if (logs.Count > 0)
                    this.listView.ScrollIntoView(logs[logs.Count - 1]);
        }

        // * Commands * //
        private void startServer()
        {
            // Start server
            Server.Activate();

            
        }
        private void pauseServer()
        {
            Server.pause();
            Server.Storage.ServerData.Log.addLog("Paused server", DataLab.Server.Controller.Logging.Log.LogTypes.Server_Status);
        }


        private void stopServer()
        {
            Server.stop();
            Server.Storage.saveStorage();
            Server.Storage.ServerData.Log.addLog("Stopped server", DataLab.Server.Controller.Logging.Log.LogTypes.Server_Status);
        }

        private void listView_DataContextChanged(FrameworkElement sender, DataContextChangedEventArgs args)
        {
            //listView.ScrollIntoView(listView.Items.Last());
        }

        private const string HelpString = @"You need help? Meaby the following commands can help you: \n" +
                                            "- Start \t Starts the server \n " +
                                            "- Pause \t Pauses the server \n " +
                                            "- Stop \t Stops the server \n " +
                                            "- Save \t Saves the server data \n " +
                                            "- Clear \t Clears the console screen \n " +
                                            "- 'users online' \t Prints all currently online users \n" +
                                            "- 'name <filterparams>' Prints all users with the filterparams in it's name \n" +
                                            "- 'delete <filterparams>' Delete users named 'filterparams'\n " +
                                            "- 'edit <filterparams>' DONT USE YET \n " +
                                            "- 'new user <username> <password> creates a new user";
    }
}
