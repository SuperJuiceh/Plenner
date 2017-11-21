using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace Planner.Data.Converters
{
    public class DateTimeToStringConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            StringBuilder builder = new StringBuilder();

            try
            {
                DateTime time = (DateTime)value;

                builder.Append(String.Format("{0}:{1}", time.Hour.ToString(), time.Minute.ToString()));


            }
            catch (Exception)
            {

            }

            return builder.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
