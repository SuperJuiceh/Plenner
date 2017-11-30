using DataLab.Data.Planning;
using DataLab.Storage;
using DataLab.Tools;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Data.Tools.TimeFlow
{
    public class TimeFlow : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        
        private Plan Planning;

        private ObservableCollection<Activity> _timeLineActivities = new ObservableCollection<Activity>();
        private ObservableCollection<Reflection> _timeLineReflections = new ObservableCollection<Reflection>();
        private ObservableCollection<ToDoItem> _timeLineToDoItems = new ObservableCollection<ToDoItem>();

        public ObservableCollection<Activity> TimeLineActivities { get { return _timeLineActivities; } private set { TimeLineActivities = value; } }
        public ObservableCollection<Reflection> TimeLineReflections { get { return _timeLineReflections; } private set { _timeLineReflections = value; } }
        public ObservableCollection<ToDoItem> TimeLineToDoItems { get { return _timeLineToDoItems; } private set { _timeLineToDoItems = value; } }


        private bool _activitiesEnabled = true;
        public bool ActivitiesEnabled { get { return _activitiesEnabled && Constraints.AllowActivities; } set { _activitiesEnabled = value; Changed("ActivitiesEnabled"); } }

        private bool _reflectionsEnabled;

        public bool ReflectionsEnabled { get { return _reflectionsEnabled && Constraints.AllowReflections; } set { _reflectionsEnabled = value; Changed("ReflectionsEnabled"); } }

        private bool _todoitemsEnabled;

        public bool TodoitemsEnabled { get { return _todoitemsEnabled && Constraints.AllowToDoItems; } set { _todoitemsEnabled = value; Changed("TodoitemsEnabled"); } }
        public DateTime _filterDate { get; set; }

        public DateTime FilterDate { get { return _filterDate; } set { _filterDate = value; Changed("FilterDate"); } }

        // Unchangable Constraints, only set once
        private readonly TimeFlowConstraints Constraints = new TimeFlowConstraints(true, true, true);

        public TimeFlow(bool activitiesEnabled, bool reflectionsEnabled, bool todoitemsEnabled, DateTime Day, Plan plan, TimeFlowConstraints constraints)
        {
            this._activitiesEnabled = activitiesEnabled;
            this._reflectionsEnabled = reflectionsEnabled;
            this._todoitemsEnabled = todoitemsEnabled;

            this.FilterDate = Day;
            this.Planning = plan;
            this.Constraints = constraints;

            configLists();
        }

        public TimeFlow(DateTime Day, Plan plan, TimeFlowConstraints constraints): this(true, true, true, Day, plan, constraints)
        {
            
        }

        public void configLists()
        {
            if (Planning != null)
            {
                this._timeLineActivities?.Clear();

                if (_activitiesEnabled)
                    Planning.Activities?.Where(pi => pi.Start.IsSameDay(this._filterDate)).ToList().ForEach(pi => _timeLineActivities?.Add(pi));

                this._timeLineReflections?.Clear();

                if (_reflectionsEnabled)
                    Planning.Reflections?.Where(pi => pi.Start.IsSameDay(this._filterDate)).ToList().ForEach(pi => _timeLineReflections?.Add(pi));

                this._timeLineToDoItems?.Clear();

                if (_todoitemsEnabled)
                    Planning.ToDoItems?.Where(pi => pi.End.IsSameDay(this._filterDate)).ToList().ForEach(pi => {
                        _timeLineToDoItems?.Add(pi);
                });
                
            }
            
        }


        public void Changed(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
             
            configLists();
        }

        

        private TimeFlow()
        {

        }


    }

    public class TimeFlowConstraints
    {
        public bool AllowActivities { get; private set; }
        public bool AllowReflections { get; private set; }
        public bool AllowToDoItems { get; private set; }

        public TimeFlowConstraints(bool allowAct, bool allowReflect, bool allowToDo)
        {
            this.AllowActivities = allowAct;
            this.AllowReflections = allowReflect;
            this.AllowToDoItems = allowToDo;
        }

        public static TimeFlowConstraints AllowAll()
        {
            return new TimeFlowConstraints(true, true, true);
        }
    }
}
