using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Persona
    {
        protected string apellido;
        protected string barrioResidencia;
        protected DateTime nacimiento;
        protected string nombre;

        public Persona(string nombre, string apellido, DateTime nacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacimiento = nacimiento;
        }
        public Persona(string nombre, string apellido, DateTime nacimiento, string barrioResidencia):this(nombre,apellido,nacimiento)
        {
            
            this.barrioResidencia = barrioResidencia;
        }

        public int Edad 
        {
            get { return DateTime.Today.AddTicks(-this.nacimiento.Ticks).Year - 1; }
        }
        public string NombreCompleto
        {
            get { return string.Format($"{this.apellido},{this.nombre}"); }
        }

        internal abstract string FichaExtra();

        public override string ToString()
        {
            return this.NombreCompleto;
        }
        public static string FichaPersonal(Persona p)
        {
            StringBuilder retorno=new StringBuilder();
            retorno.AppendLine(p.NombreCompleto);
            retorno.AppendLine($"EDAD: {p.Edad}");
            retorno.AppendLine(p.FichaExtra());
            return retorno.ToString();
        }

    }
}
