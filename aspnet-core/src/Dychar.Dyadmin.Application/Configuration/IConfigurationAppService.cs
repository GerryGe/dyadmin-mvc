using System.Threading.Tasks;
using Dychar.Dyadmin.Configuration.Dto;

namespace Dychar.Dyadmin.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
