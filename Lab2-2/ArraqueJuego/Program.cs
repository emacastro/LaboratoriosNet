using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdivinarNumero;

namespace ArraqueJuego
{
    class Program
    {
        static void Main(string[] args)
        {
            Juego juego = new Juego();
            juego.ComenzarJuego();

            Console.WriteLine("Presione una tecla para terminar.");
            Console.ReadKey();
        }
    }
}
