using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace myTrack.Models
{
    public class Item
    {

        [Key]
        public int ItemId { get; set; }
        public string Title { get; set; }
        public bool Status { get; set; }
        public string Disciption { get; set; }
        public string Frequency { get; set; }
        public DateTime? NextDate { get; set; }

    }
}