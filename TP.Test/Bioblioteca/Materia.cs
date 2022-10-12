using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bioblioteca
{
    public class Materia
    {
        private string nombre;
        private string cuatrimestre;
        private List<int> listaId;
        private List<int> correlativas;
        private int id;


        private Materia()
        {
            listaId = new List<int>();
            correlativas = new List<int>();
        }
        public Materia(string nombre, string cuatrimestre, List<int> correlativas, int id):this()
        {
            this.nombre = nombre;
            this.cuatrimestre = cuatrimestre;
            this.correlativas = correlativas;
            this.id = id;
        }


        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public string Cuatrimestre
        {
            get { return this.cuatrimestre; }
            set { this.cuatrimestre = value; }  
        }
        public List<int> Correlativas
        {
            get { return this.correlativas;}
            set { this.correlativas = value; }
        }
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }


        public bool AgregarPersona(int id)
        {
            bool retorno=false;
            if(this.listaId.Contains(id))
            {
                this.listaId.Add(id);
                retorno = true;
            }
            return retorno;
        }
        public bool EliminarPersona(int id)
        {
            bool retorno = false;
            if (this.listaId.Contains(id))
            {
                this.listaId.Remove(id);
                retorno = true;
            }
            return retorno;
        }
        public string MostrarPersonas(Dictionary<int,Persona> lista,string tipo="")
        {
            StringBuilder retorno = new StringBuilder();
            foreach(KeyValuePair<int,Persona> kvp in lista)
            {
                if((kvp.Value.GetType().Name==tipo || tipo=="") && this.listaId.Contains(kvp.Key))
                {
                    retorno.AppendLine(kvp.Value.ToString());
                }
            }
            return retorno.ToString();
        }
        public string MostrarTodosLosExamenes(Dictionary<int,Persona> lista)
        {
            StringBuilder retorno=new StringBuilder();
            retorno.AppendLine("Examenes");
            retorno.AppendLine("Fecha Nombre Instancia Nota Observaciones");
            foreach (KeyValuePair<int,Persona> kvp in lista)
            {
                if(kvp.Value.GetType()==typeof(Alumno))
                {
                    retorno.AppendLine((kvp.Value as Alumno).MostrarExamenesFiltrados(this.nombre));
                }
            }
            return retorno.ToString();
        }
        public string MostrarInformacion(Dictionary<int,Persona> lista)
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendLine($"Id:{this.id}");
            retorno.AppendLine($"{this.nombre}, {this.cuatrimestre}");
            retorno.Append($"corretivas: ");
            foreach (int i in this.correlativas)
            {
                retorno.Append($"{i} ");
            }
            retorno.AppendLine(Environment.NewLine);
            retorno.Append(this.MostrarTodosLosExamenes(lista));
            retorno.AppendLine(this.MostrarPersonas(lista,"Profesor"));
            retorno.AppendLine(this.MostrarPersonas(lista,"Alumno"));
            return retorno.ToString();
        }
        
    }
}
