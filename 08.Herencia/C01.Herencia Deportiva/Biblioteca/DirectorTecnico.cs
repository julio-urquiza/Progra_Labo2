using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class DirectorTecnico:Persona
    {
        private DateTime fechanacimiento;

        public DirectorTecnico(string nombre) : base(nombre)
        {
        }
        public DirectorTecnico(string nombre, DateTime fechaNacimiento):this(nombre)
        {
            this.fechanacimiento = fechaNacimiento;
        }
        public override string MostrarDatos()
        {
            StringBuilder retorno=new StringBuilder();
            retorno.AppendLine($"Profesion:Director Tecnico");
            retorno.AppendLine(base.MostrarDatos());
            retorno.AppendLine($"fecha de nacimiento:{this.fechanacimiento.ToShortDateString()}");
            return retorno.ToString();
        }
        public static bool operator ==(DirectorTecnico d1,DirectorTecnico d2)
        {
            return d1.nombre == d2.nombre && d1.fechanacimiento == d2.fechanacimiento;
        }
        public static bool operator !=(DirectorTecnico d1,DirectorTecnico d2)
        {
            return (d1==d2);
        }
    }
}
