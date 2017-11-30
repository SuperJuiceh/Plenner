using DataLab.Data.Planning;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Windows.Storage;

namespace DataLab.Storage.Backups
{
    public class StorageBackups
    {
        private BackUpSettings BackupSettings { get; set; } = new BackUpSettings(10);
        [XmlArray("BackUpLocationPaths"), XmlArrayItem(typeof(string))]
        private List<string> BackUpLocationPaths { get; set; } = new List<string>();
        private string BackupsFolderName { get; set; } = "\\Backups\\";
        private string BackupsFolderPath { get; set; }

        public bool   IsInit { get; set; }


        public StorageBackups()
        {
            
            this.BackupsFolderPath = ApplicationData.Current.LocalFolder.Path + BackupsFolderName;
        }
        
        public PlanningItemStorage CreatePlanningNewItemsBackUp(Plan s, bool overideOld)
        {
            string newFileName = StorageDefaults.DefaultBackupsPath+ "planning"+ DateTime.Now.ToString().Replace(':', ';').Replace('/', '-') + ".pln";
            PlanningItemStorage storage = null;
            bool couldAdd = AddBackup(newFileName);
            Debug.WriteLine("Couuld add: " + couldAdd);
            if (couldAdd || overideOld)
            {
                Debug.WriteLine("Can add");
                storage = new PlanningItemStorage(newFileName, s);
                while (storage.StorageObject == null) { Debug.WriteLine("Waiting"); }
            } else
            {
                throw new Exception("Backup already exists");
            }

            return storage;
        }

        /// <summary>
        /// <para>Adds file string path to list and returns if was added</para>
        /// </summary>
        /// <param name="Path"></param>
        /// <returns></returns>
        private bool AddBackup(string Path)
        {
            if (!BackUpLocationPaths.Contains(Path) && BackupSettings.MaxBackups > BackUpLocationPaths.Count())
            {
                BackUpLocationPaths.Add(Path);
                BackupSettings.MaxBackups += 1;
            }
            else
                return false;

            return true;
        }

        private void RemoveBackup(string Path)
        {
            if (!BackUpLocationPaths.Contains(Path))
            {
                if (!(BackUpLocationPaths.Count() >= BackupSettings.MaxBackups))
                {
                    BackUpLocationPaths.Add(Path);
                    BackupSettings.MaxBackups -= 1;
                }
                else
                    throw new Exception("Max capacity already reached, will not add Backup.");
            }
                
        }

        public static async Task<StorageBackups> Create()
        {
            StorageBackups backups = new StorageBackups();
            backups.LoadBackups();

            while (!backups.IsInit)
            {
                Debug.WriteLine("not init yet");
                await Task.Delay(250);
            }

            Debug.WriteLine(backups.ToString());

            return backups;
        }

        /// <summary>
        /// <para> Gets all strings from list and generates the files by loading them from the device storage</para>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<List<PlanningItemStorage>> GetBackUpFiles()
        {
            List<PlanningItemStorage> files = new List<PlanningItemStorage>();

            for (int counter = 0; counter < BackUpLocationPaths.Count(); counter++)
            {
                PlanningItemStorage s = new PlanningItemStorage(await StorageFile.GetFileFromPathAsync(BackUpLocationPaths[counter]));
                await s.loadStorage();
                files.Add(s);
            }

            return files;
        }

        public async void SetBackUpAsDefault(DateTime time)
        {
            string filename = BackupsFolderPath + "planning"+time.ToString().Replace(':',';').Replace('/','-')+".pln";
            if (BackUpLocationPaths.Contains(filename))
            {
                PlanningItemStorage originalPlanning = PlanningItemStorage.GetConcreteStorage();
                StorageFile backupPlanning  = await StorageFile.GetFileFromPathAsync(filename);
                
                await backupPlanning.MoveAndReplaceAsync(originalPlanning.SaveLocation);

                PlanningItemStorage a = CreatePlanningNewItemsBackUp(originalPlanning.plan, true);

                Debug.WriteLine("Replaced with backup");
                Debug.WriteLine(a.plan.Activities.Count().ToString());

            }
        }

        public void SetBackUpAsDefault(int pos)
        {
            if (BackUpLocationPaths.Count() > pos)
            {
                Debug.WriteLine(DateTime.Now.ToString().Replace(':', ';').Replace('/', '-'));
                Debug.WriteLine("Back up location: "+ BackUpLocationPaths[0]);
                string dateString = BackUpLocationPaths[pos].Split('\\')
                                                            .First(str => str.Contains(".pln"))
                                                            .Replace(".pln", "")
                                                            .Replace("planning", "")
                                                            .Replace(";", ":");
                Debug.WriteLine("date string: " + dateString);
                DateTime foundDate;

                if (DateTime.TryParse(dateString, out foundDate))
                {
                    Debug.WriteLine("Found Backup");
                    SetBackUpAsDefault(foundDate);
                }
            }
        }
        /// <summary>
        /// <para>Find all backups on device storage and load them into the string list (Doesn't actually load the files)</para>
        /// </summary>
        public async void LoadBackups()
        {
            this.IsInit = false;
            StorageFolder folder = await StorageFolder.GetFolderFromPathAsync(BackupsFolderPath);
            BackUpLocationPaths.Clear();

            foreach (StorageFile file in await folder.GetFilesAsync())
            {
                // Add all files from file extention '*.pln'
                if (file.Name.EndsWith(".pln") && !BackUpLocationPaths.Contains(file.Path))
                {
                    BackUpLocationPaths.Add(file.Path);

                }
            }
            this.IsInit = true;
            
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine(String.Format("Got {0} backups in {1}", BackUpLocationPaths.Count().ToString(), BackupsFolderPath));
            
            foreach (string file in BackUpLocationPaths)
            {
                builder.AppendLine(String.Format("{0}. {1}", BackUpLocationPaths.IndexOf(file).ToString(), file ));
            }

            return builder.ToString();
        }
    }

    public class BackUpSettings
    {
        public int MaxBackups { get; set; }

        public BackUpSettings(int maxBackups)
        {
            this.MaxBackups = maxBackups;
        }

        private BackUpSettings()
        {

        }
    }
}
