using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre; // Cadena de caracteres, "texto"
            nombre = "Andres"; // Asignacion

            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Su nombre es {0}", nombre);

            const double PI = 3.1415926; // Esto es una constante
            double radio = 4; // Esto es una variable

            Console.WriteLine("El perimetro de una circunferencia de radio {0} es {1}", radio, 2 * PI * radio);


            int hoy = 2020;
            int nacimiento = 1998;

            int edad = hoy - nacimiento;

            Console.WriteLine("La edad es {0}", edad);

            Console.ReadKey();
        }
    }
}
