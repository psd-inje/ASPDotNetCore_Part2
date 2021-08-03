using DotNetNoteCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetNoteCore.Controllers
{
    public class ViewBagDemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ViewBagDemo()
        {
            ViewBag.Name = "홍길동";
            ViewBag.Age = 21;
            ViewBag.원하는모든단어 = "모든 값...";

            //ViewBag.Address = "세종시...";   ViewBag.Address = ViewBag["Address"]
            ViewData["Address"] = "세종시...";

            return View();
        }


        public IActionResult ViewWithModelDemo()
        {
            DemoModel dm = new DemoModel();
            dm.Id = 1;
            dm.Name = "홍길동";

            return View(dm);
        }


        public IActionResult ViewWithListOfDemo()
        {
            List<DemoModel> models = new List<DemoModel>(){
                new DemoModel { Id = 1, Name = "홍길동"},
                new DemoModel { Id = 2, Name = "백두산"},
                new DemoModel { Id = 3, Name = "임꺽정"},
            };

            return View(models);  // 다중 레코드, 컬렉션, List<T>
        }

    }
}
