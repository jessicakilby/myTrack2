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
        readonly ApplicationDbContext _context;

        public ItemRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddItem(Item newItem)
        {
            _context.Items.Add(newItem);
            _context.SaveChanges();
        }

        public void DeleteItem(int deleteItemId)
        {
            var findId = _context.Items.Find(deleteItemId);
            _context.Items.Remove(findId);
            _context.SaveChanges();
        }

        public void EditItem(Item editItem)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Item> GetAllItems()
        {
            return _context.Items;
        }

        public Item GetSingleItem(int ItemId)
        {
            return _context.Items.Find(ItemId);
        }
    }
}