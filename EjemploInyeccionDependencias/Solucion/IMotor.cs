namespace EjemploInyeccionDependencias.Solucion
{
    public interface IMotor
    {
        string Arrancar();
    }

    public class Terrestre : IMotor
    {
        public string Arrancar()
        {
            return "va por el suelo";
        }
    }

    public class Aereo : IMotor
    {
        public string Arrancar()
        {
            return "va por el aire";
        }
    }

    public class Nautico : IMotor
    {
        public string Arrancar()
        {
            return "va por el agua";
        }
    }
}
