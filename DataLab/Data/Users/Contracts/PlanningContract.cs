using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLab.Data.Users.Contracts
{
    public class PlanningContract: Contract, Permission
    {
        public enum PlanningPermissionsEnum
        {

            READ_ACTIVITIES,
            WRITE_ACTIVITIES,
            DELETE_ACTIVITIES,
            READ_TODOITEMS,
            WRITE_TODOITEMS,
            DELETE_TODOITEMS,
            READ_REFLECTIONS,
            WRITE_REFLECTIONS,
            DELETE_REFLECTIONS,
            READ_DIARIES,
            WRITE_DIARIES,
            DELETE_DIARIES,
            VIEW_HISTORY

        }

        public User TargetUser { get; set; }
        public User PermissionsGrantedToUser { get; set; }

        public List<PlanningPermissionsEnum> Perms { get; set; }

        public PlanningContract(User TargetUser, User PermissionsGrantedToUser)
        {
            this.TargetUser = TargetUser;
            this.PermissionsGrantedToUser = PermissionsGrantedToUser;
        }

        public PlanningContract(User TargetUser, User PermissionsGrantedToUser, List<PlanningPermissionsEnum> Permissions): this(TargetUser, PermissionsGrantedToUser)
        {
            this.Perms = Permissions;
        }

        public PlanningContract() {

        }
        
        public static PlanningContract CreateFullPermissionsPlanningContract(User TargetUser, User PermissionsGrantedToUser) {
            // Return a contract with all permissions
            PlanningContract contract = new PlanningContract();
            contract.TargetUser = TargetUser;
            contract.PermissionsGrantedToUser = PermissionsGrantedToUser;

            return contract;
        }

        public bool hasAccess(User TargetUser, User PermissionsGrantedToUser, object Permission)
        {
            try
            {
                PlanningPermissionsEnum perm = (PlanningPermissionsEnum)Permission;
                return (TargetUser.Equals(this.TargetUser)) && PermissionsGrantedToUser.Equals(this.PermissionsGrantedToUser) && Perms.Contains(perm);
            }
            catch (InvalidCastException) { }
            
            return false;
        }

        public object[] getAllChoices()
        {
            return Enum.GetValues(typeof(PlanningPermissionsEnum)).Cast<object>().ToArray();
        }
    }


    public class SelectPermission
    {

        public string Name { get; set; }
        public bool CanRead { get; set; }
        public bool CanWrite { get; set; }
        public bool CanDelete { get; set; }

    }
}
