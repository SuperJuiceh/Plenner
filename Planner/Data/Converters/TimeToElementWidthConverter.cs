using DataLab.Data.Planning;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace Planner.Data.Converters
{
    public class TimeToElementWidthConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            PlanningItem item = value as PlanningItem;
            double windowWidthDevided = 16.0;

            if (item != null)
            {
                // width of 16 is an hour
                //Debug.WriteLine("Returning: " + (16 * ((item.End - item.Start).TotalHours)).ToString());
                return windowWidthDevided * ((item.End - item.Start).Hours);
            }
            Debug.WriteLine(value.GetType().ToString());
            return 0;
            
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
