using MiSegundaAPI.Context;
using MiSegundaAPI.Models;

namespace MiSegundaAPI.Services
{
    public class HouseService : IHouseService
    {
        private readonly IDBContext _context;

        public HouseService(IDBContext context)
        {
            _context = context;
        }

        public void AddHouse(House house)
        {
            throw new NotImplementedException();
        }

        public void DeleteHouse(int Id)
        {
            throw new NotImplementedException();
        }

        public void DeleteHouse(House house)
        {
            throw new NotImplementedException();
        }

        public House GetHouse(int Id)
        {
            throw new NotImplementedException();
        }

        public List<House> GetHouses()
        {
            throw new NotImplementedException();
        }

        public House UpdateHouse(House house)
        {
            throw new NotImplementedException();
        }
    }
}
