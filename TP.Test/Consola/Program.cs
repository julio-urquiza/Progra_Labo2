using System;
using System.Collections.Generic;
using Bioblioteca;
namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Materia materia = new Materia("matematica","B",new List<int> {123,156,165},12);

            Administrador administrador1 = new Administrador("adam", "carton", 32165487,1);

            Profesor profesor1 = new Profesor("juan", "parez", 12345678,3);
            Profesor profesor2 = new Profesor("jorge", "rapaz", 12345678,4);

            Alumno alumno1 = new Alumno("pepe", "paez",87654321,11);
            Alumno alumno2 = new Alumno("pan", "coco", 87654321,12);
            Alumno alumno3 = new Alumno("pedro", "juka", 87654321,13);
            Alumno alumno4 = new Alumno("pipo", "pader", 87654321,14);


            _ = materia + profesor1;
            _ = materia + profesor2;
            _ = materia + alumno1;
            _ = materia + alumno2;
            _ = materia + alumno3;
            _ = materia + alumno4;

            Console.WriteLine(materia.ToString());


            Console.ReadKey();
        }
    }
}
