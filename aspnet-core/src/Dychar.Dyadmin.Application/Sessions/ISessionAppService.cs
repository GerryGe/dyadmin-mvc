using System.Threading.Tasks;
using Abp.Application.Services;
using Dychar.Dyadmin.Sessions.Dto;

namespace Dychar.Dyadmin.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
