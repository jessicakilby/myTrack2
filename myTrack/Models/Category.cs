﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace myTrack.Models
{
    public class Category
    {
        [Key]
        public int CatId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<SubCategory> SubCategories { get; set; }
    }
}