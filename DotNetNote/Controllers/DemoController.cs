using Microsoft.AspNetCore.Mvc;

namespace DotNetNote.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            //return Content("Demo Pate");
            return View();
        }

        public IActionResult RazorDemo()
        {
            //return Content("Demo Pate");
            return View();
        }
    }
}
