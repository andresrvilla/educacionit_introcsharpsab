using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su edad:");
            string edadIngresada = Console.ReadLine();
            int edad = Convert.ToInt32(edadIngresada);

            /*
             OPERADORES DE COMPARACION
            == "Igualdad de comparación"
            != "Distinto"
            >  mayor
            <  menor
            >= mayor o igual
            <= menor o igual

            ValorUno OPERADOR ValorDos
             */
            if (edad >= 18)
            {
                Console.WriteLine("Usted es mayor de edad y puede participar");
            }
            else //El bloque else es opcional
            {
                Console.WriteLine("Usted no puede participar del concurso");
            }

            Console.ReadKey();
        }
    }
}
