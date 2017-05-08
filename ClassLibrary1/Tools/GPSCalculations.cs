using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;

namespace DataLab.Tools
{
    public static class GPSCalculations
    {
        
        public const int EARTH_RADIUS_IN_KM = 6371;

        public static double toRadians(this double degrees)
        {
            return degrees * (Math.PI / 180);
        }

        public static int distanceBetween(this BasicGeoposition pos1, BasicGeoposition pos2)
        {
            double dLat = (pos2.Latitude - pos1.Latitude).toRadians();
            double dLon = (pos2.Longitude - pos1.Longitude).toRadians();

            double a = Math.Pow(Math.Sin(dLat / 2), 2) +
                       Math.Cos(pos1.Latitude.toRadians()) * Math.Cos(pos2.Latitude.toRadians()) *
                       Math.Pow(Math.Sin(dLon / 2), 2);

            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            return (int)(EARTH_RADIUS_IN_KM * c * 1000);
        }

        public static int distanceBetween(this Geocoordinate pos1, Geocoordinate pos2)
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
