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

    }
}
