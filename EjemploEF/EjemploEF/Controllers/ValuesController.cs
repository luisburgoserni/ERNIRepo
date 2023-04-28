using EjemploEF.Services;
using Microsoft.AspNetCore.Mvc;

namespace EjemploEF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ICancionService _cancionService;
        private readonly IAutorService _autorService;
        private readonly IAlbumService _albumService;

        public ValuesController(ICancionService cancionService, IAutorService autorService, IAlbumService albumService)
        {
            _cancionService = cancionService;
            _autorService = autorService;
            _albumService = albumService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            //_cancionService.AddCancion(new Models.Cancion
            //{
            //    Descripcion = "Asereje",
            //    Duracion = new TimeSpan(0, 4, 25),
            //    Titulo = "Asereje ja de je"
            //});

            //var canciones = _cancionService.GetCanciones();

            //var cancion = _cancionService.GetCancion(1);

            //cancion.Descripcion = "Entidad cambiada";

            //_cancionService.UpdateCancion(cancion);

            //_cancionService.DeleteCancion(2);

            //_albumService.AddAlbum(new Models.Album
            //{
            //    Nombre = "Album1"
            //});

            //_autorService.AddAutor(new Models.Autor
            //{
            //    Nombre = "Pepe Gomez"
            //});

            //_cancionService.AddCancion(new Models.Cancion
            //{
            //    AutorId = 2,
            //    AlbumId = 2,
            //    Descripcion = "descripcion",
            //    Titulo = "Titulo",
            //    Duracion = new TimeSpan(0, 4, 25)
            //});

            var cancion = _cancionService.GetCancion(3);
            var nombre = cancion.Autor.Nombre;

            return new string[] { nombre };
        }
    }
}
