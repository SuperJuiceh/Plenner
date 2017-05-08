using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;
using System.Xml.Serialization;
using Windows.Storage.Streams;
using System.IO;

using System.Diagnostics;
using System.ComponentModel;
using DataLab.Data.Planning;
using DataLab.Data.Users;
using DataLab.Data.Cijfers;
using Windows.Storage;

namespace DataLab.Storage
{
    public class PlanningItemStorage : Storage, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        
        public Plan plan { get { return (Plan)StorageObject; } set { StorageObject = value; setChanged("plan"); } }
        
        public PlanningItemStorage() : base("plaren.pln", typeof(Plan))
        {
            //Task.Run(async () =>
            //{
            //    foreach (StorageFile sf in await ApplicationData.Current.LocalFolder.GetFilesAsync())
            //    {
            //        if (sf.Name.StartsWith("pl"))
            //        {
            //            await sf.DeleteAsync();
            //        }
            //    }
            //});
                
        }
        

        public virtual void addPlanningItem(PlanningItem pi)
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
            else if (piType == typeof(CijferLijst))
                addCijferLijst((CijferLijst)pi);

            saveStorage();
            
        }

        public virtual void removePlanningItem(PlanningItem pi)
        {
            Type piType = pi.GetType();

            if (piType == typeof(Activity))
                removeActivity((Activity)pi);
            else if (piType == typeof(Reflection))
                removeReflection((Reflection)pi);
            else if (piType == typeof(RepeatingPlanningItem))
                plan.rpi.Remove((RepeatingPlanningItem)pi);
            else if (piType == typeof(ToDoItem))
                removeToDoItem((ToDoItem)pi);
            else if (piType == typeof(ToDoItemSet))
                removeToDoItemSet((ToDoItemSet)pi);
            else if (piType == typeof(CijferLijst))
                removeCijferLijst((CijferLijst)pi);
        }

        public virtual void addCijferLijst(CijferLijst cLijst)
        {
            if (!plan.CijferLijsten.Contains(cLijst))
                plan.CijferLijsten.Add(cLijst);
        }

        public virtual void removeCijferLijst(CijferLijst cLijst)
        {
            plan.CijferLijsten.Remove(cLijst);
            saveStorage();
        }

        protected virtual void addActivity(Activity a)
        {
            plan.Activities.Add(a);
            saveStorage();
        }

        protected virtual void removeActivity(Activity a)
        {
            plan.Activities.Remove(a);
            saveStorage();
        }

        protected virtual void removeToDoItem(ToDoItem tdi)
        {
            plan.ToDoItems.Remove(tdi);
            saveStorage();
        }

        protected virtual void removeReflection(Reflection r)
        {
            r.deleteReflectionPhoto();
            plan.Reflections.Remove(r);

            saveStorage();
        }

        protected virtual void removeToDoItemSet(ToDoItemSet set)
        {
            plan.tdiSets.Remove(set);
            saveStorage();
        }

        public virtual void removeDiary(Diary d)
        {
            plan.Diaries.Remove(d);
            saveStorage();
        }

        public virtual void addDiary(Diary d)
        {
            plan.Diaries.Add(d);
            saveStorage();
        }
        
        public virtual void clear(Plan.Clear_Options options)
        {
            plan.clear(options);

            saveStorage();
        }

        public virtual void setChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        ~PlanningItemStorage()
        {
            if (PropertyChanged != null)
                PropertyChanged.GetInvocationList().ToList().ForEach(del => PropertyChanged -= (PropertyChangedEventHandler)del);

        }
    }
}
