using System;
using Bibioteca;
namespace Vistas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float primerNumero;
            float segundoNumero;
            string resultado;
            char opcion;

            Console.WriteLine("inrgese el primer operando:");
            primerNumero = float.Parse(Console.ReadLine());
            Console.WriteLine("inrgese el segundo operando:");
            segundoNumero= float.Parse(Console.ReadLine());

            Console.WriteLine("inrgese la operacion (+,-,*,/):");
            opcion = char.Parse(Console.ReadLine());

            switch (opcion)
            {
                case '+':
                    resultado = Calculadora.Calcular(primerNumero, segundoNumero, '+');
                    break;
                case '-':
                    resultado = Calculadora.Calcular(primerNumero, segundoNumero, '-');
                    break;
                case '*':
                    resultado = Calculadora.Calcular(primerNumero, segundoNumero, '*');
                    break;
                case '/':
                    resultado = Calculadora.Calcular(primerNumero, segundoNumero, '/');
                    break;
                default:
                    resultado = "ERROR";
                    break;
            }
            Console.WriteLine($"el el resultado es :{resultado}");
            Console.ReadLine();

        }
    }
}
