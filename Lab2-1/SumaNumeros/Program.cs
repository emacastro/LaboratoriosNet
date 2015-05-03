using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Sumar dos numeros y dar el resultado.
             */

            Console.WriteLine("Ingrese el primer número");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            int num2 = Int32.Parse(Console.ReadLine());
            int suma = num1 + num2;
            Console.WriteLine("El resultado de la suma de " + num1 + " y de " + num2 + " es: " + suma);
            Console.ReadKey();
        }
    }
}
