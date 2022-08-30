using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Provincial:Llamada
    {
        public enum Franja
        {
            Franja_1,Franja_2,Franja_3
        }

        protected Franja franjaHoraria;

        public Provincial(Franja franjaHoraria,Llamada llamada):base(llamada.Duracion,llamada.NroDestino,llamada.NroOrigen)
        {
            this.franjaHoraria = franjaHoraria;
        }

        public Provincial(string origen,Franja franjaHoraria,float duracion,string destino):base(duracion,destino,origen)
        {
            this.franjaHoraria = franjaHoraria;
        }

        public float CostoLlamada { get => this.Duracion*this.CalcularCosto(); }

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
        public override string Mostrar()
        {
            StringBuilder retorno=new StringBuilder();
            retorno.Append(base.Mostrar());
            retorno.AppendLine($"Franja Horaria: {this.franjaHoraria}");
            return retorno.ToString();
        }
    }
}
