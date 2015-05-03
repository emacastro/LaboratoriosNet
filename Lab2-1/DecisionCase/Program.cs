using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionCase
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Pide al usuario un texto, surge un menú que indica que hacer con el texto ingresado
             */

            Console.WriteLine("Ingrese un texto y presione enter:");
            string texto = Console.ReadLine();
            if (texto != string.Empty)
            {
                Console.WriteLine();
                Console.WriteLine("MENU:");
                Console.WriteLine("1 - Mayusculas.");
                Console.WriteLine("2 - Minusculas");
                Console.WriteLine("3 - Cantidad de caracteres");
                Console.WriteLine();
                ConsoleKeyInfo opcion = Console.ReadKey();
                switch (opcion.Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine();
                        Console.WriteLine("Texto en mayusculas: " + texto.ToUpper());
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine();
                        Console.WriteLine("Texto en minusculas: " + texto.ToLower());
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine();
                        Console.WriteLine("Cantidad de caracteres: " + texto.Length);
                        break;
                }
            }
            else
            {
                Console.WriteLine("Mal ingreso, presione una tecla para terminar.");
            }
            Console.ReadKey();
        }
    }
}
