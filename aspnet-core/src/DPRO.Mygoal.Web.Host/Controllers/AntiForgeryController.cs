using DPRO.Mygoal.Controllers;
using Microsoft.AspNetCore.Antiforgery;

namespace DPRO.Mygoal.Web.Host.Controllers
{
    public class AntiForgeryController : MygoalControllerBase
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