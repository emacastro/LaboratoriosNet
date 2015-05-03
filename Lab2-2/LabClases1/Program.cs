using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace LabClases1
{
    class Program
    {
        static void Main(string[] args)
        {
            A objetoA = new A();
            B objetoB = new B();
            objetoA.MostrarNombre();
            objetoA.M1();
            objetoA.M2();
            objetoA.M3();
            objetoB.MostrarNombre();
            objetoB.M1();
            objetoB.M2();
            objetoB.M3();
            objetoB.M4();
            Console.ReadKey();
        }
    }
}
