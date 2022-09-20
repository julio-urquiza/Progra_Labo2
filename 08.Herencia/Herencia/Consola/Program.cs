using System;
using Biblioteca;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Humano humano = new Humano("julio", "urquiza", "12345678");
            Deportista deportista = new Deportista("juan", "Perez", "123141511", EDeporte.Tenis);

            Console.WriteLine(humano.getData());
            Console.WriteLine(deportista.getData());
            
            Console.ReadKey();
        }
    }
}
