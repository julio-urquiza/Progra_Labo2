using System;
using Biblioteca;
namespace A01._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int resultado;
            Console.WriteLine("Ingrese el numero que desea sacar el factorial: ");
            numero = int.Parse(Console.ReadLine());

            resultado=Operaciones.Factorial(numero);

            Console.WriteLine("El resultado es: {0}",resultado);

            Console.ReadLine();
        }
    }
}
