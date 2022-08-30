using System;
using Biblioteca;

namespace consola
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double AreaCuadrado = CalculadoraDeArea.CalcularAreaCuadrado(20);
            Console.WriteLine("El area del cuadrado es de {0}",AreaCuadrado);

            double AreaTriangulo= CalculadoraDeArea.CalcularAreaTriangulo(7,8);
            Console.WriteLine("El area del triangulo es de {0}",AreaTriangulo);

            double AreaCirculo = CalculadoraDeArea.CalcularAreaCirculo(4);
            Console.WriteLine("El area del circulo es de {0}", AreaCirculo);

            Console.ReadLine();
        }
    }
}
