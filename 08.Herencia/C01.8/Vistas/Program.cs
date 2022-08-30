using System;
using Biblioteca;
namespace Vistas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Equipo  equipo1=new Equipo(12,"pepes");
            DirectorTecnico director1 = new DirectorTecnico("julio Urquiza", new DateTime(2000, 08, 04));
            Jugador jugador1 = new Jugador(123456789, "pepito", 15, 30);
            Jugador jugador2 = new Jugador(123456788, "peposo", 17, 5);
            Jugador jugador3 = new Jugador(129456788, "pipo", 1, 5);
            Jugador jugador4 = new Jugador(123446788, "papo", 7, 3);
            Jugador jugador5 = new Jugador(125456788, "papurri", 20, 7);
            Jugador jugador6 = new Jugador(123456388, "popo", 1, 8);
            Jugador jugador7 = new Jugador(123456788, "pan", 9, 1);
            Persona jugador8 = new Jugador(123456788, "pan", 9, 1);


            _ = equipo1 + jugador1;
            _ = equipo1 + jugador2;
            _ = equipo1 + jugador3;
            _ = equipo1 + jugador4;
            _ = equipo1 + jugador5;
            _ = equipo1 + jugador6;
            _ = equipo1 + jugador7;
            
            Console.WriteLine(equipo1.MostrarEquipo());
            Console.WriteLine(director1.MostrarDatos());
            if(jugador8.GetType() == typeof(Jugador))
            {
            Console.WriteLine(jugador8.GetType().Name);

            }


            Console.ReadLine();
        }
    }
}
