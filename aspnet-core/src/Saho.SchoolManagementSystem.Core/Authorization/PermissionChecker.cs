using Abp.Authorization;
using Saho.SchoolManagementSystem.Authorization.Roles;
using Saho.SchoolManagementSystem.Authorization.Users;

namespace Saho.SchoolManagementSystem.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
