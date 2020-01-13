using Abp.Authorization;
using Ejec.Authorization.Roles;
using Ejec.Authorization.Users;

namespace Ejec.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
