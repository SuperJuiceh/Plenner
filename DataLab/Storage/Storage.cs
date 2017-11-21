
using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Windows.Storage;

namespace DataLab.Storage
{
    public abstract class Storage<T>
    {

        public StorageFile   SaveLocation { get; set; }

        public T             StorageObject;

        public XmlSerializer    Serializer;

        public Storage(string filename)
        {
            Serializer          = new XmlSerializer(typeof(T));

            Task.Run(() => initStorage(filename));
        }

        public Storage(Storage<T> s)
        {
            this.SaveLocation = s.SaveLocation;
            this.StorageObject = s.StorageObject;
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
                    StorageObject = (T)Activator.CreateInstance(typeof(T));
                    SaveLocation = await ApplicationData.Current.LocalFolder.CreateFileAsync(filename, CreationCollisionOption.ReplaceExisting);
                    saveStorage();

                    
                }


                Debug.WriteLine(e.Message);
            }

            
            Debug.WriteLine("Done");
        }

        public async Task<T> loadStorage()
        {

            using (Stream striem = await SaveLocation.OpenStreamForReadAsync())
            {
                try
                {

                    Serializer = new XmlSerializer(typeof(T));
                    //var settings = new XmlReaderSettings();
                    //settings.Async = true;
                    XmlReader reader = XmlReader.Create(striem);
                    
                    //while (await reader.ReadAsync())
                    //{
                    //    Debug.WriteLine(await reader.GetValueAsync());
                    //}

                    StorageObject = (T)Serializer.Deserialize(reader);
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.Message);
                    StorageObject = (T)Activator.CreateInstance(typeof(T));
                    
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
