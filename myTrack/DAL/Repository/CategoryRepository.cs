using myTrack.Controllers.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using myTrack.Models;

namespace myTrack.DAL.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        public void AddCategory(Category newCategory)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCategory(int deleteCatId)
        {
            throw new NotImplementedException();
        }

        public void EditCategory(Category editCategory)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetAllCategories()
        {
            throw new NotImplementedException();
        }

        public Category GetSingleCategory(int CatId)
        {
            throw new NotImplementedException();
        }
    }
}