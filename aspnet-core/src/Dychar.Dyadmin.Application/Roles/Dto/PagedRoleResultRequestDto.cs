using Abp.Application.Services.Dto;

namespace Dychar.Dyadmin.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

