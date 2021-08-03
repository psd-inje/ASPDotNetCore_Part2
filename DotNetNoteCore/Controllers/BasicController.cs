using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetNoteCore.Controllers
{
    public class BasicController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Unit()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Quiz(int id, int page)
        {
            //var page = Request.QueryString["Page"];
            //var page = Request.Form["Page"];

            ViewData["Id"] = id;

            return View();
        }

        [HttpPost]
        public IActionResult Quiz(string answer)
        {
            ViewBag.Answer = answer;
            return View();
        }


        /// <summary>
        /// 강력한 형식(stringly Typed)
        /// </summary>
        /// <returns></returns>
        public IActionResult Analysis()
        {

            int score = 100;
            return View(score);
        }

        public IActionResult Review()
        {
            return View();
        }
    }
}
