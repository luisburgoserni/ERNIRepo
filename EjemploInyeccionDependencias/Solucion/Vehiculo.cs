namespace EjemploInyeccionDependencias.Solucion
{
    public class Vehiculo
    {
        protected IMotor _motor;

        public Vehiculo(IMotor motor)
        {
            _motor = motor;
        }

        public string Arrancar()
        {
            return _motor.Arrancar();
        }
    }
}
