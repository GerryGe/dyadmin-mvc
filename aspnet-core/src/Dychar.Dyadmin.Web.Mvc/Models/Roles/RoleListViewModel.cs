using System.Collections.Generic;
using Dychar.Dyadmin.Roles.Dto;

namespace Dychar.Dyadmin.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleListDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
