using EjemploInyeccionDependencias.Solucion;
using Microsoft.AspNetCore.Mvc;

namespace EjemploInyeccionDependencias.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<string> Get()
        {
            var terrestre = new Vehiculo(new Terrestre());
            var responseTerrestre = terrestre.Arrancar();

            var nautico = new Vehiculo(new Nautico());
            var responseNautico = nautico.Arrancar();

            var aereo = new Vehiculo(new Aereo());
            var responseAereo = aereo.Arrancar();

            return string.Empty;
        }
    }
}