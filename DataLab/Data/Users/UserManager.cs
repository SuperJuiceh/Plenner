using DataLab.Server.Packets;
using DataLab.Data.Planning;
using DataLab.Data.Users.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataLab.Data.Users
{
    public class UserManager
    {
        // All our users
        [XmlArray("Users"), XmlArrayItem(typeof(User), ElementName = "User")]
        public List<User> Users { get; set; } = new List<User>();
        [XmlIgnore]
        // List with user permissions
        public ContractManager PermissionMan { get; set; } = new ContractManager();

        public enum Registration_Answer { SUCCEEDED, USERNAME_TAKEN, UNKNOWN }

        public UserManager()
        {
            //Users.Add(new User("Ok", "hDrAEUnM7Xhd/r0AKNOwO6eOKG4cb5UX6/zbYJ2Xr0w="));
        }

        public Registration_Answer addUser(User newUser)
        {
            if (!userExists(newUser.UserName))
            {
                Users.Add(newUser);
                return Registration_Answer.SUCCEEDED;
            } else
            {
                return Registration_Answer.USERNAME_TAKEN;
            }
            

        }

        public bool addPermission(Contract contract)
        {
            // Check if both users exist
            if (Users.Exists(u => u.Equals(contract.PermissionsGrantedToUser)) && Users.Exists(u => u.Equals(contract.TargetUser))){
                PermissionMan.addContract(contract);
                return true;
            }

            return false;
        }

        public bool userExists(string name)
        {
            return Users.Exists(u => u.UserName == name);

        }


        public User getUser(string name)
        {
            return Users.First(user => user.UserName == name);
        }
                
    }
}
