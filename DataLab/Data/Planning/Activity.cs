using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;
using System.Xml.Serialization;
using System.IO;

using System.ComponentModel;

using DataLab.Data.Planning;
using Windows.Devices.Geolocation;
using System.Collections;

namespace DataLab.Data.Planning
{
    [XmlRoot("Activity")]
    public class Activity: PlanningItem, TimeSpanPlanning
    {
        [XmlIgnore]
        private DateTime _start;

        public DateTime Start { get { return _start; } set { _start = value; Changed("Start"); } }
        [XmlElement("Description")]
        private string description;
        [XmlIgnore]
        public string Description { get { return description; } set { description = value; Changed("Description"); } }
        [XmlIgnore]
        public Geopoint Location { get { return new Geopoint(basicgeoloc); } }
        public BasicGeoposition basicgeoloc { get; set; }

        [XmlIgnore]
        public TimeSpan ActivityLength { get { return End - Start; } }
        
        public DateTime End { get; set; }

        public Activity(string name, string description, DateTime s, DateTime e): base(name)
        {
            this.Name = name;
            this.Description = description;
            this.Start = s;
            this.End = e;
        }

        public Activity(string name, string description, DateTime s, DateTime e, BasicGeoposition bgp) : base(name)
        {
            this.Name = name;
            this.Description = description;
            this.Start = s;
            this.End = e;
            this.basicgeoloc = bgp;
        }

        public Activity() {
            
        }

        public override bool Equals(object obj)
        {

            Activity item = obj as Activity;

            if (item != null)
            {
                if (item.Name != null && this.Name != null && item.Start != null && this.Start != null && this.Description != null && item.Description != null)
                {
                    return item.Name.Equals(this.Name) && item.Start.Equals(this.Start) && item.Description.Equals(this.Description);
                }
                else if (item.Name != null && this.Name != null && this.Description != null && item.Description != null)
                {
                    return item.Name.Equals(this.Name) && item.Description.Equals(this.Description);
                }
                else if (item.Name != null && this.Name != null)
                {
                    return item.Name.Equals(this.Name);
                }
            }

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        internal void ChangedAll()
        {
            if (Name != null)
                Changed("Name");
            if (Description != null)
                Changed("Description");
        }
    }

    public sealed class ComparatorActivityName: IComparer
    {
        
        int IComparer.Compare(object x, object y)
        {
            Activity a = x as Activity;
            Activity b = y as Activity;

            if (a != null && b != null)
            {
                return a.Name.CompareTo(b.Name);
                
            }

            if (a == null)
                throw new Exception("A is null or not an activity");
            else
                throw new Exception("B is null or not an activity");

        }
    }

    public sealed class ComparatorActivityTime : IComparer
    {

        int IComparer.Compare(object x, object y)
        {
            Activity a = x as Activity;
            Activity b = y as Activity;

            if (a != null && b != null)
            {
                return a.Start.CompareTo(b.Start);

            }

            if (a == null)
                throw new Exception("A is null or not an activity");
            else
                throw new Exception("B is null or not an activity");

        }
    }
}
