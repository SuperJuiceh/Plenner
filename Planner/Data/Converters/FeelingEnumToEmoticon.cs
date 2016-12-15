using DataLab.Data.Planning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace Planner.Data.Converters
{
    public class FeelingEnumToEmoticon : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            try
            {
                Reflection.Feelings feels = (Reflection.Feelings)value;
                switch (feels)
                {
                    case Reflection.Feelings.HAPPY: return "/Assets/emoticons/happy.png";
                    case Reflection.Feelings.MAD: return "/Assets/emoticons/mad.png";

                }
            }
            catch (InvalidCastException ex)
            {
                ex.ToString();
            }

            return "/Assets/neutral.png";
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
