using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Moto : VehiculoTerrestre
    {
        private short cilindrada;
        public Moto(short cantidadRuedas, short cantidadPuertas, EColores color,short cilidrada) : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cilindrada = cilidrada;
        }
    }
}
