using Microsoft.AspNetCore.Mvc;
using ErrorHandling.Web.Services;

namespace ErrorHandling.Web.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/throw")]
        public IActionResult Throw()
        {
            throw new Exception("This is a test exception.");
        }

        [HttpGet("/slow")]
        public async Task<IActionResult> Slow()
        {
            var service = new SlowService();
            await service.DoSlowWorkAsync();
            return View();
        }
    }
}
