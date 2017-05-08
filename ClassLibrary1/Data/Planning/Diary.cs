using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLab.Data.Planning
{
    public class Diary
    {
        public string Name { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public TimeSpan Length { get { return EndTime - StartTime; } }

        public List<PlanningItem> PlanningItems { get; private set; } = new List<PlanningItem>();

        public Diary()
        {
        }

        public Diary(string name, DateTime startTime, DateTime endTime, List<PlanningItem> items)
        {
            this.Name = name;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.PlanningItems = items;
        }


        public void addList(List<PlanningItem> pi)
        {
            foreach (PlanningItem item in pi)
            {
                AddItem(item);
            }
        }

        public void AddItem(PlanningItem pi)
        {
            if (pi is ToDoItem)
            {
                addToDoItem(pi as ToDoItem);


            }
            else if (pi is Activity)
            {
                addActivity(pi as Activity);


            }
            else if (pi is RepeatingPlanningItem)
            {
                addRepeatingPlanningItem(pi as RepeatingPlanningItem);

            }
            else if (pi is Reflection)
            {
                addReflection(pi as Reflection);
            }

        }

        private void addToDoItem(ToDoItem tdi)
        {
            if (tdi.CompletedAt != null)
                PlanningItems.Add(tdi);
        }

        private void addActivity(Activity act) {
            PlanningItems.Add(act);
        }

        private void addReflection(Reflection reflect) {

        }

        private void addRepeatingPlanningItem(RepeatingPlanningItem rpItem)
        {
            DateTime start = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, rpItem.Time.Hours, rpItem.Time.Minutes, rpItem.Time.Seconds);

            while (start < EndTime)
            {
                
                addActivity(new Activity(rpItem.Name, ((Activity)rpItem.Item).Description, start, start));
                start.AddDays(1);
            }

        }

        public static Diary CreateDiary(Plan plan, string diaryName, DateTime start, DateTime end, Type[] types) {

            List<PlanningItem> items = plan.AllItems;
            List<PlanningItem> newItems = new List<PlanningItem>();
            
            // Add all items in that timeframe
            items.AddRange(items.Where(i => i is Activity).Cast<Activity>().Where(activity => activity.Start > start && activity.Start < end).Cast<PlanningItem>().ToList());
            items.AddRange(items.Where(i => i is Reflection).Cast<Reflection>().Where(reflection => reflection.Time > start && reflection.Time < end).Cast<PlanningItem>().ToList());
            items.AddRange(items.Where(i => i is ToDoItem).Cast<ToDoItem>().Where(todoitems => todoitems.CompletedAt > start && todoitems.CompletedAt < end).Cast<PlanningItem>().ToList());

            return new Diary(diaryName, start, end, newItems);

        }
        



    }
}
