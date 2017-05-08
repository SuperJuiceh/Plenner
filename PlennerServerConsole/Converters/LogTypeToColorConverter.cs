using DataLab.Server.Controller.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace PlennerServer.Converters
{
    public class LogTypeToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            Color color = Colors.Black;

            try
            {
                Log.LogTypes lType = (Log.LogTypes)value;

                switch (lType) {

                    case Log.LogTypes.Command_result: color = Colors.Aqua; break;
                    case Log.LogTypes.Error: color = Colors.Yellow; break;
                    case Log.LogTypes.Server_Status: color = Colors.YellowGreen; break;
                    case Log.LogTypes.Warning: color = Colors.Red; break;
                    case Log.LogTypes.User_Activity: color = Colors.DarkCyan; break;
                }

            }
            catch (InvalidCastException ivex)
            {
                ivex.GetType();
            }

            return new SolidColorBrush(color);
            
            
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
