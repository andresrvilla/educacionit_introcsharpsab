using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosBucleFor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enumerar del 1 al 10
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            for(int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
