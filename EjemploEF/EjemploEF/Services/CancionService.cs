using EjemploEF.Contexto;
using EjemploEF.Models;
using Microsoft.EntityFrameworkCore;

namespace EjemploEF.Services
{
    public class CancionService : ICancionService
    {
        private readonly IContextoDB _contextoDB;

        public CancionService(IContextoDB contextoDB)
        {
            _contextoDB = contextoDB;
        }

        public void AddCancion(Cancion cancion)
        {
            _contextoDB.Canciones.Add(cancion);
            _contextoDB.SaveChanges();
        }

        public void DeleteCancion(int CancionId)
        {
            var cancion = GetCancion(CancionId);
            DeleteCancion(cancion);
        }

        public void DeleteCancion(Cancion cancion)
        {
            _contextoDB.Canciones.Remove(cancion);
            _contextoDB.SaveChanges();
        }

        public List<Cancion> GetCanciones()
        {
            return _contextoDB.Canciones.Select(x => x).ToList();         
        }

        public Cancion GetCancion(int CancionId)
        {
            return _contextoDB.Canciones.Include(x => x.Autor).Include(x => x.Album).Where(x => x.CancionId == CancionId).FirstOrDefault();
        }

        public Cancion UpdateCancion(Cancion cancion)
        {
            //var cancionaux = GetCancion(cancion.CancionId);

            var cancionUpdated = _contextoDB.Canciones.Update(cancion).Entity;
            _contextoDB.SaveChanges();

            return cancionUpdated;      
        }
    }
}
