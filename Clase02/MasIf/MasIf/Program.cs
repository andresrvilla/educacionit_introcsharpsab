using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasIf
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * En los strings
             * .ToUpper() //Pasa a mayusculas
             * .ToLower() //Pasa a minusculas
             * .Length //Largo del texto
             */


            /*
             * Supongamos que el concurso es valido para argentina, chile y uruguay
             * Solo participan mayores de edad
             * Y en en chile la mayoría de edad es a los 21
             */

            Console.Write("Ingrese su pais (AR,CH,UY):");
            string pais = Console.ReadLine();
            Console.Write("Ingrese su edad:");
            string edadIngresada = Console.ReadLine();
            int edad = Convert.ToInt32(edadIngresada);
            
            /*
             * OPERADORES LOGICOS
             * && "y logico"
             * || "o logico"
             * !  "no logico"
             */

            if (edad >= 21 && pais.ToUpper() == "CH")
            {
                Console.WriteLine("Es mayor de edad. Puede participar.");
            }
            else if (pais.ToUpper() != "CH" && edad >= 18)
            {
                Console.WriteLine("Es mayor de edad. Puede participar.");
            }
            else
            {
                Console.WriteLine("No puede participar");
            }

            Console.ReadKey();
        }
    }
}
