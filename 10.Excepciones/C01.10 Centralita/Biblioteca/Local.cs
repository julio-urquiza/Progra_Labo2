using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Local:Llamada
    {
        protected float costo;

        private Local(Llamada llamada,float costo):base(llamada.Duracion,llamada.NroDestino,llamada.NroOrigen)
        {
            this.costo = costo;
        }
        public Local(string origen,float duracion,string destino,float costo):base(duracion,destino,destino)
        {
            this.costo=costo;
        }
        public override float CostoLlamada { get => this.CalcularCosto(); }

        private float CalcularCosto()
        {
            return this.costo*this.duracion;
        }
        protected override string Mostrar()
        {
            StringBuilder retorno=new StringBuilder();
            retorno.Append(base.Mostrar());
            retorno.AppendLine($"Costo: {this.costo}");
            retorno.AppendLine($"Costo de llamada: {this.CostoLlamada}");
            return retorno.ToString();
        }
        public override bool Equals(object obj)
        {
            //return obj.GetType()==typeof(Local)
            return obj is Local;
        }
        public override string ToString()
        {
            return this.Mostrar();
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
