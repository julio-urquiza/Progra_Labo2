using System;
using Biblioteca;
using System.Collections.Generic;
namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Figura> lista=new List<Figura>();

            lista.Add(new Circulo(4));
            lista.Add(new Rectangulo(5,3));
            lista.Add(new Cuadrado(7));

            foreach(Figura f in lista)
            {
                Console.WriteLine(f.ToString());
            }

            Console.ReadKey();
        }
    }
}
