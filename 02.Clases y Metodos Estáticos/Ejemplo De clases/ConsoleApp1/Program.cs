using System;
using clases;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gatos gato1 = new Gatos("marron", 4);
            Gatos gato2 = new Gatos("verde", 4);
            Gatos gato3 = new Gatos("marron", 6);
            Gatos gato4 = new Gatos("azul", 5);

            if(gato1 is Gatos)
            {
                Console.WriteLine("es igual");
            }
            else
            {
                Console.WriteLine("es diferente");
            }
            Console.ReadKey();
        }
    }
}
