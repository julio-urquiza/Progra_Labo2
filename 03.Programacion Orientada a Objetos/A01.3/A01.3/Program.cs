using System;
using Biblioteca;
namespace Vistas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conductor conductor1 = new Conductor("juan", 7);
            Conductor conductor2 = new Conductor("pablo", 7);
            Conductor conductor3 = new Conductor("esteban", 7);

            conductor1.Dias[0] = new Dia(1, 300);
            conductor1.Dias[1] = new Dia(2, 300);
            conductor1.Dias[2] = new Dia(3, 300);
            conductor1.Dias[3] = new Dia(4, 300);
            conductor1.Dias[4] = new Dia(5, 300);
            conductor1.Dias[5] = new Dia(6, 300);
            //conductor1.Dias[6] = new Dias(7, 300);

            Console.WriteLine(conductor1.MostrarConductor());

            Console.ReadLine();
        }
    }
}
