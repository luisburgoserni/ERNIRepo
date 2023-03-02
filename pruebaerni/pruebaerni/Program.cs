internal class Program
{
    private static void Main(string[] args)
    {
        string palabra = string.Empty;
        bool flag = true;

        do
        {
            palabra = string.Empty;

            Console.WriteLine("Escribe una palabra");
            palabra = Console.ReadLine();

            if (!string.IsNullOrEmpty(palabra))
            {
                if (palabra.Contains(" "))
                {
                    Console.Clear();
                    Console.WriteLine("No es una palabra, es un texto");
                }
                else
                {
                    Console.WriteLine("Palabra guardada");
                    Console.WriteLine(palabra);
                    flag = false;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("No has escrito nada");
            }

        } while (flag);
    }
}