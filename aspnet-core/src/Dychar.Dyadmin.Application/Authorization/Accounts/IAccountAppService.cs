using System.Threading.Tasks;
using Abp.Application.Services;
using Dychar.Dyadmin.Authorization.Accounts.Dto;

namespace Dychar.Dyadmin.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
