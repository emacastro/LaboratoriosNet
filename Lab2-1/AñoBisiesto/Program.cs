using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AñoBisiesto
{
    class Program
    {
        static void Main(string[] args)
        {/*
             Pide un año y averigua si es bisiesto.
             */

            Console.WriteLine("Ingrese año:");
            int año = Int32.Parse(Console.ReadLine());
            if (año % 4 == 0)
            {
                if (año % 100 == 0)
                {
                    if (año % 400 == 0)
                    {
                        Console.WriteLine("El año es bisiesto.");
                    }
                    else
                    {
                        Console.WriteLine("El año no es bisiesto.");
                    }
                }
                else
                {
                    Console.WriteLine("El año es bisiesto.");
                }
            }

            Console.ReadKey();
        }
    }
}
