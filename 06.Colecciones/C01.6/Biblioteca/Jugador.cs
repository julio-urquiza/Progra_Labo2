using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Biblioteca
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidoJugados;
        private float promedioGoles;
        private int totalGoles;

        public int Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int PartidoJugados { get => partidoJugados; set => partidoJugados = value; }
        public float PromedioGoles { get => promedioGoles; set => promedioGoles = value; }
        public int TotalGoles { get => totalGoles; set => totalGoles = value; }

        public float GetPromedioGoles()
        {
            return (float)totalGoles/partidoJugados;
        }
        private Jugador()
        {
            partidoJugados = 0;
            promedioGoles = 0;
            totalGoles = 0;
        }
        public Jugador(int dni, string nombre):this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int partidoJugados, int totalGoles) : this(dni, nombre)
        {
            this.partidoJugados = partidoJugados;
            this.totalGoles = totalGoles;
            this.promedioGoles = this.GetPromedioGoles();
        }
        public string MostrarJugador()
        {
            StringBuilder retorno= new StringBuilder();
            retorno.AppendLine($"El Nombre es :{this.nombre}");
            retorno.AppendLine($"El DNI es :{this.dni}");
            retorno.AppendLine($"Hizo un total de:{this.totalGoles} goles en {this.PartidoJugados} partidos");
            retorno.AppendLine($"Su promedio es:{this.promedioGoles}");
            return retorno.ToString();
        }
        public static bool operator == (Jugador j1,Jugador j2)
        {
            if(j1 is null || j2 is null)
            {
                return false;
            }
            return (j1.dni==j2.dni);
        }
        public static bool operator !=(Jugador j1,Jugador j2)
        {
            return !(j1==j2);
        }
    }
}
