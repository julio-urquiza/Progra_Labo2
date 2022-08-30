using System;
using Biblioteca;
namespace Vistas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante1 = new Estudiante("julio", "urquiza", "b1");
            Estudiante estudiante2 = new Estudiante("lucas", "jaurena", "b1");
            Estudiante estudiante3 = new Estudiante("rodri", "nikitiuk", "b1");

            estudiante1.SetNotaPrimerParcial(5);
            estudiante1.SetNotaSegundoParcial(6);

            estudiante2.SetNotaPrimerParcial(7);
            estudiante2.SetNotaSegundoParcial(4);

            estudiante3.SetNotaPrimerParcial(3);
            estudiante3.SetNotaSegundoParcial(4);

            Console.WriteLine(estudiante1.Mostrar());
            Console.WriteLine(estudiante2.Mostrar());
            Console.WriteLine(estudiante3.Mostrar());




            Console.ReadLine();
        }
    }
}
