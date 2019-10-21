using Abp.AspNetCore.Mvc.ViewComponents;

namespace Dychar.Dyadmin.Web.Views
{
    public abstract class DyadminViewComponent : AbpViewComponent
    {
        protected DyadminViewComponent()
        {
            LocalizationSourceName = DyadminConsts.LocalizationSourceName;
        }
    }
}
