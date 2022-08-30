using System;
using System.Text;

namespace Biblioteca
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        static Estudiante()
        {
            random = new Random();
        }
        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }
        public void SetNotaPrimerParcial(int nota)
        {
            if(nota<=10 && nota>=0)
            {
                this.notaPrimerParcial = nota;
            }
        }
        public void SetNotaSegundoParcial(int nota)
        {
            if (nota <= 10 && nota >= 0)
            {
                this.notaSegundoParcial=nota;
            }
        }
        public double CalcularNotaFinal()
        {
            double retorno=-1;
            if(this.notaPrimerParcial>=4 && this.notaSegundoParcial>=4)
            {
                retorno = (Estudiante.random.NextDouble()*4)+6;
            }

            return retorno;
        }
        private float CalcularPromedio()
        {
            return (this.notaPrimerParcial + this.notaSegundoParcial) / 2;
        }
        public string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"{this.nombre} {this.apellido}, Legajo: {this.legajo}");
            stringBuilder.AppendLine($"Nota Primer parcial: {this.notaPrimerParcial} \nNota Segundo parcial:{this.notaSegundoParcial}  ");
            stringBuilder.AppendLine($"Promedio: {this.CalcularPromedio()}");
            stringBuilder.AppendLine($"Nota Final: {this.CalcularNotaFinal()}");

            return stringBuilder.ToString();
        }

    }
}
