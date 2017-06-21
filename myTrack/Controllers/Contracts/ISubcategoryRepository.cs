using myTrack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTrack.Controllers.Contracts
{
    public interface ISubcategoryRepository
    {
        IEnumerable<Subcategory> GetAllSubcategories(int CatId);

        void AddSubcategory(int CatId, Subcategory newSubcategory);

        void EditSubcategory(Subcategory editSubcategory);

        void DeleteSubcategory(int deleteSubcatId);

    }
}
