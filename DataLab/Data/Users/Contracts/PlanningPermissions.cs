using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLab.Server.Users.Contracts
{
    public class PlanningPermissions: Permissions
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
            
        }

        public override Type PermissionsType { get; set; } = typeof(PlanningPermissionsEnum);


        public override List<object> Perms
        {
            get
            {
                return base.Perms;
            }

            set
            {
                base.Perms = value;
            }
        }

        public PlanningPermissions(List<PlanningPermissions.PlanningPermissionsEnum> Perms)
        {
            this.Perms = Perms.Cast<object>().ToList();
        }

        public override bool hasPermission(object Permission)
        {
            try
            {
                PlanningPermissionsEnum perm = (PlanningPermissionsEnum)Permission;

                if (Perms.Cast<PlanningPermissionsEnum>().ToList().Contains(perm))
                    return true;
                
            }
            catch (InvalidCastException)
            {

            }

            return false;
        }

        public override List<object> getAllPermissionsAsList()
        {
            return Enum.GetValues(typeof(PlanningPermissions.PlanningPermissionsEnum)).Cast<object>().ToList();
        }
    }
}
