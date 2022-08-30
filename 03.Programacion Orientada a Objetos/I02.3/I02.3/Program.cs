using System;
using Biblioteca;
namespace Vistas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Persona persona1 = new Persona("julio",new DateTime(2000,8,4),42833671);
            Persona persona2 = new Persona("juan", new DateTime(2005, 7, 10), 42833171);
            Persona persona3 = new Persona("julian", new DateTime(1990, 1, 25), 42893671);

            Console.WriteLine(persona1.Mostrar());
            Console.WriteLine(persona1.EsMayorDeEdad());

            Console.WriteLine(persona2.Mostrar());
            Console.WriteLine(persona2.EsMayorDeEdad());

            Console.WriteLine(persona3.Mostrar());
            Console.WriteLine(persona3.EsMayorDeEdad());



            Console.ReadLine();
        }
    }
}
