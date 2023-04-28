using MiSegundaAPI.Context;
using MiSegundaAPI.Models;

namespace MiSegundaAPI.Services
{
    public class PersonService : IPersonService
    {
        private readonly IDBContext _context;

        public PersonService(IDBContext context)
        {
            _context = context;
        }

        public void AddPerson(Person person)
        {
            throw new NotImplementedException();
        }

        public void DeletePerson(int Id)
        {
            throw new NotImplementedException();
        }

        public void DeletePerson(Person person)
        {
            throw new NotImplementedException();
        }

        public Person GetPerson(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetPersons()
        {
            throw new NotImplementedException();
        }

        public Person UpdatePerson(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
