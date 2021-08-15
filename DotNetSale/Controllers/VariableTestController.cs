using DotNetNote.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetSale.Controllers
{
    public class VariableTestController : Controller
    {
        private readonly IVariableRepository _repository;

        public VariableTestController(IVariableRepository repository)
        {
            this._repository = repository;
        }

        public IActionResult Index()
        {
            var variables = _repository.GetAll();
            ViewBag.variables = variables;

            return View();
        }
    }
}
