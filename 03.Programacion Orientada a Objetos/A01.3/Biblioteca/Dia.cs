using System;
using System.Text;

namespace Biblioteca
{
    public class Dia
    {
        private int fecha;
        private int kilometros;

        public Dia(int dia, int kilometros)
        {
            this.fecha = dia;
            this.kilometros = kilometros;
        }

        public int Fecha
        {
            get => this.fecha;
            set
            {
                if (value > 0 && value < 31)
                {
                    this.fecha = value;
                }
            }
        }
        public int Kilometros 
        {
            get => this.kilometros; 
            set 
            {if(value > 0)
                {
                    this.kilometros = value;
                }
            }
        }
        public string MostrarDias()
        {
            StringBuilder stringBuilder=new StringBuilder();
            stringBuilder.Append($"Día {this.Fecha}: {this.Kilometros}km");
            return stringBuilder.ToString();
        }
    }
}
