using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;
using System.Xml.Serialization;

namespace DataLab.Data.Planning
{
    public class PlanningItemSet: TimeSpanPlanning
    {
        [XmlArray("PlanningItems"), XmlArrayItem(typeof(ToDoItem), ElementName = "ToDoItem")]
        public List<PlanningItem> Items { get; set; } = new List<PlanningItem>();

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        private PlanningItemSet(): base()
        {

        }

        public void addPlanningItem(PlanningItem pi)
        {
            if (pi is Activity)
            {
                Activity act = pi as Activity;
                // Is the activity in between our Start and End times?
                if (act.Start >= this.Start && act.Start < this.End &&
                    act.End <= this.End && act.End > this.Start)
                {
                    Items.Add(act);
                }
                

            }
            if (pi is ToDoItem)
            {
                ToDoItem tdi = pi as ToDoItem;

                if (tdi != null)
                {
                    if (tdi.Deadline > this.Start && tdi.Deadline < this.End)
                    {
                        Items.Add(tdi);
                    }
                }
            }
                

            Items.Add(pi);
        }

        public void removePlanningItem(PlanningItem pi)
        {
            Items.Remove(pi);
        }

        public List<Activity> Activity { get { return Items.Where(item => item is Activity).Cast<Activity>().ToList(); } }
        public List<ToDoItem> ToDoItems { get { return Items.Where(item => item is ToDoItem).Cast<ToDoItem>().ToList();  } }
        


    }
}
