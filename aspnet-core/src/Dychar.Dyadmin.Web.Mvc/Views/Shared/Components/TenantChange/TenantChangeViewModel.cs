using Abp.AutoMapper;
using Dychar.Dyadmin.Sessions.Dto;

namespace Dychar.Dyadmin.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
