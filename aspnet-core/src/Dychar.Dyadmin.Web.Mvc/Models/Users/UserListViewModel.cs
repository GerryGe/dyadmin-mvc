using System.Collections.Generic;
using Dychar.Dyadmin.Roles.Dto;
using Dychar.Dyadmin.Users.Dto;

namespace Dychar.Dyadmin.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
