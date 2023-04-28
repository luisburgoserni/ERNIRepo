using MiSegundaAPI.Models;

namespace MiSegundaAPI.Services
{
    public interface IPersonService
    {
        void AddPerson(Person person);
        void DeletePerson(int Id);
        void DeletePerson(Person person);
        List<Person> GetPersons();
        Person GetPerson(int Id);
        Person UpdatePerson(Person person);
    }
}
