using EjemploEF.Contexto;
using EjemploEF.Models;

namespace EjemploEF.Services
{
    public class AutorService : IAutorService
    {
        private readonly IContextoDB _contextoDB;

        public AutorService(IContextoDB contextoDB)
        {
            _contextoDB = contextoDB;
        }

        public void AddAutor(Autor autor)
        {
            _contextoDB.Autores.Add(autor);
            _contextoDB.SaveChanges();
        }

        public void DeleteAutor(int AutorId)
        {
            var autor = GetAutor(AutorId);
            DeleteAutor(autor);
        }

        public void DeleteAutor(Autor autor)
        {
            _contextoDB.Autores.Remove(autor);
            _contextoDB.SaveChanges();
        }

        public List<Autor> GetAutores()
        {
            return _contextoDB.Autores.Select(x => x).ToList();
        }

        public Autor GetAutor(int AutorId)
        {
            return _contextoDB.Autores.Where(x => x.AutorId == AutorId).FirstOrDefault();
        }

        public Autor UpdateAutor(Autor autor)
        {
            //var autoraux = GetAutor(autor.AutorId);

            var autorUpdated = _contextoDB.Autores.Update(autor).Entity;
            _contextoDB.SaveChanges();

            return autorUpdated;
        }
    }
}
