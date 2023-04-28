using EjemploEFCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjemploEFCore.Services
{
    public interface IAutorService
    {
        void AddAutor(Autor cancion);
        void DeleteAutor(int CancionId);
        void DeleteAutor(Autor cancion);
        List<Autor> GetAutores();
        Autor GetAutor(int cancionId);
        Autor UpdateAutor(Autor cancion);
    }
}
