using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Windows.Storage;

using System.Xml;
using System.Xml.Serialization;
using System.IO;

using System.Diagnostics;

namespace DataLab.Storage
{
    public abstract class Storage
    {

        public StorageFile   SaveLocation { get; set; }

        public Object        StorageObject;
        public Type          StorageObjectType;

        public    XmlSerializer    Serializer;

        public Storage(string filename, Type objectType)
        {
            Serializer          = new XmlSerializer(objectType);
            StorageObjectType   = objectType;

            Task.Run(() => initStorage(filename));
        }

        public Storage(Storage s)
        {
            this.SaveLocation = s.SaveLocation;
            this.StorageObject = s.StorageObject;
            this.StorageObjectType = s.StorageObjectType;
            this.Serializer = s.Serializer;
        }

        public async void initStorage(string filename)
        {
            Debug.WriteLine("initStorage launched");
            try {
                // File Exists
                SaveLocation = await ApplicationData.Current.LocalFolder.GetFileAsync(filename);

                Debug.WriteLine(SaveLocation.Path);
                // Go back here and try again if we cannot load file
                loadStorageStartLoop:
                try
                { 

                    StorageObject = await loadStorage();
                }
                catch (UnauthorizedAccessException)
                {

                    await Task.Delay(1250);
                    goto loadStorageStartLoop;
                }
            } catch (FileNotFoundException) {

                // File doesnt exist yet
                StorageObject = Activator.CreateInstance(StorageObjectType);
                SaveLocation = await ApplicationData.Current.LocalFolder.CreateFileAsync(filename, CreationCollisionOption.ReplaceExisting);
                saveStorage();
            }

        }

        public async Task<object> loadStorage()
        {

            Stream striem = await SaveLocation.OpenStreamForReadAsync();
            

            try
            {
                
                Serializer = new XmlSerializer(StorageObjectType);
                XmlReader reader = XmlReader.Create(striem);

                StorageObject = Serializer.Deserialize(reader);
            }
            catch (Exception ex)
            {
                StorageObject = Activator.CreateInstance(StorageObjectType);
                saveStorage();
            }

            
            striem.Dispose();

            return StorageObject;
        }

        public virtual async void saveStorage()
        {
            goback:

            try
            {
                Stream striem = await SaveLocation.OpenStreamForWriteAsync();
                striem.SetLength(0);
                Serializer.Serialize(striem, StorageObject);
                striem.Dispose();
            } catch (UnauthorizedAccessException)
            {
                await Task.Delay(1000);
                goto goback;
            }
        }

        public bool waitToLoad(int timeout)
        {
            DateTime now = DateTime.Now;
            // Do while timeout isn't reached
            while (DateTime.Now < now + TimeSpan.FromSeconds(timeout))
            {
                if (StorageObject != null)
                    return true;
                else
                    Task.Delay(1000);
            }

            return false;
        }
        
        
    }
}
