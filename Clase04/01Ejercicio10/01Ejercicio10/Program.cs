using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            const int PICO = 25;

            for (int i = 1; i <= PICO; i++) // Recorre por lineas
            {
                for (int j = 1; j <= i; j++) //Dibuja los caracteres en base al numero de linea
                {
                    Console.Write("@");
                }
                Console.WriteLine();
                //Esta forma lo hacemos sin el bucle for, aunque el objetivo del ejercicio es practicar el for
                //string estructura = "";
                //estructura = estructura.PadRight(i, '@');
                //Console.WriteLine(estructura);
            }

            for (int i = PICO - 1; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("@");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
