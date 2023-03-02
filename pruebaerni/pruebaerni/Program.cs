using pruebaerni;
using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        crearPersona();
    }

    private static void crearPersona()
    {
        Persona p = new Persona();
        String texto = string.Empty;

        Console.WriteLine("Escribe el nombre");
        texto = Console.ReadLine();
        if (comprobarTexto(texto))
        {
            p.Nombre = texto;
            Console.WriteLine("Escribe el apellido");
            texto = Console.ReadLine();

            if (comprobarTexto(texto))
            {
                p.Apellidos = texto;
                Console.WriteLine("Escribe la edad");
                texto = Console.ReadLine();

                if (comprobarTexto(texto))
                {
                    p.Edad = Int32.Parse(texto);

                    Console.WriteLine(p.ToString());
                }
            }
        }
    }

    private static bool comprobarTexto(string palabra)
    {

        if (!string.IsNullOrEmpty(palabra))
        {
            if (palabra.Contains(" "))
            {
                Console.WriteLine("No es una palabra, es un texto");
                return false;
            }
            else
            {
                Console.WriteLine("Palabra guardada");
                return true;
            }
        }
        else
        {
            Console.WriteLine("No has escrito nada");
            return false;
        }
    }
}