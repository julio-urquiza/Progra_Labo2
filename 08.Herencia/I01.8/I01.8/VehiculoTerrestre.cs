using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public enum Colores
    { Rojo, Blanco, Azul, Gris, Negro }
    public class VehiculoTerrestre
    {
        private short cantidadRuedas;
        private short cantidadPuertas;
        private Colores color;

        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, Colores color)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.color = color;
        }

        protected short CantidadRuedas { get => cantidadRuedas; set => cantidadRuedas = value; }
        protected short CantidadPuertas { get => cantidadPuertas; set => cantidadPuertas = value; }
        protected Colores Color { get => color; set => color = value; }
    }
}
