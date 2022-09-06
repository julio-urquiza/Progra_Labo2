using System;
using Biblioteca;
namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador sumador1= new Sumador();
            Sumador sumador2= new Sumador(2);

            long cantidadSumas = sumador2;

            if(sumador1|sumador2)
            {
                Console.WriteLine("diferente cantidad de sumas");
            }
            else
            {
                Console.WriteLine("igual cantidad de sumas");
            }

            Console.WriteLine(sumador1+sumador2);

            Console.WriteLine(sumador1.Sumar(15,65));
            Console.WriteLine(sumador2.Sumar("papa","pipi"));

            Console.ReadKey();
        }
    }
}
