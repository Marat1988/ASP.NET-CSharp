using System.Data.Entity;
using TestIocDi.Models;

namespace TestIocDi.Context
{
    public class TestContext : DbContext
    {

        public TestContext() : base("DefaultConnection") { }

        public DbSet<Person> Persons {  get; set; } 
        public DbSet<Book> Books { get; set; }
    }
}