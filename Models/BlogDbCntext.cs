using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NavBarOtherMethod.Models
{
    public class BlogDbCntext:DbContext
    {
        public BlogDbCntext() : base("Blog") { }
        
        public DbSet<MenuCategory> MenuCategories { get; set; }

        public DbSet<News> News { get; set; }
        
    }
}