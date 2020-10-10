using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondicionalTernario
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad = 20;
            string frase = "";

            /*if (edad >= 18)
            {
                frase = "Es mayor de edad";
            }
            else
            {
                frase = "Es menor de edad";
            }*/

            // CONDICION ? Valor Verdadero : Valor Falso
            frase = edad >= 18 ? "Es mayor de edad" : "Es menor de edad";

            Console.WriteLine(frase);
        }
    }
}
