using System.Collections.Generic;
using CompanyManagement.Roles.Dto;

namespace CompanyManagement.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}