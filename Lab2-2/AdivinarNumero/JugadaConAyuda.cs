using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdivinarNumero
{
    class JugadaConAyuda:Jugada
    {
        
        public JugadaConAyuda(int maxNumero):base(maxNumero)
        {

        }
        public new bool Comparar(int numero)
        {
            if (numero == Numero)
            {
                Adivino = true;
            }
            else
            {
                if ((Numero - numero) >= 100 && numero > Numero)
                {
                    Console.WriteLine("Estás muy lejos!");
                }
                else if (numero > Numero && (Numero - numero) <= 5)
                {
                    Console.WriteLine("Estás cerca!");
                }
                Adivino = false;
            }
            Intentos++;
            return this.Adivino;
        }
    }
}
