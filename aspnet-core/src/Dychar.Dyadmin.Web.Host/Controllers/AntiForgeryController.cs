using Microsoft.AspNetCore.Antiforgery;
using Dychar.Dyadmin.Controllers;

namespace Dychar.Dyadmin.Web.Host.Controllers
{
    public class AntiForgeryController : DyadminControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
