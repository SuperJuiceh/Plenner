using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataLab.Data.Cijfers.CijferTaak
{
    public class Cijfertaak
    {
        // Naam van de taak
        public string Name { get; set; }
        // Pogingen, uit te breiden
        [XmlArray("Attempts"), XmlArrayItem(typeof(Cijfer), ElementName = "Cijfer")]
        public List<Cijfer> Attempts { get; set; } = new List<Cijfer>();

        // Max te behalen punt
        [XmlIgnore]
        private double _maxTeBehalenPunt;

        public double MaxTeBehalenPunt { get { return _maxTeBehalenPunt; } set { _maxTeBehalenPunt = value; } }


        // Min te behalen punt
        [XmlIgnore]
        private double _minTeBehalenPunt;

        public double MinTeBehalenPunt { get { return _minTeBehalenPunt; } set { _minTeBehalenPunt = value; } }

        public Cijfertaak(string naam, double _minTeBehalenPunt, double _maxTeBehalenPunt)
        {
            this.Name = naam;
            this._maxTeBehalenPunt = _maxTeBehalenPunt;
            this._minTeBehalenPunt = _minTeBehalenPunt;
        }

        public Cijfertaak()
        {

        }

        // Returnt of de periode na de periode ook behaald is
        public bool addPoging(Cijfer cijfer)
        {
            // Poging toevoegen
            Attempts.Add(cijfer);

            return IsCompleted;
        }
        [XmlIgnore]
        public bool IsCompleted
        {
            get
            {
                // Er is een poging goed genoeg om dit als voldoende te rekenen?
                return Attempts.Exists(c => c.Punt >= _maxTeBehalenPunt);

            }
            
        }
        [XmlIgnore]
        public Cijfer HoogstePunt
        {
            get
            {
                int hoogstBehaaldePunt;
                // Wat is ons hoogste punt?
                try
                {
                    hoogstBehaaldePunt = Attempts.Max(c => c.Punt);
                } catch (Exception)
                {
                    // Geen cijfer, dus gewoon een 1.
                    return new Cijfer(1);
                }
            
                // laatste hoogste punt eruit halen en teruggeven
                return Attempts.Last(c => c.Punt == hoogstBehaaldePunt);
            }

        }
        [XmlIgnore]
        public string HoogstePuntAsString
        {
            get
            {
                int hoogstBehaaldePunt;
                // Wat is ons hoogste punt?
                try
                {
                    hoogstBehaaldePunt = Attempts.Max(c => c.Punt);
                }
                catch (Exception)
                {
                    // Geen cijfer, dus gewoon een 1.
                    return new Cijfer(1).ToString();
                }

                // laatste hoogste punt eruit halen en teruggeven
                return Attempts.Last(c => c.Punt == hoogstBehaaldePunt).ToString();
            }

        }

        public override bool Equals(object obj)
        {
            Cijfertaak taak2 = obj as Cijfertaak;

            if (taak2 != null)
            {
                return taak2.Name.Equals(this.Name);
            }

            return false;
        }

    }
}
