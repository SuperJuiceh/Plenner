using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLab.Data.Users.Contracts
{
    public interface Contract
    {
        User TargetUser { get; set; }
        User PermissionsGrantedToUser { get; set; }
        bool hasAccess(User TargetUser, User PermissionsGrantedToUser, object Permission);
    }
}
