using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Rectangulo:Figura
    {
        private double altura;
        private double ancho;

        public Rectangulo(double altura, double ancho)
        {
            this.altura = altura;
            this.ancho = ancho;
        }

        public override string Dibujar()
        {
            return "Dibjando Rectangulo...";
        }

        public override double CalcularPerimetro()
        {
            return (altura+ancho)*2;
        }

        public override double CalcularSuperficie()
        {
            return altura*ancho;
        }

    }
}
