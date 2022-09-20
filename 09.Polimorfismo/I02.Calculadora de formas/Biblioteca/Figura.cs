using System;
using System.Text;


namespace Biblioteca
{
    public abstract class Figura
    {
        public virtual string Dibujar()
        {
            return "Dibujando Forma...";
        }
        public abstract double CalcularSuperficie(); 
        public abstract double CalcularPerimetro();

        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendLine($"Tipo: {this.GetType().Name}");
            retorno.AppendLine(this.Dibujar());
            retorno.AppendLine($"Area: {this.CalcularSuperficie()}");
            retorno.AppendLine($"Perimetro: {this.CalcularPerimetro()}");
            return retorno.ToString();
        }

    }
}
