using EjemploEF.Models;

namespace EjemploEF.Services
{
    public interface ICancionService
    {
        void AddCancion(Cancion cancion);

        void DeleteCancion(int CancionId);

        void DeleteCancion(Cancion cancion);

        List<Cancion> GetCanciones();
        Cancion GetCancion(int CancionId);
        Cancion UpdateCancion(Cancion cancion);
    }
}
