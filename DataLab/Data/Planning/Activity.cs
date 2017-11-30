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
        public Geopoint LocationAsGeopoint { get { return new Geopoint(Location); } }
        public BasicGeoposition Location { get; set; }

        [XmlIgnore]
        public TimeSpan ActivityLength { get { return End - Start; } }
        
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
            this.Location = bgp;
        }

        private Activity() {
            
        }

        public void setGeoFence()
        {
            FenceItem fenceItem = new FenceItem(Name, Location);
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


        public int Compare(object x, object y)
        {
            throw new NotImplementedException();
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

}
