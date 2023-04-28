using EjemploInyeccionDependencias2.Models;
using EjemploInyeccionDependencias2.Services;
using Microsoft.AspNetCore.Mvc;

namespace EjemploInyeccionDependencias2.Controllers
{
    public class ValuesController : ControllerBase
    {
        private readonly IVehiculoService _vehiculoService;
        private readonly ITallerService _tallerService;

        public ValuesController(IVehiculoService vehiculoService, ITallerService tallerService)
        {

            _vehiculoService = vehiculoService;
            _tallerService = tallerService;
        }

        [HttpGet]
        public ActionResult<string> Get()
        {
            var terrestre = new Vehiculo(new Terrestre());
            var response = terrestre.Arrancar();

            var nautico = new Vehiculo(new Nautico());
            var response2 = nautico.Arrancar();

            return string.Empty;
        }

        [HttpGet]
        [Route("ejemplo")]
        public ActionResult<string> Get2()
        {
            _vehiculoService.Arrancar();
            _tallerService.Reparar();

            return string.Empty;
        }
    }
}
