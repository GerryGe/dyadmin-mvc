using System.Collections.Generic;
using Dychar.Dyadmin.Roles.Dto;

namespace Dychar.Dyadmin.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}