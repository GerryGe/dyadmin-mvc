using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Dychar.Dyadmin.Configuration.Dto;

namespace Dychar.Dyadmin.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : DyadminAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
