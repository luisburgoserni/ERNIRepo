using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamsArchivos
{
    public class Archivos
    {
        public Archivos()
        {
            //Modos
            //FileMode.Append
            //FileMode.Create
            //FileMode.CreateNew
            //FileMode.Open
            //FileMode.OpenOrCreate
            //FileMode.Truncate

            FileStream fs = new FileStream("miarchivo.txt", FileMode.Create);

            string cadena = "Esto es una cadena de ejemplo";

            fs.Write(ASCIIEncoding.ASCII.GetBytes(cadena), 0, cadena.Length);
            fs.Close();

            byte[] infoArchivo = new byte[100];

            fs = new FileStream("miarchivo.txt", FileMode.Open);
            fs.Read(infoArchivo, 0, infoArchivo.Length);

            Console.WriteLine(ASCIIEncoding.ASCII.GetString(infoArchivo));
            Console.ReadKey();

            fs.Close();
        }
    }
}
