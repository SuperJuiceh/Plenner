using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;

namespace Planner.Data.Converters
{
    public class BoolToStackPanelVisibility : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            bool state = (bool)value;

            if (state)
                return "Visible";
            
            return "Collapsed";

        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
