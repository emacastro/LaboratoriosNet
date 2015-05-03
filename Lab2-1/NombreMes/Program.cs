using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NombreMes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Indica numero del mes ingresado.
             */

            string[] meses = new String[] { "enero", "febrero", "marzo", "abril", "mayo", "junio", "julio", "agosto", "septiembre", "octubre", "noviembre", "diciembre" };
            Console.WriteLine("Ingrese nombre del mes:");
            string mes = Console.ReadLine();
            for (int i = 0; i < meses.Length; i++)
            {
                if (mes.Equals(meses[i], StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Nombre mes: " + mes + ", numero mes: " + (i + 1));
                }
            }

            Console.ReadKey();
        }
    }
}
