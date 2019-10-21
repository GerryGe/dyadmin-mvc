using Abp.Authorization;
using Dychar.Dyadmin.Authorization.Roles;
using Dychar.Dyadmin.Authorization.Users;

namespace Dychar.Dyadmin.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
