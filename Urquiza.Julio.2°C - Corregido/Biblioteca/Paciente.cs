using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public enum Diagnosticos
    {
        Curado,Gripe,Coronavirus
    }
    public class Paciente:Persona
    {

        public Diagnosticos diagnostico;

        public Paciente(string nombre, string apellido, DateTime nacimiento, string barrioResidencia) : base(nombre, apellido, nacimiento, barrioResidencia)
        {
            this.diagnostico =Diagnosticos.Curado;
        }

        public Diagnosticos Diagnostico
        {
            get { return diagnostico; }
            set { diagnostico = value; }
        }
        internal override string FichaExtra()
        {
            StringBuilder retorno= new StringBuilder();
            retorno.AppendLine($"Reside en: {this.barrioResidencia}");
            retorno.AppendLine(this.diagnostico.ToString());
            return retorno.ToString();
        }
    }
}
