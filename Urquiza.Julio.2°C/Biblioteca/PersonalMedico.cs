using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class PersonalMedico:Persona
    {
        private List<Consulta> consultas;
        private bool esResidente;

        public PersonalMedico(string nombre, string apellido, DateTime nacimiento,bool esRedidente) : base(nombre, apellido, nacimiento)
        {
            this.consultas = new List<Consulta>();
            this.esResidente = esRedidente;
        }

        internal override string FichaExtra()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendLine(string.Format("¿Finalizo residencia?: {0}",esResidente? "SI":"NO"));
            retorno.AppendLine("ATENCIONES");
            foreach(Consulta consulta in consultas)
            {
                if(consulta is not null)
                {
                    retorno.AppendLine(consulta.ToString());
                }
            }    
            return retorno.ToString();
        }
        public static Consulta operator +(PersonalMedico doctor,Paciente paciente)
        {
            Consulta consulta=new Consulta(DateTime.Now, paciente);
            if(doctor is not null && paciente is not null)
            {
                doctor.consultas.Add(consulta);
            }
            return consulta;
        }

    }
}
