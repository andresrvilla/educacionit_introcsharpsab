using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoTernarios
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal IVAREDUCIDO = 10.5m;
            const decimal IVACOMPLETO = 21;

            Console.WriteLine("***************************");
            Console.WriteLine("******* FACTURACION *******");
            Console.WriteLine("***************************");

            Console.Write("Por favor ingrese el nombre del producto: ");
            string nombreProducto = Console.ReadLine();
            Console.Write("Por favor ingrese el precio de lista del producto: ");
            string costoProducto = Console.ReadLine();
            decimal costo = Convert.ToDecimal(costoProducto);
            Console.WriteLine("Por favor ingrese el tipo de IVA que corresponde al producto");
            Console.WriteLine("1) IVA de " + IVAREDUCIDO + "%");
            Console.WriteLine("2) IVA de " + IVACOMPLETO + "%");
            string opcionIva = Console.ReadLine();

            /*decimal iva = 0;
            if (opcionIva == "1")
            {
                iva = IVAREDUCIDO;
            }
            else
            {
                iva = IVACOMPLETO;
            }*/

            //CONDICIONAL TERNARIO
            // CONDICION ? VALOR_SI_VERDADERA : VALOR_SI_FALSA

            decimal iva = opcionIva == "1" ? IVAREDUCIDO : IVACOMPLETO;

            decimal costoFinal = (costo * iva / 100) + costo;
            Console.WriteLine("Producto {0}. Precio de Lista: ${1}. Precio final: ${2}", nombreProducto, costo, costoFinal);
            Console.WriteLine("Gracias por usar el sistema de facturación");
            Console.ReadKey();

        }
    }
}
