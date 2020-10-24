using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _02Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] cualquierCosa;

            int[] edades;
            edades = new int[6];
            edades[0] = 10;
            edades[1] = 21;
            edades[2] = 33;
            //edades[3] = 15;
            edades[4] = 22;
            edades[5] = 25;

            Console.WriteLine(edades);

            Console.WriteLine("Recorro el vector");
            for (int i = 0; i < edades.Length; i++)
            {
                Console.WriteLine(edades[i]);
            }
            Console.WriteLine("Recorro el vector de forma inversa");
            for (int i = edades.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(edades[i]);
            }

            Console.ReadKey();
        }
    }
}
