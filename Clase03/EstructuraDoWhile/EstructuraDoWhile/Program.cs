using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumaNotas = 0;
            int totalNotas = 0;
            bool ingresaNota;
            do
            {
                Console.Write("Ingrese una nota: ");
                string notaIngresada = Console.ReadLine();
                int nota = Convert.ToInt32(notaIngresada);
                sumaNotas += nota;
                totalNotas++;

                Console.Write("Desea ingresar otra nota? (S/N)");
                string dato = Console.ReadLine();
                ingresaNota = dato.ToUpper() == "S" ? true : false;
            } while (ingresaNota == true);

            Console.WriteLine("Promedio " + (sumaNotas / totalNotas));
            Console.ReadKey();
        }
    }
}
