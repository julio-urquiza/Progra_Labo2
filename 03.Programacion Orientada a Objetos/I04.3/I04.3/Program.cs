using System;
using Biblioteca;
namespace Vistas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dibujo;
            string dibujo2;


            Boligrafo boligrafoAzul = new Boligrafo(5,ConsoleColor.Blue);
            Boligrafo boligrafoRojo = new Boligrafo(50, ConsoleColor.Red);


            boligrafoAzul.Pintar(6,out dibujo);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(dibujo);

            boligrafoRojo.Pintar(6, out dibujo2);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(dibujo);



            Console.ReadLine();

        }
    }
}
