using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bioblioteca
{
    public class Alumno : Persona
    {
        private Dictionary<string, Examen> examenes;
        private Dictionary<string, string> notasMaterias;
        private List<int> materiasInscripto;

        
        public Alumno(string nombre, string apellido, long documento,int id) : base(nombre, apellido, documento,id)
        {
            examenes=new Dictionary<string, Examen>();
            notasMaterias=new Dictionary<string, string>();
            materiasInscripto=new List<int>();
        }


        public string MostrarExamenesFiltrados(string materia="")
        {
            StringBuilder retorno=new StringBuilder();
            foreach(KeyValuePair<string,Examen> keyValue in examenes)
            {
                if(keyValue.Key==materia || materia=="")
                {
                    retorno.AppendLine(keyValue.Value.ToString());
                }
            }
            return retorno.ToString();
        }   
        public void CrearMaterias(string materia,string nota)
        {
            this.notasMaterias.Add(materia,nota);
        }
        public void ModificarNotaMateria(string materia,string nota)
        {
            this.notasMaterias[materia]=nota;
        }
        public string MostrarNotaMateriasFiltrados(string materia = "")
        {
            StringBuilder retorno = new StringBuilder();
            foreach(KeyValuePair<string,string> keyValue in this.notasMaterias)
            {
                if (keyValue.Key == materia || materia == "")
                {
                    retorno.AppendLine($"{keyValue.Key}: {keyValue.Value}");
                }
            }
            return retorno.ToString();
        }
        public void CrearExamen(string materia,Examen examen)
        {
            this.examenes.Add(materia,examen);
        }
        public void ModificarNotaExamen(string materia, int nota)
        {
            this.examenes[materia].Nota = nota;
        }
        public void inscribirseAMateria(Materia materia)
        {
            if(this.materiasInscripto.Count<=2 )
            {
                this.materiasInscripto.Add(materia.Id);
            }
        }
        public override string ToString()
        {
            StringBuilder retorno=new StringBuilder();
            retorno.AppendLine(base.ToString());
            retorno.AppendLine(this.MostrarNotaMateriasFiltrados());
            retorno.AppendLine(this.MostrarExamenesFiltrados());
            return retorno.ToString();
        }
    }
}
