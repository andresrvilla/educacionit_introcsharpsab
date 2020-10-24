using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            ESTRUCTURA WHILE
            
            while (CONDICION)
            {
            }

            Mientras se de la CONDICION se va a ejecutar el bloque de codigo

            */

            Console.WriteLine("LISTA DE COMPRAS");

            Console.Write("Desea ingresar un producto? (S/N)");
            string dato = Console.ReadLine();
            bool sigueIngresando = dato == "S" || dato == "s" ? true : false;

            string resumen = "";

            while(sigueIngresando == true)
            {
                Console.Write("Ingrese el nombre del producto:");
                string producto = Console.ReadLine();
                resumen += producto + Environment.NewLine;

                Console.Write("Desea ingresar otro producto (S/N)");
                dato = Console.ReadLine();
                sigueIngresando = dato.ToUpper() == "S" ? true : false;
            }

            Console.WriteLine("LISTA DE PRODUCTOS FINAL: ");
            Console.WriteLine(resumen);
            Console.Write("Fin del programa");
            Console.ReadKey();
        }
    }
}
