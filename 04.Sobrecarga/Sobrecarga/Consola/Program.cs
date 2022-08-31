using System;
using Biblioteca;
namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Producto producto1 = new Producto("alfajor", 150, 100, 1);
            Producto producto2 = new Producto("alfajor", 150, 100, 1);

            producto1.Mostrar(ConsoleColor.Blue);

            Console.WriteLine("Stock total:{0}",producto1+producto2);
            Console.WriteLine("Stock total del primer producto:{0}", producto1 + 10);
            int numero = (int)producto1;
            Console.WriteLine("Casteo Explicito:{0}",numero);
            string cadena = producto1;
            Console.WriteLine("Casteo implicita:{0}",cadena );



            Console.ReadKey();
        }
    }
}
