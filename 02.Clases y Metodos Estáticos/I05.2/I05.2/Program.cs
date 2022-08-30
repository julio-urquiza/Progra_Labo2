//Crear una aplicación de consola que permita al usuario ingresar un número entero.
//Desarrollar un método estático que reciba un número y devuelva la tabla de 
//multiplicación de ese número en formato string.
//Se deberá utilizar la clase StringBuilder combinada con strings interpolados 
//para armar el resultado.
//Mostrar en la consola el resultado.

using System;
using Biblioteca;
namespace Vistas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("ingrese un numero: ");
            numero=int.Parse(Console.ReadLine());

            Console.WriteLine($"La tabla del numero {numero} es:");
            Console.WriteLine(Calculadora.TablasDeMultiplicar(numero));

            Console.ReadLine();
        }

    }
}
