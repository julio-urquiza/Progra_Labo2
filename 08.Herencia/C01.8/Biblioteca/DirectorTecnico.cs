using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class DirectorTecnico : Persona
    {
        private DateTime fechaDeNacimiento;

        public DirectorTecnico(string nombre) : base(nombre)
        {
            this.fechaDeNacimiento = DateTime.Now;
        }
        public DirectorTecnico(string nombre, DateTime fechaNacimiento) : this(nombre)
        {
            this.fechaDeNacimiento = fechaNacimiento;
        }
        public new string MostrarDatos()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendLine($"Nombre: {this.Nombre}");
            retorno.AppendLine($"DNI: {this.Dni}");
            retorno.AppendLine($"Fecha de Nacimiento: {this.fechaDeNacimiento.ToShortDateString()}");
            return retorno.ToString();
        }
        public static bool operator ==(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return dt1.Nombre == dt2.Nombre && dt1.fechaDeNacimiento == dt2.fechaDeNacimiento;
        }
        public static bool operator !=(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return !(dt1 == dt2);
        }



    }
}
