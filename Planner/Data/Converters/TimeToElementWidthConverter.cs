using DataLab.Data.Planning;
using DataLab.Tools;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace Planner.Data.Converters
{
    public class TimeToElementWidthConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            PlanningItem item = value as PlanningItem;
            DateTime now = DateTime.Now;
            double windowWidthDevided = 16.6 / 60;

            object element = parameter as object;
            
            if (item != null)
            {
                // width of 16 is an hour
                //Debug.WriteLine("Returning: " + (16 * ((item.End - item.Start).TotalHours)).ToString());
                if (item.Start == new DateTime(0))
                {
                    item.Start = DateTime.Now;
                }

                if (item.End > now.GetEndOfDay())
                {
                    item.End = DateTime.Now.GetEndOfDay();
                }

                if (item.Start < now.GetstartOfDay())
                {
                    item.Start = DateTime.Now.GetstartOfDay();
                }

                double calcedWidth = windowWidthDevided * ((item.End - item.Start).TotalMinutes);

                return calcedWidth < 0 ? -calcedWidth : calcedWidth;
            }

            return 0;
            
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
