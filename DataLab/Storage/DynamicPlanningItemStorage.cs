using DataLab.Data.Planning;
using DataLab.Data.Users;
using DataLab.Server.Packets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLab.Storage
{
    public class DynamicPlanningItemStorage: PlanningItemStorage
    {
        
        private User _currentUser = null;

        public User CurrentUser { get { return _currentUser; } set { _currentUser = value; setChanged("CurrentUser"); } }

        public bool LoggedIn { get { return _currentUser != null; } }

        public override Plan plan { get { return CurrentUser.plan; } set { CurrentUser.plan = value; setChanged("plan"); } }


        public DynamicPlanningItemStorage(PlanningItemStorage item, User user): base()
        {
            CurrentUser = user;
        }

        private void setCurrentPlan(Plan value)
        {
            if (CurrentUser != null)
                CurrentUser.plan = value;

            this.StorageObject = value;

            setChanged("plan");
        }

        private Plan getCurrentPlan()
        {
            if (CurrentUser != null)
                return CurrentUser.plan;
            else
                return (Plan)StorageObject;
        }

        protected override void addActivity(Activity a)
        {
            plan.Activities.Add(a);

            OneWayPacket.addItemToUser(a);
        }

        public override void addDiary(Diary d)
        {
            plan.Diaries.Add(d);

            OneWayPacket.addItemToUser(d);
        }

        public override void addPlanningItem(PlanningItem pi)
        {
            Type piType = pi.GetType();

            //Debug.WriteLine("Tring to add and size is now {0}", plan.Activities.Count);

            if (piType == typeof(RepeatingPlanningItem))
            {
                plan.rpi.Add((RepeatingPlanningItem)pi);
            }
            else if (piType == typeof(ToDoItem))
            {
                plan.ToDoItems.Add((ToDoItem)pi);
            }
            else if (piType == typeof(ToDoItemSet))
            {
                plan.tdiSets.Add((ToDoItemSet)pi);
            }
            else if (piType == typeof(Reflection))
            {
                plan.Reflections.Add((Reflection)pi);
            }
            else if (piType == typeof(Activity))
            {
                plan.Activities.Add((Activity)pi);
            }
            
        }

        public override void removeDiary(Diary d)
        {
            plan.Diaries.Add(d);
        }

        public override void clear(Plan.Clear_Options options)
        {
            base.clear(options);

            OneWayPacket.addItemToUser("CLEAR");
        }

        protected override void removeActivity(Activity a)
        {
            base.removeActivity(a);

            OneWayPacket.addItemToUser("REMOVE "+ a.Name);
        }

        public override bool isDynamic()
        {
            return true;
        }


    }
}
