using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HomeWork1.Models
{
    public class MyDbContext: DbContext
    {
        public MyDbContext() : base("DbConnection") { }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}