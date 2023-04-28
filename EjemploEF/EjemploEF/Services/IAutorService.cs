using EjemploEF.Models;

namespace EjemploEF.Services
{
    public interface IAutorService
    {
        void AddAutor(Autor autor);

        void DeleteAutor(int AutorId);

        void DeleteAutor(Autor autor);

        List<Autor> GetAutores();
        Autor GetAutor(int AutorId);
        Autor UpdateAutor(Autor autor);
    }
}
