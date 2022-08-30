using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Torneo<T> where T : Equipo
    {
        private List<T> equipos;
        private string nombre;

        public Torneo(List<T> equipos, string nombre)
        {
            this.equipos = equipos;
            this.nombre = nombre;
        }

        public string JugarPartido
        {
            get
            {
                Random random=new Random();
                if(this.equipos.Count>1)
                {
                    return this.CalcularPartido(this.equipos[random.Next(this.equipos.Count)], this.equipos[random.Next(this.equipos.Count)]);
                }
                return "no hay sufiecientes equipos";
            }
        }

        public static bool operator ==(Torneo<T> torneo,T equipo)
        {
            if(equipo!=null && torneo!= null)
            {
                torneo.equipos.Contains(equipo);
            }
            return false;
        }
        public static bool operator !=(Torneo<T> torneo,T equipo)
        {
            return !(torneo == equipo); 
        }
        public static bool operator +(Torneo<T> torneo,T equipo)
        {
            if (torneo!=equipo)
            {
                torneo.equipos.Add(equipo);
                return true;
            }
            return false;
        }
        public string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendLine(nombre);
            foreach(T equipo in equipos)
            {
                retorno.AppendLine(equipo.Ficha());
            }
            return retorno.ToString();
        }
        private string CalcularPartido(T equipo1,T equipo2)
        {
            StringBuilder retorno=new StringBuilder();
            Random random = new Random();
            retorno.AppendLine($"[{equipo1.Nombre}][{random.Next(0,10)}] – [{random.Next(0, 10)}][{equipo2.Nombre}]");
            return retorno.ToString();
        }
    }
}
