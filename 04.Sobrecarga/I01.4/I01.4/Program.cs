using System;
using Biblioteca;
namespace Vistas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador sumador1 = new Sumador();
            Sumador sumador2 = new Sumador(10);
            Sumador sumador3 = new Sumador(11);

            long resultadoLong = sumador1.Sumar(4, 5);
            string resutadoString = sumador2.Sumar("macoco","manito");

            Console.WriteLine("Resultado de Long + Long = {0}",resultadoLong);
            Console.WriteLine("Cantidad de sumas= {0}",(int)sumador1);

            Console.WriteLine("Resultado de Sting + sting = {0}",resutadoString);
            Console.WriteLine("Cantidad de sumas= {0}",(int)sumador2);

            Console.WriteLine("Resultado de la comparacion de sumador1 y sumador2 = {0}", sumador1|sumador2);
            Console.WriteLine("Resultado de la comparacion de sumador2 y sumador3 = {0}", sumador2|sumador3);


            Console.ReadLine();

        }
    }
}
