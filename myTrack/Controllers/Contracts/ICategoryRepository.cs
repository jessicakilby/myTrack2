using myTrack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTrack.Controllers.Contracts
{
    public interface ICategoryRepository
    {
        Category GetSingleCategory(int CatId);

        IEnumerable<Category> GetAllCategories();

        void AddCategory(Category newCategory);

        void EditCategory(Category editCategory);

        void DeleteCategory(int deleteCatId);
        
    }
}
