using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static DataLab.Data.Users.Contracts.PlanningContract;

namespace DataLab.Data.Users.Contracts
{
    public class ContractManager
    {

        [XmlArray("Contracts"), XmlArrayItem(typeof(object), ElementName = "Contract")]
        public List<object> ContractObjects { get { return Contracts.Cast<object>().ToList(); } set { value.ForEach(ob => Contracts.Add(ob as Contract)); } }

        [XmlIgnore]
        public List<Contract> Contracts { get; set; } = new List<Contract>();

        public ContractManager()
        {
        }

        public bool addContract(Contract newContract)
        {
            Contracts.Add(newContract);

            return true;
        }
        
        public bool addPermission(object permission, User from, User to)
        {
            
            if (permission is PlanningContract.PlanningPermissionsEnum)
            {
                PlanningPermissionsEnum perm = (PlanningPermissionsEnum)permission;

                if (!hasPermission(to, from, permission))
                {
                    PlanningContract pContract = Contracts.Where(contr => contr is PlanningContract && contr.PermissionsGrantedToUser == to && contr.TargetUser == from) as PlanningContract;

                    if (pContract != null)
                    {
                        pContract.Perms.Add(perm);
                    }

                    //Contracts.First(contract => contract.hasAccess(to, from, permission));
                    return true;
                }
            }

            return false;
        }

        public void createContractForUser(User from, User to)
        {
            // Do the users have a contract already?
            if (Contracts.Find(cntr => cntr.TargetUser == from && cntr.PermissionsGrantedToUser == to) == null)
            {
                addContract(new PlanningContract(from, to));
            }
        }

        public bool hasPermission(User TargetUser, User PermissionHolderUser, object Permission)
        {
            return Contracts.Find(c => c.hasAccess(TargetUser, PermissionHolderUser, Permission)) != null;
        }

        public Tuple<bool, Contract> getContractBetween(User from, User to)
        {
            // First result: Did we find anything?
            // Second result: Contract
            return new Tuple<bool, Contract>(
                Contracts.Exists(contract => contract.TargetUser == from && contract.PermissionsGrantedToUser == to),
                Contracts.First(contract => contract.TargetUser == from && contract.PermissionsGrantedToUser == to)
            );
        }


    }
}
