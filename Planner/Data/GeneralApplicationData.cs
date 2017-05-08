using DataLab.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Data
{
    public static class GeneralApplicationData
    {

        public static PlanningItemStorage        Planning { get; set; }

        public static DynamicPlanningItemStorage DynamicPlanning { get { return (DynamicPlanningItemStorage)Planning; } }
        
        public static SettingsStorage            Settings { get; set; }


        public static void InitStorage() { Planning = new PlanningItemStorage(); }
        public static void InitDynamicStorage() { }
        

    }
}
