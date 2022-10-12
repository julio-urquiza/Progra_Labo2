using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bioblioteca
{
    public class Curso
    {
        protected List<Profesor> profesores;
        protected List<Alumno> alumnos;
        protected string materia;

        public Curso(string materia)
        {
            alumnos=new List<Alumno>();
            profesores=new List<Profesor>();
            this.materia=materia;
        }

        public List<Profesor> Profesores 
        {
            get { return this.profesores; }
            set { this.profesores = value; }
        }
        public List<Alumno> Alumnos
        {
            get { return this.alumnos; }
            set { this.alumnos= value; }
        }
        public string Materia
        {
            get { return this.materia; }
            set { this.materia= value; }
        }

        public override string ToString()
        {
            StringBuilder retorno=new StringBuilder();
            retorno.AppendLine($"materia:{this.materia}");
            retorno.AppendLine("profesor:");
            foreach(Profesor profesor in profesores)
            {
                retorno.AppendLine(profesor.ToString());
            }
            retorno.AppendLine("alumnos:");
            foreach(Alumno alumno in alumnos)
            {
                retorno.AppendLine(alumno.ToString());
            }
            return retorno.ToString();
        }

    }
}
