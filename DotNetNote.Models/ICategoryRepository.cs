using System.Collections.Generic;

namespace DotNetNote.Models
{
    interface ICategoryRepository
    {
        List<Category> GetAll();
    }


}



