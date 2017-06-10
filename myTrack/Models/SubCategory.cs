using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace myTrack.Models
{
    public class Subcategory
    {

        [Key]
        public int SubcatId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Item> Items { get; set; }

    }
}