using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLab.Data.Work
{
    public class WorkManager
    {
        private List<WorkingPlace> WorkingPlaces { get; set; } = new List<WorkingPlace>();

        public WorkManager()
        {

        }

        public bool addWorkingPlace(WorkingPlace place)
        {
            if (!WorkingPlaces.Any(wp => wp.Name == place.Name))
            {
                WorkingPlaces.Add(place);
                return true;
            }

            return false;
        }

        
    }
}
