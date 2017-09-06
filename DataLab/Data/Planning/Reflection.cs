using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Windows.Devices.Geolocation;
using Windows.Graphics.Imaging;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI.Xaml.Media.Imaging;

namespace DataLab.Data.Planning
{
    public class Reflection : PlanningItem
    {
        // Photo image
        [XmlIgnore]
        private string _photoLocation;
        [XmlElement("PhotoLocation")]
        public string PhotoLocation { get { return _photoLocation; } set { _photoLocation = value; getPhoto(); } }
        [XmlIgnore]
        public SoftwareBitmap _photo { get; set; }
        [XmlAttribute("BitmapPixelFormat")]
        public BitmapPixelFormat Format { get; set; }
        [XmlArray("Dimension")]
        public int[] Dimension { get; set; }
        [XmlIgnore]
        public SoftwareBitmap Photo { get; set; }
        [XmlIgnore]
        public Geopoint Location { get { return new Geopoint(basicgeoloc); } }
        [XmlElement("basicgeoloc")]
        public BasicGeoposition basicgeoloc { get; set; }
        [XmlIgnore]
        public StorageFile PhotoFile { get; set; }
        [XmlIgnore]
        public SoftwareBitmapSource _poto;
        [XmlIgnore]
        public SoftwareBitmapSource Poto { get { return _poto; } set { this._poto = value; Changed("Poto"); }  }
        [XmlAttribute("Time")]
        public DateTime Time { get; set; }

        public enum Feelings
        {
            DELIGHTED,
            DREAMY,
            HAPPY,
            MAD,
            NEUTRAL,
            SAD,
            SURPRISED,
            VAGUE
        }
        [XmlAttribute("Feeling")]
        public Feelings Feeling { get; set; } = Feelings.NEUTRAL;


        public Reflection(string name, string description) : base(name)
        {
            this.Description = description;

            this.Time = DateTime.Now;
        }

        public Reflection(string name, string description, StorageFile photofile, BasicGeoposition bgp) : this(name, description)
        {
            this.basicgeoloc = bgp;
            this.PhotoFile = photofile;
            this.PhotoLocation = PhotoFile.Path;

        }

        public Reflection(string name, string description, StorageFile photofile) : this(name, description)
        {
            this.PhotoFile = photofile;
            this.PhotoLocation = PhotoFile.Path;
        }

        public Reflection(string name, string description, BasicGeoposition bgp) : this(name, description)
        {
            this.basicgeoloc = bgp;
            this.PhotoLocation = PhotoFile.Path;

        }
        

        private async void getPhoto() {
            if (PhotoLocation != "" || PhotoLocation == null)
            {
                Debug.WriteLine("Location is " + PhotoLocation);
                PhotoFile = await StorageFile.GetFileFromPathAsync(PhotoLocation);

                using (IRandomAccessStream stream = await PhotoFile.OpenAsync(FileAccessMode.Read))
                {
                    BitmapDecoder decoder = await BitmapDecoder.CreateAsync(stream);
                    this.Photo = await decoder.GetSoftwareBitmapAsync();

                    SoftwareBitmapSource source = new SoftwareBitmapSource();
                    await source.SetBitmapAsync(SoftwareBitmap.Convert(this.Photo, BitmapPixelFormat.Bgra8, BitmapAlphaMode.Premultiplied));
                    Poto = source;
                    Changed("Poto");

                    stream.Dispose();
                }
            }

        }

        public async void deleteReflectionPhoto()
        {
            // Delete photo file stored on the device
            //using (IRandomAccessStream stream = PhotoFile.OpenAsync(FileAccessMode.ReadWrite))
            try
            {
                PhotoFile = await StorageFile.GetFileFromPathAsync(PhotoLocation);
                await PhotoFile.DeleteAsync(StorageDeleteOption.PermanentDelete);
            } catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }

        private Reflection() : base()
        {

        }
    }
}
