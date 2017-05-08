using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLab.Tools
{
    public class StaticTools
    {

        public StaticTools()
        {
        }

        public string monnthNumberToString(int number)
        {
            return StaticTools.monthNumberToString(number);
        }
        
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

        // * get list from 1 to 99
        public int[] getIntArrayFrom0To100
        {
            get
            {
                return Enumerable.Range(6, 8).ToArray();
            }
        }

        public string[] getFontNames
        {
            get
            {
                return new string[] {
                    "Arial", "Calibri", "Cambria", "Cambria Math", "Comic Sans MS", "Courier New",
                    "Ebrima", "Gadugi", "Georgia",
                    "Javanese Text Regular Fallback font for Javanese script", "Leelawadee UI",
                    "Lucida Console", "Malgun Gothic", "Microsoft Himalaya", "Microsoft JhengHei",
                    "Microsoft JhengHei UI", "Microsoft New Tai Lue", "Microsoft PhagsPa",
                    "Microsoft Tai Le", "Microsoft YaHei", "Microsoft YaHei UI",
                    "Microsoft Yi Baiti", "Mongolian Baiti", "MV Boli", "Myanmar Text",
                    "Nirmala UI", "Segoe MDL2 Assets", "Segoe Print", "Segoe UI", "Segoe UI Emoji",
                    "Segoe UI Historic", "Segoe UI Symbol", "SimSun", "Times New Roman",
                    "Trebuchet MS", "Verdana", "Webdings", "Wingdings", "Yu Gothic",
                    "Yu Gothic UI"
                                    };
                //return Enumerable.Range(0, 100).ToArray();

            }
        }
    }
}
