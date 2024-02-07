using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInyectionTest
{
    public class Persona : IPersona
    {
        public void caminar()
        {
            Console.WriteLine("Caminando");
        }

        public void comer()
        {
            Console.WriteLine("Comiendo");
        }

        public void dormir()
        {
            Console.WriteLine("Durmiendo");
        }
    }
}
