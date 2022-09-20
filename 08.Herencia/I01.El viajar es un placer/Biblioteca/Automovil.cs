using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Automovil:VehiculoTerrestre
    {
        private short cantidadMarchas;
        private short cantidadPasajeros;

        public Automovil(short cantidadRuedas, short cantidadPuertas, EColores color,short cantidadMarchas,short cantidadPasajeros) : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.cantidadPasajeros = cantidadPasajeros;
        }
    }
}
