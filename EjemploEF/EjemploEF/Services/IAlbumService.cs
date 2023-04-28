using EjemploEF.Models;

namespace EjemploEF.Services
{
    public interface IAlbumService
    {
        void AddAlbum(Album album);

        void DeleteAlbum(int AlbumId);

        void DeleteAlbum(Album album);

        List<Album> GetAlbunes();
        Album GetAlbum(int AlbumId);
        Album UpdateAlbum(Album album);
    }
}
