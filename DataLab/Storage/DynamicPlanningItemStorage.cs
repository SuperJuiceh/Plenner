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

        public DynamicPlanningItemStorage(PlanningItemStorage item, User user): base()
        {
            CurrentUser = user;

            this.plan = user.plan;
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
            base.addActivity(a);

            OneWayPacket.addItemToUser(a);
        }

        public override void addDiary(Diary d)
        {
            base.addDiary(d);

            OneWayPacket.addItemToUser(d);
        }

        public override void addPlanningItem(PlanningItem pi)
        {
            base.addPlanningItem(pi);

            OneWayPacket.addItemToUser(pi);
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
