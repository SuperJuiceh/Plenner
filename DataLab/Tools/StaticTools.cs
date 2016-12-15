using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLab.Tools
{
    public static class StaticTools
    {
        
        public static string monthNumberToString(int mNumber)
        {
            string tempString = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(mNumber);

            if (tempString.Length > 2)
            {
                return tempString.Substring(0, 3);
            } else
            {
                return tempString;
            }

        }
    }
}
