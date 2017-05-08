using System.Xml.Serialization;

namespace DataLab.Data.Cijfers.CijferTaak
{
    public class Cijfer
    {
        [XmlIgnore]
        private int _punt;

        public int Punt { get { return _punt; } set { _punt = value; } }
                
        public Cijfer(int punt)
        {
            this._punt = punt;
        }

        public Cijfer()
        {

        }

        public override string ToString()
        {
            return _punt.ToString();
        }


    }
}