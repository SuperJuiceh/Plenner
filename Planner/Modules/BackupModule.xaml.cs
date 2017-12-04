using DataLab.Storage;
using DataLab.Storage.Backups;
using Planner.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
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

namespace Planner.Modules
{
    public sealed partial class BackupModule : UserControl
    {

        public StorageBackups BackupsMan { get; set; }

        public BackupModule()
        {
            Task.Run(async () => BackupsMan = await StorageBackups.Create());

            this.InitializeComponent();
        }

        private void setAsDefaultPlanningButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is FrameworkElement element)
            {
                string backupPath = (string)element.DataContext;

                int backUpNumber = BackupsMan.getBackupFilePosition(backupPath);
                Debug.WriteLine("num: "+ backUpNumber.ToString());

                if (backUpNumber != -1)
                {
                    BackupsMan.SetBackUpAsDefault(backUpNumber);
                    Debug.WriteLine("Backup set");

                }
            }


        }
        

        private void deleteBackupButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is FrameworkElement element)
            {
                string backupPath = (string)element.DataContext;
                int backUpNumber = -1;
                try
                {
                    backUpNumber = BackupsMan.getBackupFilePosition(backupPath);

                } catch (Exception f)
                {
                    Debug.WriteLine(f.Message);
                }

                if (backUpNumber != -1)
                {
                    BackupsMan.RemoveBackup((string)element.DataContext);
                    Debug.WriteLine("Backup removed");

                }
            }
        }

        private void backupNowButton_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Planning Path: " + GeneralApplicationData.Planning.FilePath);
            GeneralApplicationData.Planning = BackupsMan.CreatePlanningNewItemsBackUp(GeneralApplicationData.Planning.plan, true);
            Debug.WriteLine("Backup completed: " + GeneralApplicationData.Planning.FilePath);


        }
    }
}
