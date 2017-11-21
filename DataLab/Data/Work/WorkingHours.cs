using System;

namespace DataLab.Data.Work
{
    public class WorkingHours
    {

        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public double HoursWorked { get { return (End - Start).TotalHours; } }

        public WorkingHours(DateTime start, DateTime end)
        {
            if (!IsSameDay(start, end))
                throw new Exception("Must start and end on the same day");
        }

        public static bool IsSameDay(DateTime start, DateTime end)
        {
            return (start.Day == end.Day && start.Month == end.Month && start.Year == end.Year);
        }
    }
}