using DotNetNote.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetNoteCore.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Category()
        {
            CategoryRepositoryInMemory repository = new CategoryRepositoryInMemory();
            var categorys = repository.GetAll();

            return View(categorys);
        }
    }
}
