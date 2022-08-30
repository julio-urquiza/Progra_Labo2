using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre = "julio";
            int edad = 22; //se puede poner dinamic o object
            // Declarar y asignar una variable del tipo string.
            // Calcular su longitud.
            // Si es mayor a 5 mostrar 'Es mayor a 5'
            // De lo contrario mostrar 'Es menor a 5'
            // Si es igual a 5 mostrar 'Es igual a 5'

            //Console.BackgroundColor = ConsoleColor.Blue;
            //Console.ForegroundColor = ConsoleColor.Red;
            Console.Beep();

            Console.WriteLine("hola {0} y tego {1}", nombre, edad);
            string cadena = Console.ReadLine();
            int numero;
            int.TryParse(cadena,out numero);
            Console.WriteLine(numero);
            if (numero > 5)
            {
                Console.WriteLine("es mayor a 5");
            }
            else if (numero< 5)
            {
                Console.WriteLine("es menor a 5");
            }
            else
            {
                Console.WriteLine("es igual a 5");
            }
            // Cambiar el color de fondo de la consola a azul
            // Cambiar la letra de la consola a blanco
            // Hacer un beep al iniciar el programa





            Console.ReadKey();

        }
    }
}
