using System;
using Biblioteca;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Equipo equipo=new Equipo(12,"sopaDuMacacoFC");

            Jugador jugador1 = new Jugador(12345678,"pichichi martinez",5200,0);
            Jugador jugador2 = new Jugador(87654321,"cristiano messialdo",1,20);
            Jugador jugador3 = new Jugador(32165487,"roberto Carlos",15,15);

            if(equipo+jugador1 && equipo+jugador2 && equipo+jugador3)
            {
                Console.WriteLine(equipo.MostrarDatos());
            }

            Console.ReadKey();
        }
    }
}
