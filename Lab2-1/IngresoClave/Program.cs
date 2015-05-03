using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngresoClave
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ingreso de clave hasta 4 veces
             */
            string clave = "holasoyunaclave";
            int intentos = 0;
            bool correcto = false;
            while (intentos < 4 && correcto == false)
            {
                intentos++;
                Console.WriteLine("Introduzca clave:");
                string prueba = Console.ReadLine();
                if (clave.Equals(prueba))
                {
                    correcto = true;
                }
                else
                {
                    Console.WriteLine("Clave Incorrecta.");
                }
            }
            if (intentos == 4)
            {
                Console.WriteLine("Se terminaron las oportunidades.");
            }
            else
            {
                Console.WriteLine("Clave Correcta. Bienvenido");
            }
            Console.ReadKey();
        }
    }
}
