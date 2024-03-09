using System.Collections.Generic;
using TestIocDi.Models;

namespace TestIocDi.Repository
{
    public interface IPersonRepository
    {
        List<Person> GetAllPerson();
        List<PersonViewModel> GetPersonsFromTextFile(string FilePath);
    }
}
