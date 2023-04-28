using EjemploEFCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjemploEFCore.Services
{
    public interface IAlbumService
    {
        void AddAlbum(Album cancion);
        void DeleteAlbum(int CancionId);
        void DeleteAlbum(Album cancion);
        List<Album> GetAlbumnes();
        Album GetAlbum(int cancionId);
        Album UpdateAlbum(Album cancion);
    }
}
