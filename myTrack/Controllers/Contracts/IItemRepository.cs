﻿using myTrack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTrack.Controllers.Contracts
{
    public interface IItemRepository
    {
        IEnumerable<Item> GetAllItems(int SubcatId);

        void AddItem(int SubcatId, Item newItem);

        void EditItem(Item editItem);

        void DeleteItem(int deleteItemId);
    }
}
