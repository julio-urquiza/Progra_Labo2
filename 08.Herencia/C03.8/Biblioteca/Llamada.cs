using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public enum TipoLlamada
    {
        Local,Provincial,Todas
    }
    public class Llamada
    {
        

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public float Duracion { get => duracion;}
        public string NroDestino { get => nroDestino;}
        public string NroOrigen { get => nroOrigen;}

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }
        public virtual string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendLine($"Duracion: {this.duracion}");
            retorno.AppendLine($"Numero de Destino: {this.nroDestino}");
            retorno.AppendLine($"Numero de Origen: {this.nroOrigen}");
            return retorno.ToString();
        }
        public static int OrdendarPorDuracion(Llamada llamada1,Llamada llamada2)
        {
            if(llamada1.duracion>llamada2.duracion)
            { 
                return 1; 
            }
            return 0;
        }


    }
}
