using System;
using Biblioteca;
namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante miEstudiante = new Estudiante("julio", "urquiza", "123");
            miEstudiante.SetNotaPrimerParcial(3);
            miEstudiante.SetNotaSegundaParcial(5);

            Console.WriteLine(miEstudiante.Mostrar());


            Console.ReadLine();
        }
    }
}
