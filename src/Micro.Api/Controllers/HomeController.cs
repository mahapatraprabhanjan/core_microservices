using Microsoft.AspNetCore.Mvc;

namespace Micro.Api.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Get() => Content("Hello from Micro API!");
    }
}