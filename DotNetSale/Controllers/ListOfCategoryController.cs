using DotNetNote.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetSale.Controllers
{
    public class ListOfCategoryController : Controller
    {
        private readonly ICategoryRepository _repository;

        public ListOfCategoryController(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {

            //var categoryRepository = new CategoryRepositoryInMemory();
            //var categories = categoryRepository.GetAll();
            
            var categories = _repository.GetAll();

            return View(categories);
        }
    }
}
