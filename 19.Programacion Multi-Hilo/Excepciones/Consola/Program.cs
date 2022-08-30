using System;
using Biblioteca;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {   /*
            MiClase miclase = new MiClase("que tal");
            int numero=0;
            try
            {
                miclase.Nombre = "    ";
                //todo el codigo debajo no se ejecuta
                numero++;
            }
            catch (NombreInvalidoException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Excepcion generica");
            }

            Console.WriteLine(miclase.Nombre);
            Console.WriteLine(numero);
            */

            string resulatado = MiClaseEstatica.MiMetodoEstaitico("  ");
            Console.WriteLine(resulatado);






            Console.ReadKey();

        }
    }
}
