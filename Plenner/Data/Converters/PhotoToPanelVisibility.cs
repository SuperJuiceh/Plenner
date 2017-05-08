using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.UI.Xaml.Data;

namespace Plenner.Data.Converters
{
    public class PhotoToPanelVisibility : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            StorageFile file = value as StorageFile;

            if (file != null)
                return "Visible";

            return "Collapsed";
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
