using EjemploEFCore.Contexto;
using EjemploEFCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjemploEFCore.Services
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

        public Cancion GetCancion(int cancionId)
        {
            return _contextoDB.Canciones.Include(x=> x.Autor).Include(x=> x.Album).Where(x => x.CancionId == cancionId)
                .FirstOrDefault();
        }

        public Cancion UpdateCancion(Cancion cancion)
        {
            //var cancionaux = GetCancion(cancion.CancionId);

            var cancionUpdated =  _contextoDB.Canciones.Update(cancion).Entity;
            _contextoDB.SaveChanges();

            return cancionUpdated;
        }



    }
}
