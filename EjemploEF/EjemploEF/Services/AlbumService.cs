using EjemploEF.Contexto;
using EjemploEF.Models;

namespace EjemploEF.Services
{
    public class AlbumService : IAlbumService
    {
        private readonly IContextoDB _contextoDB;

        public AlbumService(IContextoDB contextoDB)
        {
            _contextoDB = contextoDB;
        }

        public void AddAlbum(Album album)
        {
            _contextoDB.Albunes.Add(album);
            _contextoDB.SaveChanges();
        }

        public void DeleteAlbum(int AlbumId)
        {
            var album = GetAlbum(AlbumId);
            DeleteAlbum(album);
        }

        public void DeleteAlbum(Album album)
        {
            _contextoDB.Albunes.Remove(album);
            _contextoDB.SaveChanges();
        }

        public List<Album> GetAlbunes()
        {
            return _contextoDB.Albunes.Select(x => x).ToList();
        }

        public Album GetAlbum(int AlbumId)
        {
            return _contextoDB.Albunes.Where(x => x.AlbumId == AlbumId).FirstOrDefault();
        }

        public Album UpdateAlbum(Album album)
        {
            //var albumaux = GetAlbum(album.AlbumId);

            var albumUpdated = _contextoDB.Albunes.Update(album).Entity;
            _contextoDB.SaveChanges();

            return albumUpdated;
        }
    }
}
