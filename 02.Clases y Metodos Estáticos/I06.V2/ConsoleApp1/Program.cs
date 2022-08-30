using System;
using Biblioteca;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            for(int i = 0; i < 10; i++)
            {
                if(int.TryParse(Console.ReadLine(),out numero) && Validador.Validar(numero, -100, 100))
                {
                    Console.WriteLine("El valor ingresado está en el rango de -100 y 100");
                }
                else
                {
                    Console.WriteLine("El valor ingresado no esta en el rango de -100 y 100");
                }

            }
            
        }
    }
}
