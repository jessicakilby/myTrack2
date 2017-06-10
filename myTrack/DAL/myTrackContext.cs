using myTrack.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace myTrack.DAL
{
    public class myTrackContext : DbContext
    {
        public myTrackContext : base("myTrack") {}

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Subcategory> Subcategories { get; set; }
        public virtual DbSet<Item> Items { get; set; }
    }
}