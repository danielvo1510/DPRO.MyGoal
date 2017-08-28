using Abp.Authorization;
using DPRO.Mygoal.Authorization.Roles;
using DPRO.Mygoal.Authorization.Users;

namespace DPRO.Mygoal.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
