using Microsoft.AspNetCore.Mvc;

namespace ErrorHandling.Web.Controllers
{
    public class ErrorController : Controller
    {
        [HttpGet("error/exception/server")]
        public IActionResult ServerError()
        {
            return View();
        }

        [HttpGet("error/exception/http/{statusCode}")]
        public IActionResult HttpError(int statusCode)
        {
            return View(statusCode);
        }

    }
}
