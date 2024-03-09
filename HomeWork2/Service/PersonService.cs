using System.Collections.Generic;
using TestIocDi.Models;
using TestIocDi.Repository;

namespace TestIocDi.Service
{
    public class PersonService
    {
        private readonly IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository) => _personRepository = personRepository;

        public List<Person> GetAllPerson() => _personRepository.GetAllPerson();

        public List<PersonViewModel> GetPersonsFromTextFile(string FilePath) => _personRepository.GetPersonsFromTextFile(FilePath);
    }
}