using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public enum Franja
    {
        Franja_1,Franja_2,Franja_3
    }
    public class Provincial:Llamada
    {

        protected Franja franjaHoraria;

        private Provincial(Franja franjaHoraria,Llamada llamada):base(llamada.Duracion,llamada.NroDestino,llamada.NroOrigen)
        {
            this.franjaHoraria = franjaHoraria;
        }

        public Provincial(string origen,Franja franjaHoraria,float duracion,string destino):base(duracion,destino,origen)
        {
            this.franjaHoraria = franjaHoraria;
        }

        public override float CostoLlamada { get => this.Duracion*this.CalcularCosto(); }

        private float CalcularCosto()
        {
            float retorno=0;
            switch(this.franjaHoraria)
            {
                case Franja.Franja_1:
                    retorno = 0.99f;
                    break;
                case Franja.Franja_2:
                    retorno = 1.25f;
                    break;
                case Franja.Franja_3:
                    retorno = 0.66f;
                    break;
            }
            return retorno;
            
        }
        protected override string Mostrar()
        {
            StringBuilder retorno=new StringBuilder();
            retorno.Append(base.Mostrar());
            retorno.AppendLine($"Franja Horaria: {this.franjaHoraria}");
            retorno.AppendLine($"Costo de la llamada:{this.CostoLlamada}");
            return retorno.ToString();
        }
        public override bool Equals(object obj)
        {
            //return obj.GetType()==typeof(Provincial)
            return obj is Provincial;
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
