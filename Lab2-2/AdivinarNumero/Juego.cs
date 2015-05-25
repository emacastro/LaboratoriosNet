using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdivinarNumero
{
    public class Juego
    {
        int _record;
        public Juego()
        {
            _record = 0;
        }
        public void ComenzarJuego()
        {
            /*
             Este método es el controlador.
             */
            bool inicio = true;
            int maximo = PreguntarMaximo();
            JugadaConAyuda jugada = new JugadaConAyuda(maximo);
            bool continuar;
            do{
                int numero = PreguntarNumero();
                if (jugada.Comparar(numero))
                {
                    Console.WriteLine("Felicidades! Adivinó el número.");
                    Console.WriteLine("El numero era: " + jugada.Numero);
                    CompararRecord(jugada.Intentos, inicio);                    
                    continuar = false;
                }
                else
                {
                    Console.WriteLine("No es el número correcto. Vuelva a intentarlo.");
                    continuar = Continuar();
                }
            } while (continuar); 
        }

        private void CompararRecord(int intentos, bool primero)
        {
            /*
             Compara si la cantidad de intentos es menor al record, avisa si lo superó.
             */
            if (primero == true)
            {
                _record = intentos;
                Console.WriteLine("Felicidades! Consiguió un nuevo record con " + _record + " intentos!");
                primero = false;
            }
            else
            {
                if (intentos < _record)
                {
                    Console.WriteLine("Felicidades! Consiguió un nuevo record con " + intentos + " intentos!");
                    _record = intentos;
                }
            }
        }
        private bool Continuar()
        {
            /*
             Pregunta si desea continuar.
             */
            bool continuar = false;
            Console.WriteLine("Desea continuar? s/n");
            string rta = Console.ReadLine();
            
                if(rta.Equals("s", StringComparison.InvariantCultureIgnoreCase)){
                    continuar = true;
                }
                else {
                    continuar = false;
                }
            return continuar;
        }
        private int PreguntarMaximo()
        {
            /*
             Pregunta al usuario qué numero máximo usar para adivinar.
             */
             Console.WriteLine("Qué número máximo elige para adivinar?");
             int maximo = Int32.Parse(Console.ReadLine());
             return maximo;
        }

        private int PreguntarNumero()
        {
            /*
             Pregunta al usuario qué número elige.
             */
            Console.WriteLine("Qué número elige para adivinar?");
            int numero = Int32.Parse(Console.ReadLine());
            return numero;
        }

    }
}
