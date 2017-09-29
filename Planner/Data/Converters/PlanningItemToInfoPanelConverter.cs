using DataLab.Data.Planning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace Planner.Data.Converters
{
    public class PlanningItemToInfoPanelConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            PlanningItem item = value as PlanningItem;

            StringBuilder itemString = new StringBuilder();

            if (item != null)
            {
                itemString.AppendLine(item.Name + "  (" + item.Start.ToString() + "-" +item.End.ToString()+")");
                itemString.AppendLine(item.Description);
            }

            return itemString.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
