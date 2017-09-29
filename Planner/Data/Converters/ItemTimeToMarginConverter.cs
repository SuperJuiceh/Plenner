using DataLab.Data.Planning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace Planner.Data.Converters
{
    public class ItemTimeToMarginConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            PlanningItem item = value as PlanningItem;

            if (item != null)
            {
                return 16 * item.Start.Hour + ",0,0,0";
            }

            return "0,0,0,0";
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
