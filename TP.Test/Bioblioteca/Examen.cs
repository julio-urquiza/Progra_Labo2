using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bioblioteca
{
    public class Examen
    {
        private DateTime fecha;
        private int nota;
        private string nombre;

        public Examen(DateTime fecha, int nota, string nombre)
        {
            this.fecha = fecha;
            this.nota = nota;
            this.nombre = nombre;
        }
        public Examen(DateTime fecha, string nombre):this(fecha,0, nombre) { }

        public DateTime Fecha 
        { 
            get => fecha; 
            set => fecha = value; 
        }
        public int Nota 
        { 
            get => nota; 
            set => nota = value; 
        }
        public string Nombre 
        {
            get => nombre; 
            set => nombre = value; 
        }
        
        public override string ToString()
        {
            StringBuilder retorno=new StringBuilder();
            retorno.Append($"{this.fecha} ");
            retorno.Append($"{this.nombre} ");
            retorno.Append($"{this.nota} ");
            return retorno.ToString();
        }
    }
}
