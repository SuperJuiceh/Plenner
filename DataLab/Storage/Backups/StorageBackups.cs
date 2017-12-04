using DataLab.Data.Planning;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Windows.Storage;

namespace DataLab.Storage.Backups
{
    public class StorageBackups: INotifyPropertyChanged
    {
        private BackUpSettings BackupSettings { get; set; } = new BackUpSettings(10);
        [XmlArray("BackUpLocationPaths"), XmlArrayItem(typeof(string))]
        public ObservableCollection<string> BackUpLocationPaths { get; private set; } = new ObservableCollection<string>();
        private string BackupsFolderName { get; set; } = "\\Backups\\";
        private string BackupsFolderPath { get; set; }

        public bool   IsInit { get; set; }


        public StorageBackups()
        {
            
            this.BackupsFolderPath = ApplicationData.Current.LocalFolder.Path + BackupsFolderName;
            createFolderIfNeeded();
            
        }

        private async void createFolderIfNeeded()
        {

            try
            {
                await StorageFolder.GetFolderFromPathAsync(StorageDefaults.DefaultBackupsPath);
            } catch (FileNotFoundException e) { 
                StorageFolder folder = ApplicationData.Current.LocalFolder;
                await folder.CreateFolderAsync(BackupsFolderName.Replace('\\','\\'));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public int getBackupFilePosition(string backupPath)
        {
            BackUpLocationPaths.ToList().ForEach(s => Debug.WriteLine(s));
            return BackUpLocationPaths.ToList().Contains(backupPath) ? BackUpLocationPaths.IndexOf(backupPath) : -1;
        }

        public PlanningItemStorage CreatePlanningNewItemsBackUp(Plan s, bool overideOld)
        {
            Debug.WriteLine("Creating new itemsbackup");
            string newFileName = StorageDefaults.DefaultBackupsPath+ "planning"+ DateTime.Now.ToString().Replace(':', ';').Replace('/', '-') + ".pln";
            PlanningItemStorage storage = null;
            bool couldAdd = AddBackup(newFileName);

            if (couldAdd || overideOld)
            {
                storage = new PlanningItemStorage(newFileName, s);

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

        public async void RemoveBackup(string Path)
        { 
            if (BackUpLocationPaths.Contains(Path) && !(Path == StorageDefaults.DefaultBackupsPath))
            {
                await (await GetBackUpFile(Path)).SaveLocation.DeleteAsync();
                BackupSettings.MaxBackups -= 1;
                BackUpLocationPaths.Remove(Path);
                Debug.WriteLine("Backups Removed");
            }   
        }

        public static async Task<StorageBackups> Create()
        {
            StorageBackups backups = new StorageBackups();
            backups.LoadBackups();

            while (!backups.IsInit)
            {
                await Task.Delay(250);
            }

            Debug.WriteLine(backups.ToString());

            return backups;
        }

        public async Task<PlanningItemStorage> GetBackUpFile(string filepath)
        {
            Debug.WriteLine(filepath);
            Debug.WriteLine(BackUpLocationPaths.Count().ToString());

            for (int counter = 0; counter < BackUpLocationPaths.Count(); counter++)
            {
                Debug.WriteLine(BackUpLocationPaths[counter] == filepath);
                if (BackUpLocationPaths[counter] == filepath)
                {
                    PlanningItemStorage s = new PlanningItemStorage(await StorageFile.GetFileFromPathAsync(BackUpLocationPaths[counter]));
                    await s.loadStorage();
                    return s;
                }
            }

            throw new NullReferenceException("Backup Not Found");
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
                
                Debug.WriteLine(a.plan.Activities.Count().ToString());

            }
        }

        public void SetBackUpAsDefault(int pos)
        {
            if (BackUpLocationPaths.Count() > pos)
            {
                string dateString = BackUpLocationPaths[pos].Split('\\')
                                                            .First(str => str.Contains(".pln"))
                                                            .Replace(".pln", "")
                                                            .Replace("planning", "")
                                                            .Replace(";", ":");

                DateTime foundDate;

                if (DateTime.TryParse(dateString, out foundDate))
                {
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

        public void Changed(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }

    public class BackUpSettings: INotifyPropertyChanged
    {
        private int _maxBackups;

        public event PropertyChangedEventHandler PropertyChanged;

        public int MaxBackups { get => _maxBackups; set { _maxBackups = value; Changed("MaxBackups"); } }

        public BackUpSettings(int maxBackups)
        {
            this.MaxBackups = maxBackups;
        }

        private BackUpSettings()
        {

        }

        public void Changed(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
