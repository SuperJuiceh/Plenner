using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Serialization;

namespace DataLab.Data.Planning
{
    public class ToDoItemSet: ToDoItem
    {
        [XmlArray("ToDoItemSet"), XmlArrayItem(typeof(ToDoItem), ElementName = "ToDoItem")]
        public ObservableCollection<ToDoItem> Children { get; set; } = new ObservableCollection<ToDoItem>();
        [XmlIgnore]
        public override bool HasDeadline
        {
            get
            {
                return Children.Count(tdi => tdi.HasDeadline) > 0;
            }
        }
        [XmlIgnore]
        public override bool IsDone
        {
            get
            {
                return Children.All(tdi => tdi.IsDone);
            }

            set
            {
                Children.All(tdi => tdi.IsDone = true);
                Changed("IsDone");
            }
        }

        public override DateTime Deadline
        {
            get
            {
                try
                {
                    return Children.Max(d => d.Deadline);
                }
                catch (InvalidOperationException)
                {
                    return DateTime.Now;
                }
            }
            
        }

        public ToDoItemSet(string name, string description): base(name, description)
        {

        }

        public ToDoItemSet(): base()
        {

        }
    }
}
