using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContinuacionVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorUno;
            valorUno = 100;
            int valorDos = 250;

            /*
             * OPERADORES ARITMETICOS
             * + (suma)
             * - (resta)
             * * (multiplicacion)
             * / (division)
             * % (modulo)
             */

            var a = 10 + 20;

            var modulo = valorDos % valorUno;

            Console.WriteLine("El resto de la division entre {0} y {1} es {2}", valorDos, valorUno, modulo);

            /*
             * Concatenación
             * +
             */

            string frase = "El resto de la division entre " + valorDos + " y " + valorUno + " es " + modulo;
            Console.WriteLine(frase);

            /*
             * Asignacion compacta
             */

            int valorA = 10;

            valorA = valorA + 1;
            // es equivalente
            valorA += 1;
            // es equivalente a
            valorA++; // tambien sirve el --

            valorA += 17;


            var compactoMultiplicacion = 100;
            compactoMultiplicacion *= 7; // compactoMultiplicacion = compactoMultiplicacion * 7;
            Console.WriteLine(compactoMultiplicacion);

            var b = 100;
            var c = b++;
            var d = ++b;
            Console.WriteLine("b++ " + c + " ++b " + d);

            bool variableVerdadera = true;
            bool variableFalsa = false;

            Console.ReadKey();
        }
    }
}
