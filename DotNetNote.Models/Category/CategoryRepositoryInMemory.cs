using System.Collections.Generic;

namespace DotNetNote.Models
{
    public class CategoryRepositoryInMemory : ICategoryRepository
    {
        public List<Category> GetAll()
        {
            var categories = new List<Category>() {
                new Category() { CategoryId = 1, CategoryName = "좋은 책" },
                new Category() { CategoryId = 2, CategoryName = "좋은 강의" },
                new Category() { CategoryId = 3, CategoryName = "좋은 컴퓨터" }
            };


            return categories;
        }
    }
}
