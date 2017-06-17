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
        [Route("api/category/{CatId}")]
        public HttpResponseMessage GetSingleCategory(int CatId)
        {
            var category = _categoryRepository.GetSingleCategory(CatId);

            if (category == null)
                return Request.CreateErrorResponse(HttpStatusCode.NoContent, "Category doesn't exist");

            return Request.CreateResponse(HttpStatusCode.OK, category);
        }

        //IEnumerable<Category> GetAllCategories();
        [HttpGet]
        [Route("api/category")]
        public HttpResponseMessage GetAllCategories()
        {
            var categories = _categoryRepository.GetAllCategories();

            if (categories == null)
                return Request.CreateErrorResponse(HttpStatusCode.NoContent, "No Categories here");

            return Request.CreateResponse(HttpStatusCode.OK, categories);
        }

        //void AddCategory(Category newCategory);
        [HttpPost]
        [Route("api/category/")]
        public HttpResponseMessage AddCategory(Category newCategory)
        {
            if (string.IsNullOrWhiteSpace(newCategory.Title))
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Invalid Category name.");
            }

            _categoryRepository.AddCategory(newCategory);

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        //void EditCategory(Category editCategory);
        [HttpPut]
        [Route("api/category/{productId}")]
        public HttpResponseMessage EditCategory([FromBody] Category editCategory, int newCatId)
        {
            if (string.IsNullOrWhiteSpace(editCategory.Title))
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Invalid Title.");
            }

            editCategory.CatId = newCatId;
            _categoryRepository.EditCategory(editCategory);

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        //bool DeleteCategory(int deleteCatId);
        [HttpDelete]
        [Route("api/product/{deleteCategory}")]
        public HttpResponseMessage DeleteCategory(int deleteCategory)
        {
            _categoryRepository.DeleteCategory(deleteCategory);

            return Request.CreateResponse(HttpStatusCode.OK); 
        }

    }
}
