using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03NumeroEsPar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Procedimiento 'Par'";
            Console.WriteLine("Ingrese un numero entero");
            int numero = int.Parse(Console.ReadLine());
            Par(numero);
            Console.ReadKey();

        }

        static void Par(int valor)
        {
            int resto = valor % 2;
            if (resto != 0)
            {
                Console.WriteLine("No es par");
            }
            else
            {
                Console.WriteLine("Es par");
            }
        }
    }
}
