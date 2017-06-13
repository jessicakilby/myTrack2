using myTrack.Controllers.Contracts;
using myTrack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace myTrack.Controllers
{
    public class CategoryController : ApiController
    {
        readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        //Category GetSingleCategory(int CatId);
        [HttpGet]
        [Route("{CatId}")]
        public HttpResponseMessage GetSingleCategory(int CatId)
        {
            var category = _categoryRepository.GetSingleCategory(CatId);

            if (category == null)
                return Request.CreateErrorResponse(HttpStatusCode.NoContent, "Category doesn't exist");

            return Request.CreateResponse(HttpStatusCode.OK, category);
        }

        //IEnumerable<Category> GetAllCategories();
        [HttpGet]
        public HttpResponseMessage GetAllCategories()
        {
            var categories = _categoryRepository.GetAllCategories() as List<Category>;

            if (categories == null)
                return Request.CreateErrorResponse(HttpStatusCode.NoContent, "No Categories here");

            return Request.CreateResponse(HttpStatusCode.OK, categories);
        }

        //void AddCategory(Category newCategory);

        //void EditCategory(Category editCategory);

        //bool DeleteCategory(int deleteCatId);

    }
}
