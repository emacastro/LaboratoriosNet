using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdivinarNumero
{
    class Jugada
    {
        bool _adivino;
        int _intentos;
        int _numero;
        public int Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        public int Intentos { get { return _intentos; } set { _intentos = value; } }
        public bool Adivino { get { return _adivino; } set { _adivino = value; } }
        public Jugada(int maxNumero)
        {
            Random rnd = new Random();
            Numero = rnd.Next(maxNumero);
        }

        public void Comparar(int numero)
        {
            /*
             Con este metodo comparo los valores de cada jugada.
             */
            
            if(numero == Numero){
                Adivino = true;
            }
            _intentos++;
        }
    }
}
