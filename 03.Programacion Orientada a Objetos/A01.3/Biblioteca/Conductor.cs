using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Conductor
    {
        private string nombre;
        private Dia[] dias;

        private Conductor(int cantidadDeDias)
        {
            this.dias = new Dia[cantidadDeDias];
        }
        public Conductor(string nombre, int cantidadDeDias):this(cantidadDeDias)
        {
            this.nombre = nombre;
        }
        public string Nombre { get => this.nombre; set => this.nombre = value; }
        public Dia[] Dias { get => this.dias; set => this.dias = value; }

        public string MostrarConductor()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Nombre :{this.Nombre}");
            foreach(Dia dias in this.Dias)
            {
                if(dias is not null)
                {
                    stringBuilder.AppendLine(dias.MostrarDias());
                }
            }
            return stringBuilder.ToString();
        }
        public static bool operator +(Conductor conductor,Dia fecha)
        {
            bool retorno = false;
            for (int i = 0; i < conductor.Dias.Length; i++)
            {
                if (conductor.Dias[i] is null)
                {
                    conductor.dias[i]= fecha;
                    retorno = true;
                }
            }
            return retorno;
        }
    }
}
