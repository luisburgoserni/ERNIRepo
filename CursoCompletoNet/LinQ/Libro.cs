using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    public class Libro
    {
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaSalida { get; set; }

        public static List<Libro> GetLibros()
        {
            List<Libro> libros = new List<Libro>();

            libros.Add(new Libro
            {
                FechaSalida = DateTime.Now.AddYears(-3),
                ISBN = "8736292",
                Precio = 12.22M,
                Titulo = "El señor de los anillos"
            });

            libros.Add(new Libro
            {
                FechaSalida = DateTime.Now.AddYears(-4),
                ISBN = "56377291",
                Precio = 15.77M,
                Titulo = "El gato con botas"
            });

            libros.Add(new Libro
            {
                FechaSalida = DateTime.Now.AddYears(5),
                ISBN = "78293991",
                Precio = 21.11M,
                Titulo = "Charlie y la fabrica de nueces"
            });

            return libros;

        }
    }
}
