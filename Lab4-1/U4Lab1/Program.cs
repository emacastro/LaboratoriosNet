using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace U4Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*FileStream lector = new FileStream("agenda.txt", FileMode.Open, FileAccess.Read, FileShare.Read);
            while (lector.Length > lector.Position)
            {
                Console.Write((char)lector.ReadByte());
            }
            lector.Close();
            Console.ReadKey();*/

            leer();
            escribir();
            Console.ReadKey();
        }

        private static void leer()
        {
            StreamReader lector = File.OpenText("agenda.txt");
            string linea;
            Console.WriteLine("Nombre\tApellido\te-mail\t\t\tTelefono");
            do
            {
                linea = lector.ReadLine();
                if (linea != null)
                {
                    string[] valores = linea.Split(';');
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}", valores[0], valores[1], valores[2], valores[3]);
                }
            } while (linea != null);
            lector.Close();
        }

        private static void escribir()
        {
            StreamWriter escritor = File.AppendText("agenda.txt");
            Console.WriteLine("Ingrese Contacto.");
            string rta="S";
            while(rta=="S")
            {
                Console.Write("Ingrese Nombre.");
                string nombre = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Ingrese Apellido.");
                string apellido = Console.ReadLine();
                Console.WriteLine(); Console.Write("Ingrese Email.");
                string email = Console.ReadLine();
                Console.WriteLine(); Console.Write("Ingrese Telefono.");
                string telefono = Console.ReadLine();
                Console.WriteLine();
                escritor.WriteLine(nombre + ";" + apellido + ";" + email + ";" + telefono);
                Console.Write("¿Desea ingresar otro contacto? S/N");
                rta = Console.ReadLine();
            }
            escritor.Close();

        }
    }
}
