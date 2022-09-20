using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Jugador:Persona
    {
        private int partidosJugados;
        private int totalGoles;

        public Jugador(long dni, string nombre) : base(dni, nombre)
        {
        }
        public Jugador(long dni, string nombre, int partidosJugados, int totalGoles) : this(dni, nombre)
        {
            this.partidosJugados = partidosJugados;
            this.totalGoles = totalGoles;
        }

        public float PromedioGoles 
        {
            get { return this.totalGoles / this.partidosJugados; } 
        }
        public int PartidosJugados 
        {
            get { return this.partidosJugados; }
            set { this.partidosJugados = value; }
        }
        public int TotalGoles 
        {
            get { return this.totalGoles; }
            set { this.totalGoles = value; } 
        }

        public override string MostrarDatos()
        {
            StringBuilder retorno=new StringBuilder();
            retorno.AppendLine($"Profesion:Jugador");
            retorno.AppendLine(base.MostrarDatos());
            retorno.AppendLine($"Total partidos jugados:{this.partidosJugados}");
            retorno.AppendLine($"Total goles :{this.totalGoles}");
            return retorno.ToString();
        }
        public static bool operator ==(Jugador j1,Jugador j2)
        {
            return j1.dni==j2.dni && j1.nombre==j2.nombre;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }


    }
}
