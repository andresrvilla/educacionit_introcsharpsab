using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraFor
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             ESTRUCTURA FOR
            for(A;B;C)
            {
            }
            A: Inicialización (Normalmente se inicializa la variable de control)
            B: Condicion que se evalua en cada iteración. Condicion de Continuidad
            C: Modificación que se efectua LUEGO de cada iteración
             */

            Console.Write("¿Cuantas notas quiere ingresar?");
            string dato = Console.ReadLine();
            int cantidadNotas = Convert.ToInt32(dato);

            int sumaNotas = 0;

            for(int i = 0; i < cantidadNotas; i++)
            {
                Console.Write("Por favor ingrese la nota siguiente:");
                dato = Console.ReadLine();
                int nota = Convert.ToInt32(dato);
                sumaNotas += nota;
            }

            Console.WriteLine("El promedio es " + (sumaNotas / cantidadNotas));
            Console.ReadKey();

        }
    }
}
