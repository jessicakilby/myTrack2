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
        readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddCategory(Category newCategory)
        {
            _context.Categories.Add(newCategory);
            _context.SaveChanges();
        }

        public void DeleteCategory(int deleteCatId)
        {
            var findId = _context.Categories.Find(deleteCatId);
            _context.Categories.Remove(findId);
            _context.SaveChanges();
        }

        public void EditCategory(Category editCategory)
        {
            throw new NotImplementedException();
            //var findId = _context.Categories.Find(editCategory);
            //_context.Categories.
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _context.Categories;
        }

        public Category GetSingleCategory(int CatId)
        {
            return _context.Categories.Find(CatId);
        }

        
    }
}