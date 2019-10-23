using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using Dychar.Dyadmin.Authorization;
using Dychar.Dyadmin.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Dychar.Dyadmin.Web.Mvc.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Tenant_Dashboard)]
    public class DashboardController : DyadminControllerBase
    {
        public IActionResult Index()
        {
            return View("Home");
        }
    }
}