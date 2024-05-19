using System.Collections.Generic;
using CompanyManagement.Roles.Dto;

namespace CompanyManagement.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
