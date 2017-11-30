using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;
using System.Xml.Serialization;

namespace DataLab.Data.Planning
{
    [XmlRoot("PlanningItem")]
    public class PlanningItem: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [XmlAttribute("Name")]
        public string Name { get; set; } = "";

        // Silent notification?
        [XmlAttribute("Silent")]
        public bool Silent { get; set; }
        
        [XmlAttribute("MinutesToAlertBeforeActualAlarm")]
        public int MinutesToAlertBeforeActualAlarm { get; set; }

        [XmlIgnore]
        private string description;

        public string Description { get { return description; } set { description = value; Changed("Description"); } }

        [XmlIgnore]
        private DateTime _start;

        public DateTime Start { get { return _start; } set { _start = value; Changed("Start"); } }

        public DateTime _end { get; set; }

        public DateTime End { get { return _end; } set { _end = value; Changed("Start"); } }

        public PlanningItem(string name)
        {
            this.Name = name;
        }

        protected PlanningItem()
        {

        }

        public void Changed(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        public override bool Equals(object obj)
        {
            PlanningItem item = obj as PlanningItem;

            if (item != null && item.Name != null && this.Name != null)
            {
                return item.Name.Equals(this.Name);
            }

            return false;
        }

        ~PlanningItem()
        {
            if (PropertyChanged != null)
            {
                foreach (Delegate del in PropertyChanged.GetInvocationList())
                {
                    PropertyChanged -= (PropertyChangedEventHandler)del;
                }
            }

        }
        
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        
        public static Comparison<PlanningItem> CompareByTime = delegate(PlanningItem x, PlanningItem y) 
        {
            return x.Start.CompareTo(y.Start);

        };

        public static Comparison<PlanningItem> CompareByName = delegate (PlanningItem x, PlanningItem y)
        {
            return x.Name.CompareTo(y.Name);

        };
        
        public bool isOfType<T>() where T : PlanningItem
        {
            try
            {
                T a = (T)this;

                return true;
            }
            catch (InvalidCastException)
            {
                return false;
            }
        }
    }

    public class PlanningItemList: ObservableCollection<PlanningItem>
    {
        public PlanningItemList()
        {
            
        }

        public void Order()
        {

        }
    }
}
