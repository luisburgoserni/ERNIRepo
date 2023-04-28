namespace EjemploInyeccionDependencias2.Services
{
    public class TallerService : ITallerService
    {
        private readonly IVehiculoService _vehiculoService;

        public TallerService(IVehiculoService vehiculoService)
        {
            _vehiculoService = vehiculoService;
        }

        public string Reparar()
        {
            _vehiculoService.Arrancar();
            return "reparando vehiculo";
        }
    }
}
