using Abp.Authorization;
using CompanyManagement.Authorization.Roles;
using CompanyManagement.Authorization.Users;

namespace CompanyManagement.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
