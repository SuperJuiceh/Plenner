using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;
using System.Xml.Serialization;

namespace DataLab.Data.Planning
{
    [XmlRoot("RepeatingPlanningItem")]
    public class RepeatingPlanningItem: PlanningItem
    {
        [XmlElement("Item")]
        public PlanningItem Item { get; set; }
        [XmlArray("Days"), XmlArrayItem(typeof(DayOfWeek), ElementName = "DayOfWeek")]
        public List<DayOfWeek> Days { get; set; } = new List<DayOfWeek>();
        [XmlElement("Time")]
        public TimeSpan Time { get; set; }
        [XmlIgnore]
        public new string Name { get { return Item.Name; } set { setName(value);  } }

        public RepeatingPlanningItem(PlanningItem item, List<DayOfWeek> days, TimeSpan DayTime)
        {
            this.Item = item;
            this.Days = days;
            this.Time = DayTime;
        }

        private RepeatingPlanningItem()
        {
            
        }

        private void setName(string value)
        {
            if (Item != null)
                Item.Name = value;
        }

    }
}
