using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioLaboratorioNumerosPares
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 2;

            while(numero <= 100)
            {
                Console.WriteLine(numero);
                numero += 2;
            }

            Console.ReadKey();
        }
    }
}
