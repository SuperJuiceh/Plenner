using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;
using Windows.Graphics.Imaging;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Planner.Data.Converters
{
    public static class ClassConverters
    {

        public static Geopoint intArrayToGeopoint(int[] pos) {
            return new Geopoint(new BasicGeoposition { Altitude = pos[0], Latitude = pos[1], Longitude = pos[2] });
        }

        public static Geopoint geopositiontogeopoint(Geoposition pos)
        {
            
            //Debug.WriteLine(pos.VenueData.ToString());
            return new Geopoint(geopositiontobgp(pos));
        }

        public static BasicGeoposition geopositiontobgp(Geoposition pos)
        {
            BasicGeoposition bgpos = new BasicGeoposition()
            {

                Altitude = pos.Coordinate.Point.Position.Altitude,
                Latitude = pos.Coordinate.Point.Position.Latitude,
                Longitude = pos.Coordinate.Point.Position.Longitude

            };


            //Debug.WriteLine(pos.VenueData.ToString());
            return bgpos;
        }

        public async static Task<SoftwareBitmap> StorageFileToSoftwareBitmap(StorageFile sf)
        {
            IRandomAccessStream stream = await sf.OpenAsync(FileAccessMode.ReadWrite);
            BitmapDecoder decoder = await BitmapDecoder.CreateAsync(stream);
            SoftwareBitmap displayableImage = SoftwareBitmap.Convert(await decoder.GetSoftwareBitmapAsync(), BitmapPixelFormat.Bgra8, BitmapAlphaMode.Premultiplied);
            return displayableImage;
        }

        public static DateTime DateAndTimeToDateTime(DateTimeOffset date, TimeSpan time)
        {
            return new DateTime(date.Year, date.Month, date.Day, time.Hours, time.Minutes, time.Seconds);
        }
        
        public static DateTime DateTimeOffsetToDateTime(DateTimeOffset offset)
        {
            return new DateTime(offset.Year, offset.Month, offset.Day, 1, 1, 1);
        }
    }
}
