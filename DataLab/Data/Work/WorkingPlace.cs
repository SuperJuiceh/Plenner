using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace DataLab.Data.Work
{
    public class WorkingPlace
    {

        public string Name { get; private set; }

        public ObservableCollection<WorkingHours> WorkedHours { get; private set; } = new ObservableCollection<WorkingHours>();

        public WorkingPlace(string Name)
        {
            this.Name = Name;
        }

        private WorkingPlace()
        {

        }

        public bool addWorkingHours(WorkingHours hours)
        {
            if (!WorkedHours.Any(wh => WorkingHours.IsSameDay(hours.Start, wh.Start))){
                WorkedHours.Add(hours);
                return true;
            }

            return false;
        }
    }
}