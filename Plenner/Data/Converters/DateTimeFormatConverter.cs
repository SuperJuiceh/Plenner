using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace Plenner.Data.Converters
{
    public class DateTimeFormatConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {

            if (value is TimeSpan) {
                TimeSpan ts = (TimeSpan)value;

                return ts.Hours + ":" + ts.Minutes + " " + ts.Days;
            }

            if (value is DateTime) {
                DateTime dt = (DateTime)value;
                if (parameter == null)
                {
                    if (dt != null)
                        return dt.Hour + ":" + dt.Minute + " " + dt.Day;
                } else if ((string)parameter == "full")
                {
                    if (dt != null)
                        return dt.Day + "/"+ dt.Month + "/"+ dt.Year + " "+ dt.Hour + ":" + dt.Minute + " " + dt.Day;
                }

            }

            return "";

        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
