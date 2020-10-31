using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02PasajesPorValorYReferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            int elValor = 100;
            Console.WriteLine("El valor antes de llamar al metodo es " + elValor);
            ModificarValor(ref elValor);
            Console.WriteLine("El valor despues de llamar al metodo es " + elValor);

            EjemploTipoDeReferencia objeto = new EjemploTipoDeReferencia();
            objeto.valor = 200;
            Console.WriteLine("El valor antes de llamar al metodo es " + objeto.valor);
            ModificarReferencia(objeto);
            Console.WriteLine("El valor despues de llamar al metodo es " + objeto.valor);

            Console.ReadKey();
        }

        static void ModificarValor(ref int valor)
        {
            valor++;
            Console.WriteLine("El valor modificado es " + valor);
        }

        static void ModificarReferencia(EjemploTipoDeReferencia ej)
        {
            ej.valor++;
            Console.WriteLine("El valor modificado es " + ej.valor);
        }
    }

    public class EjemploTipoDeReferencia
    {
        public int valor;
    }
}
