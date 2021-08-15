using DotNetSale.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetSale.Controllers
{
    public class SingletonDemoController : Controller
    {

        //private readonly InfoService _svc;

        //public SingletonDemoController(InfoService svc)
        //{
        //    _svc = svc;
        //}

        private readonly IInfoService _svc;
        public SingletonDemoController(IInfoService svc)
        {
            _svc = svc;
        }

        public IActionResult ConstructorInjectionDemo()
        {
            ViewData["Url"] = _svc.GetUrl();
            return View();
        }


        public IActionResult Index()
        {
            ViewData["Url"] = "www.gilbut.co.kr:0002";
            return View();
        }

        public IActionResult InfoServiceDemo()
        {
            InfoService svc = new InfoService();
            ViewData["Url"] = svc.GetUrl();
            return View();
        }


    }
}
