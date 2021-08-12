using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetNote.Controllers
{
    public class FormValidationDemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
