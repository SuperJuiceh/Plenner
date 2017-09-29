using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLab.Tools
{
    public static class DateTools
    {

        public static bool IsSameDay(this DateTime d1, DateTime d2)
        {
            return d1.Day == d2.Day &&
                   d1.Month == d2.Month &&
                   d1.Year == d2.Year;
        }

        public static bool IsSameDay(this DateTime d1, DateTimeOffset d2)
        {
            Debug.WriteLine("IsSameDay: "+ (d1.Day == d2.Day &&
                   d1.Month == d2.Month &&
                   d1.Year == d2.Year).ToString());

            return d1.Day == d2.Day &&
                   d1.Month == d2.Month &&
                   d1.Year == d2.Year;
        }

        public static bool isBetweenStartAndEnd(this DateTime t, DateTime FilterStartTime, DateTime FilterEndTime)
        {
            Debug.WriteLine("It is");
            Debug.WriteLine((FilterStartTime.IsSameDay(t) || FilterStartTime < t) &&
                    (FilterEndTime.IsSameDay(t) || FilterEndTime > t));

            return (FilterStartTime.IsSameDay(t) || FilterStartTime < t) &&
                    (FilterEndTime.IsSameDay(t) || FilterEndTime > t);
        }
    }
}
