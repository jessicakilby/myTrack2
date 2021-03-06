﻿using myTrack.Controllers.Contracts;
using myTrack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace myTrack.Controllers
{
    public class SubcategoryController : ApiController
    {
        readonly ISubcategoryRepository _subcategoryRepository;

        public SubcategoryController(ISubcategoryRepository subcategoryRepository)
        {
            _subcategoryRepository = subcategoryRepository;
        }
        
        [HttpGet]
        [Route("api/subcategory/{CatId}")]
        public HttpResponseMessage GetAllSubcategories(int CatId)
        {
            var subcategories = _subcategoryRepository.GetAllSubcategories(CatId);

            if (subcategories == null)
                return Request.CreateErrorResponse(HttpStatusCode.NoContent, "Subcategory doesn't exist");

            return Request.CreateResponse(HttpStatusCode.OK, subcategories);
        }

        //void AddSubcategory(Subcategory newSubcategory);
        [HttpPost]
        [Route("api/subcategory/{CatId}")]
        public HttpResponseMessage AddSubcategory(int CatId, Subcategory newSubcategory)
        {
            if (string.IsNullOrWhiteSpace(newSubcategory.Title))
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Invalid subcategory name.");
            }

            _subcategoryRepository.AddSubcategory(CatId, newSubcategory);

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        //void EditSubcategory(Subcategory editSubcategory);
        [HttpPut]
        [Route("api/subcategory/{SubcatId}")]
        public HttpResponseMessage EditSubcategory([FromBody] Subcategory editSubcategory, int newSubcatId)
        {
            if (string.IsNullOrWhiteSpace(editSubcategory.Title))
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Invalid subcategory Title.");
            }

            editSubcategory.SubcatId = newSubcatId;
            _subcategoryRepository.EditSubcategory(editSubcategory);

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        //void DeleteSubcategory(int deleteSubcatId);
        [HttpDelete]
        [Route("api/subcategory/{deleteSubcategory}")]
        public HttpResponseMessage DeleteSubcategory(int deleteSubcatId)
        {
            _subcategoryRepository.DeleteSubcategory(deleteSubcatId);

            return Request.CreateResponse(HttpStatusCode.OK);
        }

    }
}
