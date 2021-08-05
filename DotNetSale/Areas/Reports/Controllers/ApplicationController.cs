using Microsoft.AspNetCore.Mvc;

namespace DotNetSale.Areas.Reports.Controllers
{
    [Area("Reports")]
    public class ApplicationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Review()
        {
            return View();
        }
    }
}
