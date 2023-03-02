using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaerni
{
    internal class Persona
    {
        private string nombre;
        private string apellidos;
        private int edad;

        public Persona(string nombre, string apellidos, int edad) { 
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.edad = edad;
        }

        public Persona()
        {
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public int Edad { get => edad; set => edad = value; }

        public string ToString()
        {
            return "Nombre: " + this.nombre + "\nAPellidos: " + this.apellidos + "\nEdad: " + this.edad.ToString();
        }
    }
}
