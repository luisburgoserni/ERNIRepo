using EjemploEFCore.Contexto;
using EjemploEFCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjemploEFCore.Services
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

        public void DeleteAlbum(int albumId)
        {
            var cancion = GetAlbum(albumId);
            DeleteAlbum(cancion);
        }

        public void DeleteAlbum(Album album)
        {
            _contextoDB.Albunes.Remove(album);
            _contextoDB.SaveChanges();
        }

        public List<Album> GetAlbumnes()
        {
            return _contextoDB.Albunes.Select(x => x).ToList();

        }

        public Album GetAlbum(int albumId)
        {
            return _contextoDB.Albunes.Where(x => x.AlbumId == albumId).FirstOrDefault();
        }

        public Album UpdateAlbum(Album album)
        {
            //var cancionaux = GetCancion(cancion.CancionId);

            var AlbumUpdated =  _contextoDB.Albunes.Update(album).Entity;
            _contextoDB.SaveChanges();

            return AlbumUpdated;
        }



    }
}
