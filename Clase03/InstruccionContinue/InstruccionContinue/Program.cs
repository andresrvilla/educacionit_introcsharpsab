using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstruccionContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 100; i++)
            {
                if(i == 50)
                {
                    continue;
                }

                Console.WriteLine("Iteración " + i);
            }


            Console.ReadKey();
        }
    }
}
