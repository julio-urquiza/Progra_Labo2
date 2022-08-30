using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;
        private Equipo()
        {
            this.jugadores= new List<Jugador>();
        }

        public Equipo(short cantidadDeJugadores, string nombre):this()
        {
            this.cantidadDeJugadores = cantidadDeJugadores;
            this.nombre = nombre;
        }
        public static bool operator +(Equipo e,Jugador j)
        {
            if(e != j && e.cantidadDeJugadores>e.jugadores.Count)
            {
                e.jugadores.Add(j);
                return true;
            }
            return false;
        }
        public static bool operator ==(Equipo e, Jugador j)
        {
            bool retorno= false;
            foreach (Jugador jugador in e.jugadores)
            {
                if (jugador == j && j is not null)
                {
                    retorno = true;  
                }

            }
            return retorno;
        }
        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }
        public string MostrarEquipo()
        {
            StringBuilder retorno= new StringBuilder();
            retorno.AppendLine(this.nombre);
            retorno.AppendLine($"Cantidad de jugadores:{this.cantidadDeJugadores}");
            foreach(Jugador jugador in this.jugadores)
            {
                if(jugador is not null)
                { 
                    retorno.AppendLine(jugador.MostrarJugador());
                }
            }
            return retorno.ToString();
        }

    }
}
