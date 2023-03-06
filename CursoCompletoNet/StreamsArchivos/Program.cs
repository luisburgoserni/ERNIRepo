using StreamsArchivos;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        MemoryStream ms = new MemoryStream(150);
        string informacion = String.Empty;

        var capacidad = ms.Capacity;
        var longitud = ms.Length;
        var posicion = ms.Position;

        byte[] buffer = new byte[50];

        //Pedimos datos
        Console.WriteLine("Introduce la informacion");
        informacion = Console.ReadLine();

        ms.Write(ASCIIEncoding.ASCII.GetBytes(informacion), 0, informacion.Length);
        ms.Seek(0, SeekOrigin.Begin);
        ms.Read(buffer, 0, 5); //desde donde nos encontramos 5 carecteres

        Console.WriteLine(ASCIIEncoding.ASCII.GetString(buffer));

        ms.Close();

        Archivos a = new Archivos();
    }
}