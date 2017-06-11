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
        public void AddSubcategory(Subcategory newSubcategory)
        {
            throw new NotImplementedException();
        }

        public bool DeleteSubcategory(int deleteSubcatId)
        {
            throw new NotImplementedException();
        }

        public void EditSubcategory(Subcategory editSubcategory)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Subcategory> GetAllSubcategories()
        {
            throw new NotImplementedException();
        }

        public Subcategory GetSingleSubcategory(int SubcatId)
        {
            throw new NotImplementedException();
        }
    }
}