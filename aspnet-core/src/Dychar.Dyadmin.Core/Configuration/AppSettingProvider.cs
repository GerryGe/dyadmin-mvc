using System.Collections.Generic;
using Abp.Configuration;

namespace Dychar.Dyadmin.Configuration
{
    public class AppSettingProvider : SettingProvider
    {
        public override IEnumerable<SettingDefinition> GetSettingDefinitions(SettingDefinitionProviderContext context)
        {
            return new[]
            {
                //Default skin
                new SettingDefinition(AppSettingNames.UiTheme, "skin-blue", scopes: SettingScopes.Application | SettingScopes.Tenant | SettingScopes.User, isVisibleToClients: true)
            };
        }
    }
}
