using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05ArreglosBidimensionales
{
    class Program
    {
        static void Main(string[] args)
        {

            // Arreglos bidimensionales o matriz

            string[,] alumnos = new string [3,2];

            alumnos[0, 0] = "Villa";
            alumnos[0, 1] = "Andres";
            alumnos[1, 0] = "Perez";
            alumnos[1, 1] = "Julian";
            alumnos[2, 0] = "Suarez";
            alumnos[2, 1] = "Pedro";

            for (int i = 0; i < alumnos.GetLongLength(0); i++)
            {
                for (int j = 0; j < alumnos.GetLongLength(1); j++)
                {
                    Console.WriteLine(alumnos[i, j]);
                }
            }

            Console.ReadKey();
        }
    }
}
