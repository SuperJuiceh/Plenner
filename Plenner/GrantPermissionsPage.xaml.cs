using DataLab.Storage;
using Datalab.Server.Packets;
using DataLab.Data.Planning;
using DataLab.Data.Users.Contracts;
using DataLab.Server.Packets;
using Plenner.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using static DataLab.Data.Users.Contracts.PlanningContract;
using DataLab.NetworkPackaging;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Plenner
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GrantPermissionsPage : Page
    {

        public PlanningItemStorage plan { get; set; }

        private string _grantingTo;
        

        public ObservableCollection<SelectPermission> SelectedPermissions { get; set; } = new ObservableCollection<SelectPermission>();

        public GrantPermissionsPage()
        {
            this.InitializeComponent();
        }
        
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            Tuple<PlanningItemStorage, string> storage = e.Parameter as Tuple<PlanningItemStorage, string>;

            if (storage != null)
            {
                plan = storage.Item1;
                _grantingTo = storage.Item2;
            }
        }

        private void permissionTypeList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListView view = sender as ListView;

            if (view != null)
            {
                ListViewItem item = (ListViewItem)view.SelectedItem;
                string content = item.Content as string;

                setPermissionsListView(content);

            }
        }

        public void setPermissionsListView(string item)
        {
            SelectedPermissions.Clear();

            if (item == "Planning Item")
            {
                SelectedPermissions.Add(new SelectPermission() { Name = "Activities" });
                SelectedPermissions.Add(new SelectPermission() { Name = "Diaries" });
                SelectedPermissions.Add(new SelectPermission() { Name = "Reflections" });
                SelectedPermissions.Add(new SelectPermission() { Name = "ToDoItems" });
            }

            if (item == "Messaging")
            {
                SelectedPermissions.Add(new SelectPermission() { Name = "Messages" });
                SelectedPermissions.Add(new SelectPermission() { Name = "Mails" });
            }
        }

        public List<PlanningPermissionsEnum> getSelectedPermissions()
        {
            List<PlanningPermissionsEnum> permissions = new List<PlanningPermissionsEnum>();
            
            SelectedPermissions.ToList().ForEach(perm =>
            {
                Debug.WriteLine("Scanning a Permission class");

                if (perm.Name == "Activities")
                {
                    if (perm.CanRead)
                        permissions.Add(PlanningContract.PlanningPermissionsEnum.READ_ACTIVITIES);
                    if (perm.CanWrite)
                        permissions.Add(PlanningContract.PlanningPermissionsEnum.WRITE_ACTIVITIES);
                    if (perm.CanDelete)
                        permissions.Add(PlanningContract.PlanningPermissionsEnum.DELETE_ACTIVITIES);

                }
                if (perm.Name == "Diaries")
                {
                    if (perm.CanRead)
                        permissions.Add(PlanningContract.PlanningPermissionsEnum.READ_DIARIES);
                    if (perm.CanWrite)
                        permissions.Add(PlanningContract.PlanningPermissionsEnum.WRITE_DIARIES);
                    if (perm.CanDelete)
                        permissions.Add(PlanningContract.PlanningPermissionsEnum.DELETE_DIARIES);

                }
                if (perm.Name == "Reflections")
                {
                    if (perm.CanRead)
                        permissions.Add(PlanningContract.PlanningPermissionsEnum.READ_REFLECTIONS);
                    if (perm.CanWrite)
                        permissions.Add(PlanningContract.PlanningPermissionsEnum.WRITE_REFLECTIONS);
                    if (perm.CanDelete)
                        permissions.Add(PlanningContract.PlanningPermissionsEnum.DELETE_REFLECTIONS);

                }
                if (perm.Name == "ToDoItems")
                {
                    if (perm.CanRead)
                        permissions.Add(PlanningContract.PlanningPermissionsEnum.READ_TODOITEMS);
                    if (perm.CanWrite)
                        permissions.Add(PlanningContract.PlanningPermissionsEnum.WRITE_TODOITEMS);
                    if (perm.CanDelete)
                        permissions.Add(PlanningContract.PlanningPermissionsEnum.DELETE_TODOITEMS);

                }

            });

            Debug.WriteLine("Permissions list has {0} Permissions inside", permissions.Count);

            return permissions;

        }

        private void grant_perms_button_Click(object sender, RoutedEventArgs e)
        {
            List<PlanningPermissionsEnum> permissions = getSelectedPermissions();
            // Send permissions
            OneWayPacket owPacket = OneWayPacket.sendPermission(_grantingTo, permissions);
            PacketClient.sendPacket(owPacket);

            // Back to friends page
            this.Frame.Navigate(typeof(FriendsPage));
        }
    }


}
