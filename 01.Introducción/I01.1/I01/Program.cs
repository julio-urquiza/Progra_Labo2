using System;

namespace I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int acumulador = 0;
            int maximo=int.MinValue;
            int minimo=int.MaxValue;
            float promedio;
            for(int i=0;i<5;i++)
            {
                numero=int.Parse(Console.ReadLine());
                acumulador += numero;
                /*
                if(i==0)
                {
                    maximo = numero;
                    minimo = numero;
                }
                */
                /*
                if(maximo<numero)
                { 
                    maximo = numero; 
                }
                if (minimo>numero)
                {
                    minimo=numero;
                }
                */
                maximo = Math.Max(maximo, numero);
                minimo= Math.Min(minimo, numero);
            }
            promedio=acumulador/5;
            Console.WriteLine("El maximo es {0} \nEl minimo es {1} \nEl promedio es {2}",maximo,minimo,promedio);
            Console.ReadKey();
        }
    }
}
