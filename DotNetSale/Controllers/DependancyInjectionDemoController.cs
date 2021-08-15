using DotNetSale.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetSale.Controllers
{
    public class DependancyInjectionDemoController : Controller
    {

        //private readonly CopyrightService _svc;
        private readonly ICopyrightService _service1;
        private readonly ICopyrightService _service2;

        public DependancyInjectionDemoController(ICopyrightService service1, ICopyrightService service2)
        {
            //_svc = new CopyrightService();
            _service1 = service1;
            _service2 = service2;
        }

        public IActionResult Index()
        {
            //ViewBag.Copyright = $"Copyright {DateTime.Now.Year} all right reserved.";
            //CopyrightService _svc = new CopyrightService();

            ViewBag.Copyright = _service1.GetCopyrightString() + ", " + _service2.GetCopyrightString();

            return View();
        }

        public IActionResult About()
        {
            ViewBag.Copyright = _service1.GetCopyrightString();
            return View();
        }

        public IActionResult AtInjectDemo()
        {
            return View();
        }


    }
}
