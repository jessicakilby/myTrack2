using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using myTrack.Controllers.Contracts;
using myTrack.Models;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace myTrack.Controllers
{
    [Authorize]
    public class CategoryController : ApiController
    {
        readonly ICategoryRepository _categoryRepository;
        private ApplicationDbContext _db;

        public CategoryController(ICategoryRepository categoryRepository, ApplicationDbContext db)
        {
            _categoryRepository = categoryRepository;
            _db = db;
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
            var categories = _categoryRepository.GetAllCategories(User.Identity.GetUserId());

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

            newCategory.User = _db.Users.Find(User.Identity.GetUserId());

            _categoryRepository.AddCategory(newCategory);

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        //void EditCategory(Category editCategory);
        [HttpPut]
        [Route("api/category/{CatId}")]
        public HttpResponseMessage EditCategory([FromBody] Category editCategory, int newCatId)
        {
            if (string.IsNullOrWhiteSpace(editCategory.Title))
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Invalid category Title.");
            }

            editCategory.CatId = newCatId;
            _categoryRepository.EditCategory(editCategory);

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        //bool DeleteCategory(int deleteCatId);
        [HttpDelete]
        [Route("api/category/{deleteCategory}")]
        public HttpResponseMessage DeleteCategory(int deleteCategory)
        {
            _categoryRepository.DeleteCategory(deleteCategory);

            return Request.CreateResponse(HttpStatusCode.OK); 
        }

    }
}
