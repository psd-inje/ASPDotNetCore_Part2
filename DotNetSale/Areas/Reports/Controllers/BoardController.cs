using Microsoft.AspNetCore.Mvc;

namespace DotNetSale.Areas.Reports.Controllers
{
    [Area("Reports")]
    public class BoardController : Controller
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
