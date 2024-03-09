using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TestIocDi.Models;

namespace TestIocDi.Context
{
    public class TestContext : DbContext
    {

        public TestContext() : base("DefaultConnection") { }

        public DbSet<Person> Persons {  get; set; } 
    }
}