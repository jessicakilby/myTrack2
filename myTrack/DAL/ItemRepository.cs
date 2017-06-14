using myTrack.Controllers.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using myTrack.Models;

namespace myTrack.DAL.Repository
{
    public class ItemRepository : IItemRepository
    {
        public void AddItem(Item newItem)
        {
            throw new NotImplementedException();
        }

        public bool DeleteItem(int deleteItemId)
        {
            throw new NotImplementedException();
        }

        public void EditItem(Item editItem)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Item> GetAllItems()
        {
            throw new NotImplementedException();
        }

        public Item GetSingleItem(int ItemId)
        {
            throw new NotImplementedException();
        }
    }
}