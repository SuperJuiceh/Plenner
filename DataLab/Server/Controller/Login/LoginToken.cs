using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataLab.Server.Controller.Login
{
    [XmlRoot("LoginToken")]
    public class LoginToken: Token
    {
        public string UserName { get; set; }

        public string DeviceID { get; set; }

        public LoginToken(int ID, TimeSpan leaseTime, string username, string deviceID): base(ID, leaseTime, deviceID)
        {

        }

        public LoginToken():base() { }

        
    }
}
