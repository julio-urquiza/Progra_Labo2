using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Biblioteca
{
    public class Jugador:Persona
    {
        private int partidoJugados;
        private int totalGoles;

        public int PartidoJugados { get => partidoJugados;}
        public float PromedioGoles { get => (float)totalGoles/partidoJugados;}
        public int TotalGoles { get => totalGoles;}

        public Jugador(int dni, string nombre) : base(dni, nombre)
        {
            this.partidoJugados = 0;
            this.totalGoles = 0;
        }
        
        public Jugador(int dni, string nombre, int partidoJugados, int totalGoles) : this(dni, nombre)
        {
            this.partidoJugados = partidoJugados;
            this.totalGoles = totalGoles;
        }
        public  new string MostrarDatos()
        {
            StringBuilder retorno= new StringBuilder();
            retorno.AppendLine($"El Nombre es :{this.Nombre}");
            retorno.AppendLine($"El DNI es :{this.Dni}");
            retorno.AppendLine($"Hizo un total de:{this.TotalGoles} goles en {this.PartidoJugados} partidos");
            retorno.AppendLine($"Su promedio es:{this.PromedioGoles}");
            return retorno.ToString();
        }
        public static bool operator == (Jugador j1,Jugador j2)
        {
            if(j1 is null || j2 is null)
            {
                return false;
            }
            return (j1.Dni==j2.Dni);
        }
        public static bool operator !=(Jugador j1,Jugador j2)
        {
            return !(j1==j2);
        }
    }
}
