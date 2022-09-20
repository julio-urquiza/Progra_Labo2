using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public sealed class Circulo:Figura
    {
        private double radio;

        public Circulo(double radio)
        {
            this.radio = radio;
        }

        public override string Dibujar()
        {
            return "Dibjando Circulo...";
        }

        public override double CalcularPerimetro()
        {
            return Math.Round(radio*2*Math.PI,2);
        }

        public override double CalcularSuperficie()
        {
            return Math.Round(Math.Pow(radio,2)*Math.PI,2);
        }

    }
}
