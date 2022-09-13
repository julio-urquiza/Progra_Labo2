using System;
using System.Collections.Generic;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crear una aplicación de consola que cargue 20 números enteros(positivos y negativos) distintos de cero de forma aleatoria utilizando la clase Random.
            Mostrar el vector tal como fue ingresado.
            Luego mostrar los positivos ordenados en forma decreciente.
            Por último, mostrar los negativos ordenados en forma creciente.*/

            List<int> lista = new List<int>();

            Random random = new Random(20);

            for (int i = 0; i < 20; i++)
            {
                lista.Add(random.Next(-10,11));
            }
            Console.WriteLine("lista desordenada");
            foreach(int numero in lista)
            {
                Console.WriteLine(numero);
            }
            Console.WriteLine("lista ordenada");

            lista.Sort();
            lista.Reverse();
            foreach(int numero in lista)
            {
                if(numero > 0)
                {
                    Console.WriteLine(numero);
                }
            }
            foreach (int numero in lista)
            {
                if (numero < 0)
                {
                    Console.WriteLine(numero);
                }
            }

            Console.ReadKey();
            
        }
    }
}
