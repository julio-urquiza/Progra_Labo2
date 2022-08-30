using System;
using System.Text;

namespace Biblioteca
{
    public class Ingresante
    {
        private string[] curso;
        private string direccion;
        private int edad;
        private string genero;
        private string nombre;
        private string pais;

        public Ingresante(string nombre, string direccion, string genero, string pais, string[] curso, int edad)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.genero = genero;
            this.pais = pais;
            this.curso = curso;
            this.edad = edad;
        }
        public string Mostrar()
        {
            StringBuilder cadena=new StringBuilder();
            cadena.AppendLine($" Nombre: {this.nombre}");
            cadena.AppendLine($" Direccion: {this.direccion}");
            cadena.AppendLine($" Genero: {this.genero}");
            cadena.AppendLine($" Pais: {this.pais}");
            cadena.AppendLine($" Curso: {this.curso}");
            cadena.AppendLine($" Edad: {this.edad}");
            return cadena.ToString();
        }
    }
}
