using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Persona
    {
        private long dni;
        private string nombre;

        public Persona(string nombre)
        {
            this.dni = 0;
            this.nombre = nombre;
        }
        public Persona(long dni, string nombre):this(nombre)
        {
            this.dni = dni;
        }
        public long Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string MostrarDatos()
        {
            StringBuilder retorno=new StringBuilder();
            retorno.AppendLine($"Nombre: {this.Nombre}");
            retorno.AppendLine($"DNI: {this.Dni}");
            return retorno.ToString();
        }
    }
}
