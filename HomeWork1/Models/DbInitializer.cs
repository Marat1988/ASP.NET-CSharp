using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HomeWork1.Models
{
    public class DbInitializer: DropCreateDatabaseAlways<MyDbContext>
    {
        protected override void Seed(MyDbContext db)
        {
            Country Russia = new Country { Name = "Russia", Capital = "Moscow" };
            Country France = new Country { Name = "France", Capital = "Paris" };
            Country Italy = new Country { Name = "Italy", Capital = "Rim" };
            db.Countries.Add(Russia);
            db.Countries.Add(France);
            db.Countries.Add(Italy);
            db.Restaurants.Add(new Restaurant { Name = "Russia restaurant", Owner = "Marat", Country = Russia });
            db.Restaurants.Add(new Restaurant { Name = "France restaurant", Owner = "Makron", Country = France });
            db.Restaurants.Add(new Restaurant { Name = "Italy restaurant", Owner = "Mattarella", Country = Italy });
            base.Seed(db);
        }
    }
}