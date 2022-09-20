using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Equipo
    {
        private short cantiadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        public Equipo(short cantiadDeJugadores, string nombre):this()
        {
            this.cantiadDeJugadores = cantiadDeJugadores;
            this.nombre = nombre;
        }

        private Equipo()
        {
            jugadores = new List<Jugador>();
        }
        public static bool operator +(Equipo e,Jugador j)
        {
            bool retorno=false;
            if (e is not null && j is not null && !e.jugadores.Contains(j))
            {
                e.jugadores.Add(j);
                retorno=true;
            }
            return retorno;
        }
        public string MostrarDatos()
        {
            StringBuilder retorno=new StringBuilder();
            retorno.AppendLine($"Nombre:{this.nombre}");
            retorno.AppendLine($"Cantidad Jugadores:{this.cantiadDeJugadores}");
            foreach(Jugador jugador in this.jugadores)
            {
                retorno.AppendLine(jugador.MostrarDatos());
            }
            return retorno.ToString(); 
        }

    }
}
