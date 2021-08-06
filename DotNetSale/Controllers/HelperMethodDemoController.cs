using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetSale.Controllers
{
    public class HelperMethodDemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult FormDemo()
        {
            return View();
        }

        public IActionResult InputDemo()
        {
            return View();
        }

        public IActionResult StronglyTypedDemo()
        {
            var stc = new StronglyTypedClass()
            {
                Id = 1,Name = "홍길동", Age = 21

            };
            return View(stc);
        }

    }
}


public class StronglyTypedClass
{
    public int Id { get; set; }
    public string  Name { get; set; }
    public int Age { get; set; }
}
