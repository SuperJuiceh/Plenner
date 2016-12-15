using DataLab.Tools;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace Planner.Data.Converters
{
    public class DateTimeFormatConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            StringBuilder stringedTime = new StringBuilder(30);

            if (value is TimeSpan) {
                TimeSpan ts = (TimeSpan)value;

                stringedTime.Append(String.Format("00", ts.Hours) + ":" + String.Format("00", ts.Minutes) + " ");
            }

            if (value is DateTime) {
                DateTime dt = (DateTime)value;

                stringedTime.Append(dt.Hour.ToString("00") + ":" + dt.Minute.ToString("00")
                                            + " " + dt.Day + "-"
                                            + StaticTools.monthNumberToString(dt.Month + 1));
            }

            if (parameter != null)
            {

                if (parameter is DateTime)
                {
                    DateTime t = (DateTime)parameter;

                    stringedTime.Append(" "+ t.Hour.ToString("00") + ":" + t.Minute.ToString("00")
                                                + " " + t.Day + "-"
                                                + CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(t.Month + 1).Substring(0, 3));
                }
                if (parameter is TimeSpan)
                {
                    TimeSpan t = (TimeSpan)parameter;
                    stringedTime.Append(String.Format("00", t.Hours) + ":" + String.Format("00", t.Minutes) + " ");
                }
            }

            return stringedTime.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
