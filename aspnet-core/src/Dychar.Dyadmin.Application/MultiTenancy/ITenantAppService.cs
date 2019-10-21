using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Dychar.Dyadmin.MultiTenancy.Dto;

namespace Dychar.Dyadmin.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

