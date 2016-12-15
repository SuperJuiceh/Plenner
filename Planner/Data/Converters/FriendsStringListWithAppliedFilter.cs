using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace Planner.Data.Converters
{
    public class FriendsStringListWithAppliedFilter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            ObservableCollection<string> Friends = value as ObservableCollection<string>;
            string filter = parameter as string;

            //Debug.WriteLine("Searching with {0} and {1}", Friends.Count, filter);

            if (Friends != null)
            {
                if (filter != null)
                    if (filter != "")
                        return new ObservableCollection<string>(Friends.Where(str => str.Contains(filter)).ToList());
                
                return Friends;
            }

            return new ObservableCollection<string>();
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
