using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaValores
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ingrese un numero:");
            string textoUno = Console.ReadLine();
            Console.Write("Ingrese otro numero:");
            string textoDos = Console.ReadLine();
            
            int valorA = Convert.ToInt32(textoUno);
            int valorB = Convert.ToInt32(textoDos);

            int resultado = valorA + valorB;

            Console.WriteLine("El resultado de la suma es " + resultado);
            Console.ReadKey();
        }
    }
}
