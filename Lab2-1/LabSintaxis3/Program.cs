using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Rellenar un arreglo y recorrerlo.
             */
            int cantIteraciones = 5;
            string[] arreglo = new String[cantIteraciones];
            for (int i = 0; i < cantIteraciones; i++)
            {
                arreglo[i] = "posicion " + i;
            }
            for (int i = cantIteraciones - 1; i > -1; i--)
            {
                Console.WriteLine(arreglo[i]);
            }
            Console.ReadKey();
        }
    }
}
