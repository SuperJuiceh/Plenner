using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
