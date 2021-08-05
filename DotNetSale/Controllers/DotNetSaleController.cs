using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetSale.Controllers
{
    public class DotNetSaleController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CategoryIndex()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CategoryList()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ProductAdd()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ProductList(int categoryId = 0)
        {
            ViewBag.CategoryId = categoryId;

            return View();
        }

        public IActionResult ProductPages()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ReviewList(int productId = 0)
        {
            ViewData["productId"] = productId;
            return View();
        }

        [HttpGet]
        public IActionResult AddToCart(int productId = 0, int quantity = 0)
        {
            ViewBag.ProductId = productId;
            ViewBag.Quantity = quantity;

            return View();
        }

        [HttpGet]
        public IActionResult ShoppingCart()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ShoppingCart(int productId = 0, int quantity = 0)
        {
            ViewBag.ProductId = productId;
            ViewBag.Quantity = quantity;

            return View();
        }


        [HttpGet]
        public IActionResult SearchForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SearchResults(string modelName)
        {
            ViewBag.ModelName = modelName;

            return View();
        }

    }
}
