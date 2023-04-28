using Retos;
using System.Data;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

internal class Program
{
    static int initYear = 2023;
    static int finalYear = 2025;
    static int daysInYear = 12;
    static DateTime date;
    static DayOfWeek dayOfWeekToCheck = DayOfWeek.Friday;
    static int dayToCheck = 13;
    static int cont = 0;

    static int dineroGanado = 0;
    static int dineroPerdido = 0;
    static int paso = 1;

    static Dictionary<int, string> ruleta = new Dictionary<int, string>()
        {
            {0, "Green"},
            {32, "Red"},
            {15, "Black"},
            {19, "Red"},
            {4, "Black"},
            {21, "Red"},
            {2, "Black"},
            {25, "Red"},
            {17, "Black"},
            {34, "Red"},
            {6, "Black"},
            {27, "Red"},
            {13, "Black"},
            {36, "Red"},
            {11, "Black"},
            {30, "Red"},
            {8, "Black"},
            {23, "Red"},
            {10, "Black"},
            {5, "Red"},
            {24, "Black"},
            {16, "Red"},
            {33, "Black"},
            {1, "Red"},
            {20, "Black"},
            {14, "Red"},
            {31, "Black"},
            {9, "Red"},
            {22, "Black"},
            {18, "Red"},
            {29, "Black"},
            {7, "Red"},
            {28, "Black"},
            {12, "Red"},
            {35, "Black"},
            {3, "Red"},
            {26, "Black"}
        };

    private static void Main(string[] args)
    {
        //Reto 12: Viernes 13
        //CalculateDates();

        //Reto 13: Casino
        Casino();
    }

    private static void Casino()
    {


        int[] contador = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        int randomNumber;
        int par = 0, impar = 0;
        int rojo = 0, negro = 0, verde = 0;
        int numTiradas = 1000;


        Martingale(1);

        for (int i = 0; i <= numTiradas; i++)
        {
            var random = new Random();
            randomNumber = random.Next(0, 37);

            //-----------ESTADISTICAS------------
            //contador de numeros
            contador[randomNumber] = contador[randomNumber] + 1;

            //contador de par o impar
            if (randomNumber % 2 == 0)
            {
                if (randomNumber == 0)
                {
                    impar++;
                }
                par++;
            }
            else
            {
                impar++;
            }

            //contador de color
            ruleta.TryGetValue(randomNumber, out var color);
            if (color == "Black")
            {
                negro++;

            }
            else if (color == "Red")
            {
                rojo++;
            }
            else
            {
                verde++;
            }
        }

        //mostramos estadisticas
        Console.WriteLine("PARES: " + par + " --> " + getPorcentaje(par, numTiradas) + "%");
        Console.WriteLine("IMPARES: " + impar + " --> " + getPorcentaje(impar, numTiradas) + "%");

        Console.ReadKey();
        Console.WriteLine();

        Console.WriteLine("ROJO: " + rojo + " --> " + getPorcentaje(rojo, numTiradas) + "%");
        Console.WriteLine("NEGRO: " + negro + " --> " + getPorcentaje(negro, numTiradas) + "%");
        Console.WriteLine("VERDE: " + verde + " --> " + getPorcentaje(verde, numTiradas) + "%");

        Console.ReadKey();
        Console.WriteLine();

        for (int i = 0; i < contador.Length; i++)
        {
            Console.WriteLine("Numero: " + i + " ha salido: " + contador[i] + " veces --> " + getPorcentaje(contador[i], numTiradas) + "%");
        }

        Console.ReadKey();


    }

    private static void Martingale(int dinero)
    {
            if (paso == 5)
            {
                Console.WriteLine("Dinero Ganado: " + dineroGanado);
                Console.WriteLine("Dinero Perdido: " + dineroPerdido);
                Console.ReadKey();
            }

            var random = new Random();
            int randomNumber = random.Next(0, 37);

            ruleta.TryGetValue(randomNumber, out var salida);

            if (salida == "Black")
            {
                dineroGanado += dinero * 2;
             Martingale(1);
            }
            else
            {
                dineroPerdido += dinero;
                paso++;
                Martingale(dinero * 2);
            }
    }

    private static string getPorcentaje(int num, int total)
    {
        decimal x = (decimal)num / (decimal)total;
        return (x * 100).ToString("N2");
    }

    private static void CalculateDates()
    {
        for (int year = initYear; year <= finalYear; year++)
        {
            for (int i = 1; i <= daysInYear; i++)
            {
                for (int j = 1; j <= DateTime.DaysInMonth(year, i); j++)
                {
                    date = new DateTime(year, i, j);

                    if (date.DayOfWeek == dayOfWeekToCheck && j == dayToCheck)
                    {
                        cont++;
                        Console.WriteLine("The " + date.ToString("d") + " is " + dayOfWeekToCheck + " " + dayToCheck + " in " + year);
                    }
                }
            }
        }

        Console.WriteLine("\nEnd");
        Console.WriteLine("Number of counts: " + cont);
        Console.ReadKey();
    }
}