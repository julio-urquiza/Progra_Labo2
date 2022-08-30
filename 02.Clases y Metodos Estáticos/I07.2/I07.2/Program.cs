//Crear una aplicación de consola que pida al usuario ingresar la base y
//la altura de un triángulo en centímetros.
//El programa deberá calcular la longitud de la hipotenusa aplicando el teorema de pitágoras y
//Usar los métodos Pow y Sqrt de la clase Math para realizar los cálculos.
//Mostrar el resultado en la consola.

using System;
using Biblioteca;
namespace I07._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bases;
            double altura;
            double resultado;

            Console.WriteLine("ingrese la base del triangulo");
            bases = double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese la altura del triangulo");
            altura = double.Parse(Console.ReadLine());

            resultado=Calculadora.CalcularHipotenusa(bases,altura);
            Console.WriteLine($"el resultado es {resultado}");

            Console.ReadLine();
        }
    }
}
