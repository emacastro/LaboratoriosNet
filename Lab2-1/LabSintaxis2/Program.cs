using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis2
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
                if (ConsoleKey.D1 == opcion.Key)
                {
                    Console.WriteLine();
                    Console.WriteLine("Texto en mayusculas: " + texto.ToUpper());
                }
                else if (ConsoleKey.D2 == opcion.Key)
                {
                    Console.WriteLine();
                    Console.WriteLine("Texto en minusculas: " + texto.ToLower());
                }
                else if (ConsoleKey.D3 == opcion.Key)
                {
                    Console.WriteLine();
                    Console.WriteLine("Cantidad de caracteres: " + texto.Length);
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
