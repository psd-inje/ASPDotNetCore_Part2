using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetSale.Views.Company
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            //return View();

            //return RedirectToAction( "CategoryList");
            return RedirectToAction(nameof(CategoryList));
        }

        public IActionResult CategoryAdd()
        {
            return View();
        }

        public IActionResult CategoryList()
        {
            return View();
        }
    }
}
