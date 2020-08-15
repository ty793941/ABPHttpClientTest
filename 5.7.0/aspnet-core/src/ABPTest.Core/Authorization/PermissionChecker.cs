using Abp.Authorization;
using ABPTest.Authorization.Roles;
using ABPTest.Authorization.Users;

namespace ABPTest.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
