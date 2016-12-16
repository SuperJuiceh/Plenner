using Planner.Data.Converters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;
using Windows.UI.Xaml.Controls.Maps;

namespace DataLab.Tools
{
    public static class GeoTools
    {

        public const int EARTH_RADIUS_IN_KM = 6371;

        private static async void centerIfNotCentered(MapControl map)
        {
            // Fix ourselves a location
            await Geolocator.RequestAccessAsync();
            Geoposition pos1 = await new Geolocator().GetGeopositionAsync();
            
                
            BasicGeoposition pos = ClassConverters.geopositiontobgp(pos1);

            bool isCentered;

            // Check if we are in the current view
            map.IsLocationInView(new Geopoint(pos), out isCentered);

            if (!isCentered)
            {

                // must go to punt of zwaartekracht
                await map.TrySetViewAsync(new Geopoint(pos));

            } 
         }
        
        public static double toRadians(this double degrees)
        {
            return degrees * (Math.PI / 180);
        }

        public static int DistanceBetweenBasicGeoPoints(this BasicGeoposition pos1, BasicGeoposition pos2)
        {
            double dLat = (pos2.Latitude - pos1.Latitude).toRadians();
            double dLon = (pos2.Longitude - pos1.Longitude).toRadians();

            double a = Math.Pow(Math.Sin(dLat / 2), 2) +
                       Math.Cos(pos1.Latitude.toRadians()) * Math.Cos(pos2.Latitude.toRadians()) *
                       Math.Pow(Math.Sin(dLon / 2), 2);

            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            return (int)(EARTH_RADIUS_IN_KM * c * 1000);
        }

    }
}
