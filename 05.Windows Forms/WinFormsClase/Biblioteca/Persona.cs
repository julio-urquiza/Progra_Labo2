using System;
using System.Text;


namespace Biblioteca
{
    public class Persona
    {
        private string nombre;
        private string apeellido;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apeellido { get => apeellido; set => apeellido = value; }

        public Persona(string nombre, string apeellido)
        {
            this.nombre = nombre;
            this.apeellido = apeellido;
        }
        public string MostrarInformacion()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"{nombre},{apeellido}");
            return stringBuilder.ToString();
        }
    }
}
