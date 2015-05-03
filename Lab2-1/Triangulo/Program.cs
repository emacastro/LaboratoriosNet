using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Pide un número de filas y dibuja un triángulo.
             */
            Console.WriteLine("Ingrese un número de filas: ");
            int filas = Int32.Parse(Console.ReadLine());
            string asteriscos = "*";
            for (int i=0; i<filas; i++)
            {
                string vacio="";//Tengo que tomar i, no filas
                for (int j=filas-i;j>=0 ;j-- )
                {
                    vacio += " ";
                }
                Console.Write(vacio+asteriscos);
                Console.WriteLine();
                asteriscos += "**";
            }
            Console.ReadKey();
        }
    }
}
