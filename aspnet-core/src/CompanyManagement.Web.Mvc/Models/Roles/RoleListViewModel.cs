using System.Collections.Generic;
using CompanyManagement.Roles.Dto;

namespace CompanyManagement.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
