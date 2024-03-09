using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TestIocDi.Models;

namespace TestIocDi.Context
{
    public class MyContextInitializer: DropCreateDatabaseAlways<TestContext>
    {
        protected override void Seed(TestContext context)
        {
            List<Person> people = new List<Person>()
            {
                new Person() { FirstName = "Иван", LastName = "Иванов", BirthDay = new DateTime(1988, 1, 1), OtherInformation = "Студент1" },
                new Person() { FirstName = "Петр", LastName = "Петрович", BirthDay = new DateTime(1988, 1, 2), OtherInformation = "Студент2" },
                new Person() { FirstName = "Александр", LastName = "Александрович", BirthDay = new DateTime(1988, 1, 3), OtherInformation = "Студент3" },
                new Person() { FirstName = "Егор", LastName = "Егорович", BirthDay = new DateTime(1988, 1, 4), OtherInformation = "Студент4" },
                new Person() { FirstName = "Михаил", LastName = "Михаилович", BirthDay = new DateTime(1988, 1, 5), OtherInformation = "Студент5" },
                new Person() { FirstName = "Дмитрий", LastName = "Дмитриевич", BirthDay = new DateTime(1988, 1, 6), OtherInformation = "Студент6" },
                new Person() { FirstName = "Владимир", LastName = "Владимирович", BirthDay = new DateTime(1988, 1, 7), OtherInformation = "Студент7" },
                new Person() { FirstName = "Виктор", LastName = "Викторович", BirthDay = new DateTime(1988, 1, 8), OtherInformation = "Студент8" },
                new Person() { FirstName = "Артур", LastName = "Артурович", BirthDay = new DateTime(1988, 1, 9), OtherInformation = "Студент9" },
                new Person() { FirstName = "Илья", LastName = "Викторович", BirthDay = new DateTime(1988, 1, 10), OtherInformation = "Студент10" }
            };
            context.Persons.AddRange(people);
            context.SaveChanges();         
      
            base.Seed(context);
        }
    }
}