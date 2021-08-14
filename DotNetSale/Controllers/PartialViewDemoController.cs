using DotNetSale.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetSale.Controllers
{
    public class PartialViewDemoController : Controller
    {
        public IActionResult Index(int Page = 0)
        {
            var pageModel = new PagerBase
            {
                Url = "PartialViewDemo",
                RecordCount = 200,
                PageSize = 10,
                PageNumber = Page,

                SearchMode = true,
                SearchField = "Title",
                SearchQuery  = "ASP.NET"
            };

            ViewBag.PageModel = pageModel;
            


            return View();
        }
    }
}
