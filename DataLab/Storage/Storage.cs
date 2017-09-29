
using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Windows.Storage;

namespace DataLab.Storage
{
    public abstract class Storage
    {

        public StorageFile   SaveLocation { get; set; }

        public Object        StorageObject;
        public Type          StorageObjectType;

        public XmlSerializer    Serializer;

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
            try {
                

                // File Exists
                SaveLocation = await ApplicationData.Current.LocalFolder.GetFileAsync(filename);
                //await SaveLocation.DeleteAsync();

                //SaveLocation = await ApplicationData.Current.LocalFolder.GetFileAsync(filename);
                
                Debug.WriteLine(SaveLocation.Path);
                // Go back here and try again if we cannot load file
                loadStorageStartLoop:
                try
                { 

                    StorageObject = await loadStorage();
                }
                catch (Exception e)
                {
                    if (e is UnauthorizedAccessException)
                    {
                        await Task.Delay(1250);
                        goto loadStorageStartLoop;
                    }

                }
            } catch (Exception e) {

                if (e is FileNotFoundException)
                {
                    // File doesnt exist yet
                    StorageObject = Activator.CreateInstance(StorageObjectType);
                    SaveLocation = await ApplicationData.Current.LocalFolder.CreateFileAsync(filename, CreationCollisionOption.ReplaceExisting);
                    saveStorage();

                    
                }


                Debug.WriteLine(e.Message);
            }

            
            Debug.WriteLine("Done");
        }

        public async Task<object> loadStorage()
        {

            using (Stream striem = await SaveLocation.OpenStreamForReadAsync())
            {
                try
                {

                    Serializer = new XmlSerializer(StorageObjectType);
                    //var settings = new XmlReaderSettings();
                    //settings.Async = true;
                    XmlReader reader = XmlReader.Create(striem);
                    
                    //while (await reader.ReadAsync())
                    //{
                    //    Debug.WriteLine(await reader.GetValueAsync());
                    //}

                    StorageObject = Serializer.Deserialize(reader);
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.Message);
                    StorageObject = Activator.CreateInstance(StorageObjectType);
                    
                    saveStorage();
                }

                striem.Flush();
            }
            
            return StorageObject;
        }

        public virtual async void saveStorage()
        {
            goback:

            try
            {
                using (Stream striem = await SaveLocation.OpenStreamForWriteAsync())
                {
                    striem.SetLength(0);
                    Serializer.Serialize(striem, StorageObject);

                    striem.Flush();
                }

            } catch (Exception)
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
