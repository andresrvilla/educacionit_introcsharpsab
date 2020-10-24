using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[] { 100, 35, 75, 98, 411, 0, 15, 64, 85, 341 };

            //Ejemplo 1
            Console.WriteLine("***************************");
            Console.WriteLine("Suma de numeros del array");

            int suma = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                suma += numeros[i];
            }
            Console.WriteLine("La suma de los valores del array es " + suma);

            //Ejemplo 2
            Console.WriteLine("***************************");
            Console.WriteLine("Suma de numeros del array");

            // TipoDato var1,var2,var3;
            // TipoDato var1;
            // TipoDato var2;
            int minimo = numeros[0], maximo = numeros[0];

            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] < minimo)
                {
                    minimo = numeros[i];
                }

                if(numeros[i] > maximo)
                {
                    maximo = numeros[i];
                }   
            }
            Console.WriteLine("El numero maximo del array es " + maximo + ". El numero minimo del array es " + minimo);

            // Ejemplo 3
            Console.WriteLine("***************************");
            Console.WriteLine("Promedio de numeros del array");

            int sumaPromedio = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                sumaPromedio += numeros[i];
            }

            Console.WriteLine("El promedio de los numeros del array " + ( sumaPromedio / numeros.Length));

            Console.ReadKey();
        }
    }
}
