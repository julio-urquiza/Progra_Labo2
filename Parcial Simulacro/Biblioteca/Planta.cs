using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Planta
    {
        private string nombre;
        private int tamanio;


        protected Planta(string nombre, int tamanio)
        {
            this.nombre = nombre;
            this.tamanio = tamanio;
        }


        public int Tamanio { get => this.tamanio;}
        public abstract bool TieneFlores { get;}
        public abstract bool TieneFruto{ get; }


        public virtual string ResumenDeDatos()
        {
            StringBuilder retorno=new StringBuilder();
            retorno.AppendLine($"{this.nombre} tiene un tamaño de {this.Tamanio}");
            retorno.AppendLine(string.Format("Tiene Flores: {0}", TieneFlores ? "SI" : "NO"));
            retorno.AppendLine(string.Format("Tiene Frutos: {0}", TieneFruto ? "SI" : "NO"));

            return retorno.ToString();
        }
    }
}
