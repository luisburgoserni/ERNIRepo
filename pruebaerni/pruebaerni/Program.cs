using System.ComponentModel.Design;

internal class Program
{ 
    private static void Main(string[] args)
    {
        string numerosString = String.Empty;
        List<string> numerosStringArray = new List<string>();
        List<int> numerosArray = new List<int>();

        Console.WriteLine("Introduce los numeros separados por espacios");
        numerosString = Console.ReadLine();

        if (numerosString != string.Empty)
        {
            for (int i = 0; i < numerosString.Length; i++)
            {
                numerosStringArray.Add(numerosString.Substring(i,1));
            }

            if (comprobarNumerosArray(numerosStringArray))
            {
                int suma = 0;

                if (numerosStringArray[0] == " ")
                {
                    for (int i = 1; i < numerosStringArray.Count; i += 2)
                    {
                        suma += int.Parse(numerosStringArray[i]);
                    }
                }
                else
                {
                    for (int i = 0; i < numerosStringArray.Count; i += 2)
                    {
                        suma += int.Parse(numerosStringArray[i]);         
                    }
                }

                Console.WriteLine("La suma es: " + suma);
            }
            else
            {
                Console.WriteLine("NOT OK");
            }
        }     
    }

    private static bool comprobarNumerosArray(List<string> numerosStringArray)
    {
        bool flag = true;

        if (numerosStringArray[0] == " ")
        {
            //comprobamos que hay espacios entre los numeros
            for (int i = 0; i < numerosStringArray.Count; i += 2)
            {
                if (numerosStringArray[i] != " ")
                {
                    flag = false;
                    break;
                }

                int numero;
                try
                {
                    if (!int.TryParse(numerosStringArray[i + 1], out numero))
                    {
                        flag = false;
                        break;
                    }
                }catch (Exception) { }               
            }
        }
        else
        {
            //comprobamos que hay espacios entre los numeros
            for (int i = 1; i < numerosStringArray.Count; i += 2)
            {
                if (numerosStringArray[i] != " ")
                {
                    flag = false;
                    break;
                }

                int numero;
                if (!int.TryParse(numerosStringArray[i + 1], out numero))
                {
                    flag = false;
                    break;
                }
            }
        }
        return flag;
    }
}