using MiSegundaAPI.Models;

namespace MiSegundaAPI.Services
{
    public interface IHouseService
    {
        void AddHouse(House house);
        void DeleteHouse(int Id);
        void DeleteHouse(House house);
        List<House> GetHouses();
        House GetHouse(int Id);
        House UpdateHouse(House house);
    }
}
