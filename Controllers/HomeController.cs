using Microsoft.AspNetCore.Mvc;
namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        // Requests
        [HttpGet("")]
        public IActionResult Main()
        {
            // Views/Home/Main.cshtml
            // Views/Shared/Main.cshtml
            // If argument is provided then it will search for the argument as a cshtml file.
            return View();
        }

        [HttpGet("projects")]
        public IActionResult projects()
        {
            return View();
        }
        [HttpGet("contact")]
        public IActionResult contacts()
        {
            return View();
        }
    }
}