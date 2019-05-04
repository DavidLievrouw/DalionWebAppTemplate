using Dalion.WebAppTemplate.Constraints;
using Dalion.WebAppTemplate.Filters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Dalion.WebAppTemplate.Controllers {
    [AllowAnonymous]
    [Route("")]
    public class DefaultController : Controller {
        [HttpGet("{*url}")]
        [GetSpaActionConstraint]
        [IsSpaView]
        [ReportsApplicationInfo]
        public IActionResult Index(string url) {
            return View();
        }
    }
}