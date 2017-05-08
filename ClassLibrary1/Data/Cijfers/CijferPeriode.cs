using DataLab.Data.Cijfers.CijferTaak;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Xml.Serialization;

namespace DataLab.Data.Cijfers
{
    public class CijferPeriode
    {

        public string Name { get; set; }
        [XmlArray("ToComplete"), XmlArrayItem(typeof(Cijfertaak), ElementName = "Cijfertaak")]
        public ObservableCollection<Cijfertaak> ToComplete { get; set; } = new ObservableCollection<Cijfertaak>();

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public CijferPeriode(string name, DateTime start, DateTime end, params Cijfertaak[] taken)
        {
            this.Name = name;
            this.Start = start;
            this.End = end;

            taken.ToList().ForEach(taak => ToComplete.Add(taak));
        }

        public CijferPeriode()
        {

        }
        [XmlIgnore]
        public bool IsCompleted
        {
            get
            {
                foreach (Cijfertaak t in ToComplete)
                {
                    if (!t.IsCompleted)
                        return false;
                }

                return true;
            }

        }

        public override bool Equals(object obj)
        {
            CijferPeriode periode2 = obj as CijferPeriode;

            if (periode2 != null)
                return this.Name.Equals(periode2.Name);

            return false;
        }

    }
}