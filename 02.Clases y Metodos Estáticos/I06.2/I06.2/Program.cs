//Realizar una clase llamada CalculadoraDeArea que posea tres métodos
//de clase (estáticos) que realicen el cálculo del área que corresponda:
//public double CalcularAreaCuadrado(double longitudLado) { }
//public double CalcularAreaTriangulo(double base, double altura) { }
//public double CalcularAreaCirculo(double radio) { }
//El ingreso de los datos como la visualización se deberán realizar desde el método Main().

using System;
using Biblioteca;
namespace Vistas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double resultado;
            double valor1;
            double valor2;
            int opcion;

            Console.WriteLine("que desea hacer ");
            Console.WriteLine(  "1.Calcular Area Cuadrado\n" +
                                "2.Calcular Area Triangulo\n" +
                                "3.Calcular Area Circulo");
            opcion =int.Parse(Console.ReadLine()); 
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("ingrese la longitud de un lado del cuadrado:");
                    valor1=double.Parse(Console.ReadLine());
                    resultado=CalculadoraDeArea.CalcularAreaCuadrado(valor1);
                    break;

                case 2:
                    Console.WriteLine("ingrese la longitud de la base del triangulo:");
                    valor1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("ingrese la altura del trinagulo:");
                    valor2 = double.Parse(Console.ReadLine());
                    resultado=CalculadoraDeArea.CalcularAreaTriangulo(valor1, valor2);
                    break;

                case 3:
                    Console.WriteLine("ingrese el radio del circulo:");
                    valor1 = double.Parse(Console.ReadLine());
                    resultado =CalculadoraDeArea.CalcularAreaCirculo(valor1);
                    break;

                default:
                    resultado = 0;
                    break;
            }
            Console.WriteLine($"El resultado es {resultado}");

            Console.ReadLine();
        }
    }
}
