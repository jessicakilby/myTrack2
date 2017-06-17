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
        Subcategory GetSingleSubcategory(int SubcatId);

        IEnumerable<Subcategory> GetAllSubcategories();

        void AddSubcategory(Subcategory newSubcategory);

        void EditSubcategory(Subcategory editSubcategory);

        void DeleteSubcategory(int deleteSubcatId);
    }
}
