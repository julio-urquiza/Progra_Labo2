using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Equipo
    {
        protected string nombre;
        protected DateTime fechaCreacion;

        public Equipo(string nombre,DateTime fechaCreacion)
        {
            this.nombre = nombre;
            this.fechaCreacion = fechaCreacion;
        }

        public string Nombre 
        {
            get 
            { 
                return nombre; 
            } 
        }

        public static bool operator ==(Equipo equipo1,Equipo equipo2)
        {
            return equipo1.nombre == equipo2.nombre && equipo1.fechaCreacion == equipo2.fechaCreacion;
        }
        public static bool operator !=(Equipo equipo1,Equipo equipo2)
        {
            return !(equipo1 == equipo2);
        }
        public string Ficha()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendLine($"[{this.Nombre}] fundado el [{this.fechaCreacion.ToShortDateString()}]");
            return retorno.ToString();
        }
        
    }
}
