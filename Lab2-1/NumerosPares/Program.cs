using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosPares
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Números pares entre 1 y 100.
             */

            for (int i = 1; i < 101; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
