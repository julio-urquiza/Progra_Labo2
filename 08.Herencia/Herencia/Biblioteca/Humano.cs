using System;
using System.Text;


namespace Biblioteca
{
    public class Humano
    {
        protected string nombre;
        protected string apellido;
        protected string dni;

        public Humano(string nombre, string apellido, string dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Dni { get => dni; set => dni = value; }

        public virtual string getData()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine(nombre);
            retorno.AppendLine(apellido);
            retorno.AppendLine(dni);

            return retorno.ToString();
        }
    }
}
