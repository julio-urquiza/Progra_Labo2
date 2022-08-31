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

        public int NotaPrimerParcial { get => notaPrimerParcial; set => notaPrimerParcial = value; }
        public int NotaSegundoParcial { get => notaSegundoParcial; set => notaSegundoParcial = value; }

        public Estudiante(string nombre,string apellido,string legajo )
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;

        }
        static Estudiante()
        {
            Estudiante.random= new Random();
        }

        public double CalcualarNotaFinal()
        {
            if (!(this.notaPrimerParcial >= 4 && this.notaSegundoParcial >= 4))
            {
                return -1;
            }
            return Estudiante.random.Next(6,10);
        }
        public float CalcularPromedio()
        {
            return (this.notaSegundoParcial+this.notaSegundoParcial)/2;
        }
        public string Mostrar()
        {
            StringBuilder retorno=new StringBuilder();
            retorno.AppendLine($"{this.nombre}, {this.apellido}: {this.legajo}");
            retorno.AppendLine($"nota primer parcial: {this.notaPrimerParcial} nota segundo parcial:{this.notaSegundoParcial}");
            retorno.AppendLine($"promedio: {this.CalcularPromedio()}");
            double notaFinal=CalcualarNotaFinal();
            retorno.AppendLine(notaFinal == -1 ? "alumno Desaprobado":notaFinal.ToString());
            return retorno.ToString();
        }
        public void SetNotaPrimerParcial(int nota)
        {
            this.notaPrimerParcial=nota;
        }
        public void SetNotaSegundaParcial(int nota)
        {
            this.notaSegundoParcial= nota;

        }

    }
}
