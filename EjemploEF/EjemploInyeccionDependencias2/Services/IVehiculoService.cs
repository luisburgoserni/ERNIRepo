using EjemploInyeccionDependencias2.Models;

namespace EjemploInyeccionDependencias2.Services
{
    public interface IVehiculoService
    {
        Vehiculo GetVehiculo(int id);

        string Arrancar();
    }
}
