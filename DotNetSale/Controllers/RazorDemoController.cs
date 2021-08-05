using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetSale.Controllers
{
    public class RazorDemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
