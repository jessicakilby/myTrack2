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
    public class ItemController : ApiController
    {
        readonly IItemRepository _itemRepository;

        public ItemController(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        //Item GetSingleItem(int ItemId);
        [HttpGet]
        [Route("api/item/{ItemId}")]
        public HttpResponseMessage GetSingleItem(int ItemId)
        {
            var item = _itemRepository.GetSingleItem(ItemId);

            if (item == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NoContent, "Item doesn't exist");
            }

            return Request.CreateResponse(HttpStatusCode.OK, item);
        }

        //IEnumerable<Item> GetAllItems();
        [HttpGet]
        [Route("api/item")]
        public HttpResponseMessage GetAllItems()
        {
            var item = _itemRepository.GetAllItems();

            if (item == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NoContent, "No item here");
            }

            return Request.CreateResponse(HttpStatusCode.OK, item);
        }

        //void AddItem(int SubcatId, Item newItem);
        [HttpPost]
        [Route("api/item/{SubcatId}")]
        public HttpResponseMessage AddItem(int SubcatId, Item newItem)
        {
            if (string.IsNullOrWhiteSpace(newItem.Title))
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Invalid Item name.");
            }

            _itemRepository.AddItem(SubcatId, newItem);

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        //void EditItem(Item editItem);
        [HttpPut]
        [Route("api/item/{ItemId}")]
        public HttpResponseMessage EditItem([FromBody] Item editItem, int newItemId)
        {
            if (string.IsNullOrWhiteSpace(editItem.Title))
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Invalid item Title.");
            }

            editItem.ItemId = newItemId;
            _itemRepository.EditItem(editItem);

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        //void DeleteItem(int deleteItemId);
        [HttpDelete]
        [Route("api/item/{deleteItem}")]
        public HttpResponseMessage DeleteItem(int deleteItemId)
        {
            _itemRepository.DeleteItem(deleteItemId);

            return Request.CreateResponse(HttpStatusCode.OK);
        }

    }
}
