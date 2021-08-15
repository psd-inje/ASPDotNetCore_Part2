using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetSale.Controllers
{
    public class CkEditor4DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Index(string editor)
        {

            ViewBag.EditorText = editor;
            return View();
        }
    }
}
