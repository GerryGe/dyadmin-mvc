using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace Dychar.Dyadmin.Web.Views
{
    public abstract class DyadminRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected DyadminRazorPage()
        {
            LocalizationSourceName = DyadminConsts.LocalizationSourceName;
        }
    }
}
