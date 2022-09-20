using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public sealed class Cuadrado : Rectangulo
    {
        public Cuadrado(double medida) : base(medida,medida)
        {
        }
        public override string Dibujar()
        {
            return "Dibujando Cuadrado...";
        }
    }
}
