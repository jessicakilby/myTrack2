﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTrack.Controllers.Contracts
{
    interface ICategoryRepository
    {
        void AddCategory(string Title, string Description);
    }
}
