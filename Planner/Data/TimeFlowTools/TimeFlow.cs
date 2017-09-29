using DataLab.Data.Planning;
using DataLab.Tools;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Data.TimeFlowTools
{
    public class TimeFlow : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;


        public ObservableCollection<PlanningItem> _planningItems;

        private ObservableCollection<Activity> _timeLineActivities = new ObservableCollection<Activity>();
        private ObservableCollection<Reflection> _timeLineReflections = new ObservableCollection<Reflection>();
        private ObservableCollection<ToDoItem> _timeLineToDoItems = new ObservableCollection<ToDoItem>();

        public ObservableCollection<Activity> TimeLineActivities { get { return _timeLineActivities; } private set { TimeLineActivities = value; } }
        public ObservableCollection<Reflection> TimeLineReflections { get { return _timeLineReflections; } private set { _timeLineReflections = value; } }
        public ObservableCollection<ToDoItem> TimeLineToDoItems { get { return _timeLineToDoItems; } private set { _timeLineToDoItems = value; } }


        private bool _activitiesEnabled = true;
        public bool ActivitiesEnabled { get { return _activitiesEnabled; } set { _activitiesEnabled = value; Changed("ActivitiesEnabled"); } }

        private bool _reflectionsEnabled;

        public bool ReflectionsEnabled { get { return _reflectionsEnabled; } set { _reflectionsEnabled = value; Changed("ReflectionsEnabled"); } }

        private bool _todoitemsEnabled;

        public bool TodoitemsEnabled { get { return _todoitemsEnabled; } set { _todoitemsEnabled = value; Changed("TodoitemsEnabled"); } }

        public DateTime FilterDate { get; set; }


        public TimeFlow(bool activitiesEnabled, bool reflectionsEnabled, bool todoitemsEnabled, DateTime Day, List<PlanningItem> items)
        {
            this._activitiesEnabled = activitiesEnabled;
            this._reflectionsEnabled = reflectionsEnabled;
            this._todoitemsEnabled = todoitemsEnabled;
            this.FilterDate = Day;

            if (items == null)
                throw new ArgumentNullException("TimeFlow Constructor: Items list is null");

            configLists(items);
        }

        public void configLists(List<PlanningItem> items)
        {
            items.Sort(PlanningItem.CompareByTime);

            this._planningItems = new ObservableCollection<PlanningItem>(items);

            List<Activity> activitiesList = items.Where((PlanningItem pi) => pi is Activity && pi.Start.IsSameDay(DateTime.Now)).Select(i => i as Activity).ToList();
            List<ToDoItem> todoitemsList = items.Where((PlanningItem pi) => pi is ToDoItem && pi.Start.IsSameDay(DateTime.Now)).Select(i => i as ToDoItem).ToList();
            List<Reflection> reflectionsList = items.Where((PlanningItem pi) => pi is Reflection && pi.Start.IsSameDay(DateTime.Now)).Select(i => i as Reflection).ToList();
            
            this._timeLineActivities?.Clear();

            if (_activitiesEnabled)
                activitiesList.ForEach((Activity a) => _timeLineActivities.Add(a));

            this._timeLineReflections?.Clear();

            if (_reflectionsEnabled)
                reflectionsList.ForEach((Reflection r) => _timeLineReflections.Add(r));

            this._timeLineToDoItems?.Clear();

            if (_todoitemsEnabled)
                todoitemsList.ForEach((ToDoItem td) => _timeLineToDoItems.Add(td));

        }


        public void Changed(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        

        private TimeFlow()
        {

        }


    }
}
