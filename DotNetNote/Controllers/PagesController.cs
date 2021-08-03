using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetNote.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome()
        {
            return View();
        }

        public IActionResult NotFoundPage()
        {
            return View();
        }

        public IActionResult NotAssinged()
        {
            return View();
        }

        public IActionResult Intro()
        {
            return View();
        }
    }
}
