using System;
using Biblioteca;
namespace Vistas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char valor;
            int numeros;
            int acumulador=0;

            do
            {
                Console.WriteLine("ingrese un numero:");
                numeros=int.Parse(Console.ReadLine());
                acumulador+=numeros;

                Console.WriteLine("quiere seguir ingresando numeros(s o n):");
                valor = char.Parse(Console.ReadLine());
            }while (Validador.ValidarRespuesta(valor)) ;
            Console.WriteLine(acumulador);
            Console.ReadLine();
           
        }
    }
}
