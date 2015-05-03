using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimosGemelos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             N primos gemelos.
             */
            int num, i, n = 4, cont = 2;
            string cad = "";
            Console.WriteLine("ingrese un numero");
            num = Convert.ToInt32(Console.ReadLine());
            if (num > 2)
            {
                cad = "2 - 3";
                while (cont < num)
                {
                    i = 2;
                    while (i <= n)
                    {
                        if (i == n)
                        {
                            cad = cad + " - " + Convert.ToString(n);
                            cont = cont + 1;
                        }
                        else
                        {
                            if (n % i == 0)
                            {
                                i = n;
                            }
                        }
                        i = i + 1;
                    }
                    n = n + 1;
                }
                Console.WriteLine(cad);
            }
            else
            {
                if (num > 0)
                {
                    if (num == 1)
                    {
                        Console.WriteLine("es primo 2");
                    }
                    else
                    {
                        Console.WriteLine("es primo 2, 3");
                    }
                }
                else
                {
                    Console.WriteLine("ingrese numeros positivos");
                }
            }
            Console.ReadLine();
        }
    }
}
