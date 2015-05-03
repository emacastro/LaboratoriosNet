using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Calcula la serie de Fibonacci hasta cierto numero de posicion (Por ahora muestra el numero de la posicion).
             */
            Console.WriteLine("Serie de Fibonacci");
            Console.WriteLine("Cuantos digitos deseas calcular?");
            int num = Int32.Parse(Console.ReadLine());
            fib(num);
            Console.ReadKey();
        }

        static void fib(int n)
        {
            long i, b1 = 1, b2 = 1, aux;
            for (i = 1; i <= n; i++)
            {
                aux = b2;
                Console.WriteLine("{0} + {1} = {2} ", b1, b2, b1 + b2);
                b2 = b1 + b2;
                b1 = aux;
            }
        }
    }
}
