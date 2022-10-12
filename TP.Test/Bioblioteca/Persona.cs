using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bioblioteca
{
    public abstract class Persona
    {
        private int id;
        protected string nombre;
        protected string apellido;
        protected long documento;

        protected Persona(string nombre, string apellido, long documento,int id)
        {
            this.id= id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.documento = documento;
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Nombre 
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido= value; }
        }
        public long Documento
        {
            get { return this.documento; }
            set { this.documento= value; }
        }
        public override string ToString()
        {
            StringBuilder retorno=new StringBuilder();
            retorno.AppendLine($"tipo:{this.GetType().Name}");
            retorno.AppendLine($"ID:{this.id}");
            retorno.AppendLine($"Nombre:{this.nombre}");
            retorno.AppendLine($"Apellido:{this.apellido}");
            retorno.AppendLine($"Documento:{this.documento}");
            return retorno.ToString();
        }

    }
}
