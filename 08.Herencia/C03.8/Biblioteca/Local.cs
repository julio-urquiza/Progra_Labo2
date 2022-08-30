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

        public Local(Llamada llamada,float costo):base(llamada.Duracion,llamada.NroDestino,llamada.NroOrigen)
        {
            this.costo = costo;
        }
        public Local(string origen,float duracion,string destino,float costo):base(duracion,destino,destino)
        {
            this.costo=costo;
        }
        public float CostoLlamada { get => this.CalcularCosto(); }

        private float CalcularCosto()
        {
            return this.costo*this.duracion;
        }
        public override string Mostrar()
        {
            StringBuilder retorno=new StringBuilder();
            retorno.Append(base.Mostrar());
            retorno.AppendLine($"Costo: {this.costo}");
            return retorno.ToString();
        }
    }
}
