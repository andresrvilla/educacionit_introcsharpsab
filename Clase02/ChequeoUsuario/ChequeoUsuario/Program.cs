using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChequeoUsuario
{
    class Program
    {
        static void Main(string[] args)
        {
            const string usuarioCorrecto = "Pepito", passwordCorrecto = "1234";

            Console.Write("Ingrese su usuario:");
            string usuario = Console.ReadLine();
            Console.Write("Ingrese su contraseña:");
            string contrasena = Console.ReadLine();

            if (usuario.Equals(usuarioCorrecto) && contrasena == passwordCorrecto)
            {
                Console.WriteLine("Bienvenido " + usuarioCorrecto);
            } 
            else if (usuario != usuarioCorrecto && contrasena == passwordCorrecto)
            {
                Console.WriteLine("Usuario incorrecto");
            }
            else if(usuario==usuarioCorrecto && contrasena != passwordCorrecto)
            {
                Console.WriteLine("Contraseña incorrecta");
            }
            else
            {
                Console.WriteLine("Datos incorrectos");
            }

            Console.ReadKey();
        }
    }
}
