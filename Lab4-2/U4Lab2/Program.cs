using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U4Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            ManejadorArchivo manejadorArchivo;
            Console.WriteLine("Elija el modo:");
            Console.WriteLine("1- TXT");
            Console.WriteLine("2- XML");
            if (Console.ReadLine() == "2")
            {
                manejadorArchivo = new ManejadorArchivoTxt();
            }
            else
            {
                manejadorArchivo = new ManejadorArchivoXml();
            }
            manejadorArchivo.listar();
            menu(manejadorArchivo);
        }

        public static void menu(ManejadorArchivo manejadorArchivo)
        {
            string rta="";
            do
            {
                Console.WriteLine("1 - Listar");
                Console.WriteLine("2 - Agregar");
                Console.WriteLine("3 - Modificar");
                Console.WriteLine("4 - Eliminar");
                Console.WriteLine("5 - Guardar Cambios");
                Console.WriteLine("6 - Salir");
                rta = Console.ReadLine();
                switch (rta)
                {
                    case "1":
                        manejadorArchivo.listar();
                        break;
                    case "2":
                        manejadorArchivo.nuevaFila();
                        break;
                    case "3":
                        manejadorArchivo.editarFila();
                        break;
                    case "4":
                        manejadorArchivo.eliminarFila();
                        break;
                    case "5":
                        manejadorArchivo.aplicaCambios();
                        break;
                    default:
                        break;
                }
            } while (rta != "6");
        }
    }

 }
