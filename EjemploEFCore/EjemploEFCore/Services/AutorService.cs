using EjemploEFCore.Contexto;
using EjemploEFCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjemploEFCore.Services
{
    public class AutorService : IAutorService
    {

        private readonly IContextoDB _contextoDB;

        public AutorService(IContextoDB contextoDB)
        {
            _contextoDB = contextoDB;
        }

        public void AddAutor(Autor cancion)
        {
            _contextoDB.Autores.Add(cancion);

            _contextoDB.SaveChanges();

        }

        public void DeleteAutor(int CancionId)
        {
            var cancion = GetAutor(CancionId);
            DeleteAutor(cancion);
        }

        public void DeleteAutor(Autor cancion)
        {
            _contextoDB.Autores.Remove(cancion);
            _contextoDB.SaveChanges();
        }

        public List<Autor> GetAutores()
        {
            return _contextoDB.Autores.Select(x => x).ToList();

        }

        public Autor GetAutor(int autorId)
        {
            return _contextoDB.Autores.Where(x => x.AutorId == autorId).FirstOrDefault();
        }

        public Autor UpdateAutor(Autor autor)
        {
            //var cancionaux = GetCancion(cancion.CancionId);

            var cancionUpdated =  _contextoDB.Autores.Update(autor).Entity;
            _contextoDB.SaveChanges();

            return cancionUpdated;
        }



    }
}
