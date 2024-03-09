using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TestIocDi.Context;
using TestIocDi.Models;

namespace TestIocDi.Repository
{
    public class PersonRepository: IDisposable, IPersonRepository
    {
        private readonly TestContext db = new TestContext();

        public List<Person> GetAllPerson() => db.Persons.ToList();

        public List<PersonViewModel> GetPersonsFromTextFile(string FilePath)
        {
            string[] lines = File.ReadAllLines(FilePath);
            var persons = lines.Where(line => !line.Contains("*") && !line.Contains("%"))
                .Select(line =>
                {
                    string[] lineData = line.Split(' ');
                    return new PersonViewModel(lineData[0].Trim(), lineData[1].Trim(), DateTime.Parse(lineData[2].Trim()), lineData[3].Trim());
                }).ToList();
            return persons;
        }

        public void Dispose() => db?.Dispose();

    }
}