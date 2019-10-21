using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Dychar.Dyadmin.Controllers;

namespace Dychar.Dyadmin.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : DyadminControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
