using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace Planner.Data.Converters
{
    public class DaysListToStringConverter : IValueConverter
    {
        object IValueConverter.Convert(object value, Type targetType, object parameter, string language)
        {
            string daysString = "";

            List<DayOfWeek> Days = value as List<DayOfWeek>;

            if (Days != null) {
                Days.ForEach(day => {
                    if (daysString != "")
                        daysString += ", ";
                    daysString += day.ToString().Substring(0, 2);
                    });
            }

            return daysString;
        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
