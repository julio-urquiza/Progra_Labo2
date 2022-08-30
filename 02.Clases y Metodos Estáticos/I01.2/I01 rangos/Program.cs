using System;
using Biblioteca;
namespace I01_rangos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int maximo = int.MinValue;
            int minimo = int.MaxValue;
            int acumulador = 0;
            float promedio;

            for (int i = 0; i < 10; i++)
            {
                do
                {
                    Console.Write("Ingrese un numero: ");
                    numero = int.Parse(Console.ReadLine());

                } while (Validador.Validar(numero, -100, 100));
                
                acumulador += numero;
                maximo = Math.Max(maximo, numero);
                minimo = Math.Min(minimo, numero);

            }
            promedio = acumulador /10;
            Console.WriteLine($"El maximo es {maximo}");
            Console.WriteLine($"El minimo es {minimo}");
            Console.WriteLine($"El promedio es {promedio}");


            Console.ReadLine();
        }
    }
}
