using System;
using Geometria;
namespace Vistas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Rectangulo rectangulo = new Rectangulo(new Punto(1, 1), new Punto(4, 4));

            Mostrar(rectangulo);

            Console.ReadLine();
        }
        static void Mostrar(Rectangulo rectangulo)
        {
            Console.WriteLine("El area del rectangulo es: {0}",rectangulo.Area);
            Console.WriteLine("El perimetro del rectangulo es: {0}",rectangulo.Perimetro);
        }
    }
}
