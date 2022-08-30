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
    public abstract class Llamada
    {


        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public float Duracion 
        {
            get { return duracion; }
        }
        public string NroDestino 
        {
            get { return nroDestino; }
        }
        public string NroOrigen
        {
            get { return nroOrigen; } 
        }
        public abstract float CostoLlamada { get; }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }
        protected virtual string Mostrar()
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
        public static bool operator ==(Llamada llamada1,Llamada llamada2)
        {
            return  llamada1.Equals(llamada2) && 
                    llamada1.NroDestino == llamada2.nroDestino && 
                    llamada1.nroOrigen == llamada2.nroOrigen;
        }
        public static bool operator !=(Llamada llamada1, Llamada llamada2)
        {
            return !(llamada1 == llamada2);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (ReferenceEquals(obj, null))
            {
                return false;
            }

            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
