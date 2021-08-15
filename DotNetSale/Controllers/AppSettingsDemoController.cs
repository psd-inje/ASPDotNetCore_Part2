using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetSale.Controllers
{
    public class AppSettingsDemoController : Controller
    {
        private readonly IConfiguration _configuration;

        public AppSettingsDemoController(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        public IActionResult Index()
        {
            string con1 = _configuration.GetSection("StorageConnectionString1").Value;
            string site1 = _configuration.GetSection("BlogStorageConnectionString").GetSection("Site1").Value;
            string site2 = _configuration.GetValue<string>("BlogStorageConnectionString:Site2");

            ViewBag.con1 = con1;
            ViewBag.site1 = site1;
            ViewBag.site2 = site2;


            return View();
        }
    }
}
