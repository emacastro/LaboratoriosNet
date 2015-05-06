using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public int Dni { get; set; }

        public Persona(string nombre, string apellido, int edad, int dni)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Dni = dni;
            System.Diagnostics.Trace.WriteLine("Se creó el constructor.");
        }

        ~Persona()
        {
            System.Diagnostics.Trace.WriteLine("Se utilizó el destructor.");
        }

        public string GetFullName()
        {
            return Nombre + " " + Apellido;
        }

        public int GetAge()
        {
            return Edad;
        }
    }
}
