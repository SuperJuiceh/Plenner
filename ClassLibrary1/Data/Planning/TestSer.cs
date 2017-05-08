using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataLab.Data.Planning
{
    [XmlRoot("TestSer")]
    public class TestSer
    {
        
        public string Name { get; set; }

        public TestSer()
        {
            Name = "hallo";
        }
        
    }
}
