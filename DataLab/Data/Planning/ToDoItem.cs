using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;
using System.Xml.Serialization;

namespace DataLab.Data.Planning
{
    [XmlRoot("ToDoItem")]
    public class ToDoItem: PlanningItem, IComparer<ToDoItem>
    {
        [XmlAttribute("IsDone")]
        public virtual bool IsDone { get; set; }
        [XmlAttribute("Deadline")]
        public virtual DateTime Deadline { get { return this.End; } set { End = value; }  }
        [XmlAttribute("CompletedAt")]
        public virtual DateTime CompletedAt { get; set; }
        [XmlAttribute("NotifySpanBeforeDeadline")]
        public virtual TimeSpan NotifySpanBeforeDeadline { get; set; }
        
        public virtual bool HasDeadline { get { return hasDeadline(); } }

        public ToDoItem(string name, string description, DateTime deadline): base(name)
        {
            this.Deadline = deadline;
            this.Description = description;
        }


        public ToDoItem(string name, string description) : base(name)
        {
            this.Description = description;
        }

        public ToDoItem(string name, string description, DateTime DeadLine, TimeSpan NotificationTime) : this(name, description)
        {
            this.Deadline                   =   DeadLine;
            this.NotifySpanBeforeDeadline   =   NotificationTime;
        }


        protected ToDoItem(): base()
        {

        }

        public void setCompleted()
        {
            CompletedAt = DateTime.Now;
            Changed("CompletedAt");
        }

        public int Compare(ToDoItem x, ToDoItem y)
        {
            return x.Name.CompareTo(y.Name);
        }

        public bool hasDeadline()
        {
            if (Deadline != null)
            {
                if (Deadline > new DateTime(2000, 1, 1, 0, 0, 0))
                {
                    return true;
                }

            }

            return false;
        }

        public override bool Equals(object obj)
        {

            ToDoItem item = obj as ToDoItem;

            if (item != null)
            {
                return item.Name.Equals(this.Name) && item.Deadline.Equals(this.Deadline);
            }

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    public class ToDoItemNameComparer
    {

    }
}
