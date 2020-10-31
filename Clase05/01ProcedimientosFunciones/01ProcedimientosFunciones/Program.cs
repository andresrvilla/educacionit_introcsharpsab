using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _01ProcedimientosFunciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultadoSuma = Sumar(10, 20);
            InformarResultado(resultadoSuma);
            Console.ReadKey();
        }

        static int Sumar(int numeroUno,int numeroDos)
        {
            int resultado = numeroUno + numeroDos;
            return resultado;
        }

        static void InformarResultado(int resultado)
        {
            Console.WriteLine("El resultado es " + resultado);
        }
    }
}
