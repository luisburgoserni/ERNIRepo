using EjemploInyeccionDependencias2.Models;

namespace EjemploInyeccionDependencias2.Services
{
    public class VehiculoService : IVehiculoService
    {
        public Vehiculo GetVehiculo(int id)
        {
            return new Vehiculo
            {

            };
        }

        public string Arrancar()
        {
            return "Arrancado";
        }
    }
}
