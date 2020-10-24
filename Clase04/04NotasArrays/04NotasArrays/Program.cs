using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04NotasArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = new string[] { "HTML", "CSS", "Javascript", "CSharp" };
            valores[3] = "Java";
            //valores[4] = "Python"; Genera un error porque la posicion 4 no existe

            for (int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine(valores[i]);
            }

            // ¿Como hago para poder agregar python al array?

            string[] aux = new string[valores.Length + 1];

            for (int i = 0; i < valores.Length; i++)
            {
                aux[i] = valores[i];
            }

            aux[aux.Length - 1] = "Python";

            valores = aux;

            for (int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine(valores[i]);
            }

            Console.ReadKey();

        }
    }
}
