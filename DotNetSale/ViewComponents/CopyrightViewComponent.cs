using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetSale.ViewComponents
{
    public class CopyrightViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            //return View();
            //return View("Details");

            string viewName = "Default";
            if (DateTime.Now.Second % 2 == 0)
            {
                viewName = "Details";
            }

            return View(viewName);

        }
    }
}
