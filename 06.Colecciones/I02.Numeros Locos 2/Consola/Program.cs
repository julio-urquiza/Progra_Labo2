using System;
using System.Collections.Generic;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crear una aplicación de consola que cargue en una Lista, Pila y Cola 20 números enteros (positivos y negativos) distintos de cero de forma aleatoria utilizando la clase Random.
            Mostrar la colección tal como fue cargada.
            Luego mostrar los positivos ordenados en forma decreciente.
            Por último, mostrar los negativos ordenados en forma creciente.*/

            Stack<int> stack = new Stack<int>();
            Stack<int> stackOrdenado=new Stack<int>();
            Random random = new Random();
            for(int i = 0; i < 20; i++)
            {
                stack.Push(random.Next(-10,11));
            }
            mostrarStack(stack);
            foreach(int i in stack)
            {

            }



            Console.ReadKey();
        }
        public static void mostrarStack(Stack<int> st)
        {
            foreach(int i in st)
            {
                Console.WriteLine(i);
            }
        }
    }
}
