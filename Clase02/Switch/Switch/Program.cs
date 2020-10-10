using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su pais (AR,CH,CL,UY,PA,BO,VE,BR,PE)");
            string pais = Console.ReadLine();
            pais = pais.ToUpper();

            /*if (pais == "AR")
            {
                Console.WriteLine("Su pais es Argentina");
            }
            else if (pais == "CH")
            {
                Console.WriteLine("Su pais es Chile");
            }
            else if (pais == "UY")
            {
                Console.WriteLine("Su pais es uruguay");
            }
            else
            {
                Console.WriteLine("No se ha ingresado un pais disponible");
            }*/

            switch (pais)
            {
                case "AR": // "Inicio de bloque"
                    Console.WriteLine("Su pais es Argentina");
                    break; // "Fin del bloque"
                case "CH":
                case "CL":
                    Console.WriteLine("Su pais es Chile");
                    break;
                case "UY":
                    Console.WriteLine("Su pais es uruguay");
                    break;
                default:
                    Console.WriteLine("No se ha ingresado un pais disponible");
                    break;
            }
        }
    }
}
