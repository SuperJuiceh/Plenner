using DataLab.Data.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace Planner.Data.Converters
{
    public class UserNullStatusToBoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            bool status = (bool)value;

            User user = value as User;

            if (user != null && !status)
            {
                status = false;
            }
            else if (user != null && status)
            {
                status = true;
            }

            if (status)
                return Visibility.Visible;

            return Visibility.Collapsed;

        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
