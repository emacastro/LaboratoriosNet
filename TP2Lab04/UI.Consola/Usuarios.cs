using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;

namespace UI.Consola
{
    public class Usuarios
    {
        public Business.Logic.UsuarioLogic UsuarioNegocio { get; set; }

        public Usuarios()
        {
            UsuarioNegocio = new Business.Logic.UsuarioLogic();
        }

        public void Menu()
        {
            bool continuar = true;
            do
            {
                Console.Clear();
                Console.WriteLine("1- Listado General.");
                Console.WriteLine("2- Consulta.");
                Console.WriteLine("3- Agregar.");
                Console.WriteLine("4- Modificar.");
                Console.WriteLine("5- Eliminar.");
                Console.WriteLine("6- Salir.");

                int num = Int32.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1: this.ListadoGeneral();
                        break;
                    case 2: this.Consultar();
                        break;
                    case 3: this.Agregar();
                        break;
                    case 4: this.Modificar();
                        break;
                    case 5: this.Eliminar();
                        break;
                    case 6: continuar = false;
                        break;
                }
            } while (continuar);
        }
        public void ListadoGeneral()
        {
            Console.Clear();
            foreach (Usuario usr in UsuarioNegocio.GetAll())
            {
                MostrarDatos(usr);
            }
            Console.ReadKey();
        }

        public void MostrarDatos(Usuario usr)
        {
            Console.WriteLine("Usuario: {0}", usr.ID);
            Console.WriteLine("\t\tNombre: {0}", usr.Nombre);
            Console.WriteLine("\t\tApellido: {0}", usr.Apellido);
            Console.WriteLine("\t\tNombre de Usuario: {0}", usr.NombreUsuario);
            Console.WriteLine("\t\tClave: {0}", usr.Clave);
            Console.WriteLine("\t\tEmail: {0}", usr.Email);
            Console.WriteLine("\t\tHabilitado: {0}", usr.Habilitado);
            Console.WriteLine();
        }

        public void Consultar()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Ingrese el Id del usuario a consultar:");
                int ID = int.Parse(Console.ReadLine());
                this.MostrarDatos(UsuarioNegocio.GetOne(ID));
            }
            catch (FormatException fe)
            {
                Console.WriteLine();
                Console.WriteLine("La id ingresada debe ser un numero entero.");
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar.");
                Console.ReadKey();
            }
        }

        public void Modificar()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Ingrese el id del usuario a modificar:");
                int ID = int.Parse(Console.ReadLine());
                Usuario usuario = UsuarioNegocio.GetOne(ID);
                Console.WriteLine("Ingrese nombre:");
                usuario.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese apellido:");
                usuario.Apellido = Console.ReadLine();
                Console.WriteLine("Ingrese nombre de usuario:");
                usuario.NombreUsuario = Console.ReadLine();
                Console.WriteLine("Ingrese clave:");
                usuario.Clave = Console.ReadLine();
                Console.WriteLine("Ingrese email:");
                usuario.Email = Console.ReadLine();
                Console.WriteLine("Ingrese Habilitacion de usuario (1-Si/ otro-No): ");
                usuario.Habilitado = (Console.ReadLine()=="1");
                usuario.State = BusinessEntity.States.Modified;
                UsuarioNegocio.Save(usuario);
            }
            catch (FormatException fe)
            {
                Console.WriteLine();
                Console.WriteLine("La id ingresada debe ser un numero entero.");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar.");
                Console.ReadKey();
            }
        }

        public void Agregar()
        {
            Usuario usuario = new Usuario();

            Console.Clear();
            Console.WriteLine("Ingrese nombre:");
            usuario.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese apellido:");
            usuario.Apellido = Console.ReadLine();
            Console.WriteLine("Ingrese nombre de usuario:");
            usuario.NombreUsuario = Console.ReadLine();
            Console.WriteLine("Ingrese clave:");
            usuario.Clave = Console.ReadLine();
            Console.WriteLine("Ingrese email:");
            usuario.Email = Console.ReadLine();
            Console.WriteLine("Ingrese Habilitacion de usuario (1-Si/ otro-No): ");
            usuario.Habilitado = (Console.ReadLine() == "1");
            usuario.State = BusinessEntity.States.New;
            UsuarioNegocio.Save(usuario);
            Console.WriteLine();
            Console.WriteLine("ID: {0}", usuario.ID);
            Console.ReadKey();
        }

        public void Eliminar()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Ingrese el Id del usuario a eliminar: ");
                int ID = int.Parse(Console.ReadLine());
                UsuarioNegocio.Delete(ID);
            }
            catch (FormatException fe)
            {
                Console.WriteLine();
                Console.WriteLine("La id ingresada debe ser un numero entero.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar.");
                Console.ReadKey();
            }
        }
    }
}
