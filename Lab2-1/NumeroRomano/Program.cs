using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroRomano
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Convierte numero a romano.
             */
            Console.WriteLine("Ingrese numero a transformar: ");
            int entero = Int32.Parse(Console.ReadLine());

            int miles = entero / 1000;
            int resmiles = entero % 1000;
            int centenas = resmiles / 100;
            int rescen = resmiles % 100;
            int decenas = rescen / 10;
            int resdec = rescen % 10;
            int unidades = resdec / 1;

            string mil = "";
            string cen = "";
            string dec = "";
            string uni = "";

            switch (miles)
            {
                case 1: mil = "X";
                    break;
                case 2: mil = "XX";
                    break;
                case 3: mil = "XX";
                    break;
            }


            switch (centenas)
            {
                case 1: cen = "C";
                    break;
                case 2: cen = "CC";
                    break;
                case 3: cen = "CCC";
                    break;
                case 4: cen = "CD";
                    break;

                case 5: cen = "D";
                    break;

                case 6: cen = "DC";
                    break;
                case 7: cen = "DCC";
                    break;
                case 8: cen = "DCCC";
                    break;

                case 9: cen = "CM";
                    break;


            }
            switch (decenas)
            {
                case 1: dec = "X";
                    break;
                case 2: dec = "XX";
                    break;
                case 3: dec = "XX";
                    break;
                case 4: dec = "XL";
                    break;

                case 5: dec = "L";
                    break;

                case 6: dec = "LX";
                    break;
                case 7: dec = "LXX";
                    break;
                case 8: dec = "LXXX";
                    break;

                case 9: dec = "XC";
                    break;
            }
            switch (unidades)
            {
                case 1: uni = "I";
                    break;
                case 2: uni = "II";
                    break;
                case 3: uni = "III";
                    break;
                case 4: uni = "IV";
                    break;

                case 5: uni = "V";
                    break;

                case 6: uni = "VI";
                    break;
                case 7: uni = "VII";
                    break;
                case 8: uni = "VIII";
                    break;

                case 9: uni = "IX";
                    break;
            }
            Console.WriteLine();
            Console.WriteLine(mil + cen + dec + uni);
            Console.ReadKey();
        }
    }
}
