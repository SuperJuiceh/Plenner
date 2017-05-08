using DataLab.Data.Cijfers.CijferTaak;
using DataLab.Data.Planning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataLab.Data.Cijfers
{
    public class CijferLijst: PlanningItem
    {
        [XmlArray("Periodes"), XmlArrayItem(typeof(CijferPeriode), ElementName = "CijferPeriode")]
        public List<CijferPeriode> Periodes { get; set; } = new List<CijferPeriode>();
        //  int[0] van de int[1] punten (Ex. 7/10)

        public DateTime Start {  get { return Periodes.Select(p => p.Start).OrderBy(x => x).First(); } }

        public DateTime End { get { return Periodes.Select(p => p.End).OrderBy(x => x).First(); } }


        public CijferLijst(string name, params CijferPeriode[] periodes)
        {
            this.Name = name; 
            periodes.ToList().ForEach(periode => Periodes.Add(periode));
        }

        public CijferLijst()
        {

        }
        [XmlIgnore]
        public bool IsCompleted
        {
            get
            {
                foreach (CijferPeriode t in Periodes)
                {
                    if (!t.IsCompleted)
                        return false;
                }

                return true;
            }
            
        }

        public int[] GetBehaaldePunten() {
            return new int[] { 1, 2 };
        }



        public override bool Equals(object obj)
        {
            CijferLijst cijferlijst2 = obj as CijferLijst;

            if (cijferlijst2 != null)
                return this.Name.Equals(cijferlijst2.Name);

            return false;
        }

    }
}
