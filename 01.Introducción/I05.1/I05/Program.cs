using System;

namespace I05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Un centro numérico es un número que separa una lista de números enteros
            //(comenzando en 1) en dos grupos de números, cuyas sumas son iguales
            //El primer centro numérico es el 6, el cual separa la lista(1 a 8) en los grupos:
            //(1; 2; 3; 4; 5) y(7; 8) cuyas sumas son ambas iguales a 15.
            //El segundo centro numérico es el 35, el cual separa la lista(1 a 49) en los grupos:
            //(1 a 34) y(36 a 49) cuyas sumas son ambas iguales a 595
            //Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y
            //el número que el usuario ingrese por consola.
            int numero;
            int acumulador;
            int acumulador2;

            Console.WriteLine("ingrese numero:");
            numero=int.Parse(Console.ReadLine());

            for (int i = 1; i <=numero; i++)
            {
                acumulador = 0;
                for (int j = 1; j <= i; j++)
                {
                    acumulador += j;
                }   
                acumulador2 = 0;
                for (int j = i; acumulador2 <= acumulador; j++)
                {
                    acumulador2 += j;
                    if (acumulador2 == acumulador && acumulador!=1)
                    {
                        Console.Write(i);
                        Console.WriteLine(" es centro numerico");
                    }
                }
            }
            Console.ReadLine();
        }

    }
}
