using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Dychar.Dyadmin.Controllers
{
    public abstract class DyadminControllerBase: AbpController
    {
        protected DyadminControllerBase()
        {
            LocalizationSourceName = DyadminConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
