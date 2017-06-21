using myTrack.Controllers.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using myTrack.Models;

namespace myTrack.DAL.Repository
{
    public class SubcategoryRepository : ISubcategoryRepository
    {
        readonly ApplicationDbContext _context;

        public SubcategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddSubcategory(int CatId, Subcategory newSubcategory)
        {
            var currentCategory = _context.Categories.Find(CatId);

            if (currentCategory.Subcategories == null)
            {
                currentCategory.Subcategories = new List<Subcategory>();
            }

            currentCategory.Subcategories.Add(newSubcategory);
            _context.SaveChanges();
        }

        public void DeleteSubcategory(int deleteSubcatId)
        {
            var findId = _context.Subcategories.Find(deleteSubcatId);
            _context.Subcategories.Remove(findId);
            _context.SaveChanges();
        }

        public void EditSubcategory(Subcategory editSubcategory)
        {
            throw new NotImplementedException();
            //var findId = _context.Subcategories.Find(editSubcategory);
            //_context.Subcategories.
        }

        public IEnumerable<Subcategory> GetAllSubcategories(int CatId)
        {
            var currentCategory = _context.Categories.Include("Subcategories").FirstOrDefault(x => x.CatId == CatId);
            return currentCategory?.Subcategories;
        }

        
    }
}