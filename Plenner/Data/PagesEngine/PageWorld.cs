using DataLab.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plenner.Data.PagesEngine
{
    public static class PageWorld
    {
        // All pages
        public static List<Type>            Pages { get; set; } = new List<Type>() {   typeof(ActivitiesPage), typeof(ToDoPage),   typeof(ReflectionsPage),
                                                                                        typeof(CijfersPage),    typeof(SettingsPage) };

        public static PlanningItemStorage   Planning { get; set; }

        public static SettingsStorage       Storage { get; set; }


        public static Type CurrentPage { get; set; }


    }
}
