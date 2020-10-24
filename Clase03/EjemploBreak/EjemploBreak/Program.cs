using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 1000000; i++)
            {
                Console.WriteLine(i);
                if(i == 15)
                {
                    break;
                }
            }

            Console.WriteLine("Fin");

            int limiteEjecuciones = 0;

            while (true == true)
            {
                limiteEjecuciones++;
                if(limiteEjecuciones == 100)
                {
                    break;
                }
            }
            Console.WriteLine("Fin 2");
            Console.ReadKey();
        }
    }
}
