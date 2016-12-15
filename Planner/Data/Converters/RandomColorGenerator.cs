using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace Planner.Data.Converters
{
    public class RandomColorGenerator : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return new SolidColorBrush(randomColor());
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }

        public static Color randomColor()
        {
            int r = new Random().Next(255), 
                g = new Random().Next(255), 
                b = new Random().Next(255);

            return Color.FromArgb(150, (byte)r, (byte)g, (byte)b);
        }
    }
}
