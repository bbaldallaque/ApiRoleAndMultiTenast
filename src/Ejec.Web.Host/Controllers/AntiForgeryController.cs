using Microsoft.AspNetCore.Antiforgery;
using Ejec.Controllers;

namespace Ejec.Web.Host.Controllers
{
    public class AntiForgeryController : EjecControllerBase
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
