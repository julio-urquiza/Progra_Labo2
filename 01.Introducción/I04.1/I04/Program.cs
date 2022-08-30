using System;

namespace I04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos(excluido el mismo) que son divisores del número.
            //El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
            //Escribir una aplicación que encuentre los 4 primeros números perfectos.

            int acumulador;
            int flag=0;
            for (int j=1;flag<4; j++)
            {
                acumulador = 0;
                for (int i = 1; i < j; i++)//recorro los numeros anteriores a numero para ver sus divisores
                {
                    if (j % i == 0)
                    {
                        acumulador += i;
                    }

                }
                if (j == acumulador)//es perfecto?
                {
                    Console.WriteLine(j);
                    flag++;
                }
            }
            Console.ReadLine();
        }
    }
}
