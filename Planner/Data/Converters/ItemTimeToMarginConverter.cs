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
    public class ItemTimeToMarginConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            PlanningItem item = value as PlanningItem;

            DateTime now = DateTime.Now;

            if (item != null)
            {
                if (item.Start == new DateTime(0))
                    item.Start = DateTime.Now;
                
                if (item.Start < now.GetstartOfDay())
                {
                    item.Start = DateTime.Now.GetstartOfDay();
                }
                

                Thickness a = new Thickness(16.6 / 60.0 * (item.Start.Hour * 60.0 + item.Start.Minute + item.Start.Second / 60.0), 0 , 0 , 0);
                return a;
            }

            return new Thickness();
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
