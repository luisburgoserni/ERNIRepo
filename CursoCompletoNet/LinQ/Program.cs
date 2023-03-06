using LinQ;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] scores = new int[] { 12, 14, 16, 22, 18, 44 };

        IEnumerable<int> scoreQuery =
            from score in scores
            where score > 14
            select score;

        foreach (int i in scoreQuery)
        {
            Console.Write(i + " ");
        }

        List <Libro> libros = Libro.GetLibros();

        var titulosLibros = libros.Select(x => x.Titulo);

        foreach (var titulos in titulosLibros)
        {
            Console.WriteLine(titulos);
        }

        var fechaSalida = libros.Where(x => x.FechaSalida > DateTime.Now.AddYears(-2))
            .Select(x => x.ISBN);

        foreach (var fs in fechaSalida)
        {
            Console.WriteLine(fs);
        }

        Console.ReadKey();

        var librosListados = from l in libros;


    }
}