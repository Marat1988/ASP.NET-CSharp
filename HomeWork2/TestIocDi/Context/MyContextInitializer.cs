using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            List<Book> books = new List<Book>()
            {
                new Book() { Name = "Книга1", Author = "Автор1", Style = "Стиль1", Year = 2000, OtherInfo = "Другая информация1" },
                new Book() { Name = "Книга2", Author = "Автор2", Style = "Стиль2", Year = 2001, OtherInfo = "Другая информация2" },
                new Book() { Name = "Книга3", Author = "Автор3", Style = "Стиль3", Year = 2002, OtherInfo = "Другая информация3" },
                new Book() { Name = "Книга4", Author = "Автор4", Style = "Стиль4", Year = 2003, OtherInfo = "Другая информация4" },
                new Book() { Name = "Книга5", Author = "Автор5", Style = "Стиль5", Year = 2004, OtherInfo = "Другая информация5" },
                new Book() { Name = "Книга6", Author = "Автор6", Style = "Стиль6", Year = 2005, OtherInfo = "Другая информация6" },
                new Book() { Name = "Книга7", Author = "Автор7", Style = "Стиль7", Year = 2006, OtherInfo = "Другая информация7" },
                new Book() { Name = "Книга8", Author = "Автор8", Style = "Стиль8", Year = 2007, OtherInfo = "Другая информация8" },
                new Book() { Name = "Книга9", Author = "Автор9", Style = "Стиль9", Year = 2008, OtherInfo = "Другая информация9" },
                new Book() { Name = "Книга10", Author = "Автор10", Style = "Стиль10", Year = 2009, OtherInfo = "Другая информация10" }
            };
            context.Books.AddRange(books);
            context.Persons.AddRange(people);
            context.SaveChanges();            
            base.Seed(context);
        }
    }
}