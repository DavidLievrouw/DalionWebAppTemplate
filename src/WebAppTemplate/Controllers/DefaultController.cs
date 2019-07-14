using Dalion.WebAppTemplate.Filters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Dalion.WebAppTemplate.Controllers {
    [AllowAnonymous]
    [Route("")]
    public class DefaultController : Controller {
        [HttpGet("")]
        [HttpGet("login")]
        [HttpGet("logout")]
        [HttpGet("profile")]
        [HttpGet("swaggerui")]
        [HttpGet("apinav")]
        [IsSpaView]
        [ReportsApplicationInfo]
        public IActionResult Index(string url) {
            return View();
        }
    }
}