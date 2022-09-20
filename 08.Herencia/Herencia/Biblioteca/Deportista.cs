using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Deportista : Humano
    {
        private EDeporte deporte;
        public Deportista(string nombre, string apellido, string dni) : base(nombre, apellido, dni)
        {
        }
        public Deportista(string nombre, string apellido,string dni,EDeporte deporte):this(nombre,apellido,dni)
        {
            this.deporte=deporte;
        }

        public EDeporte Deporte { get => deporte; set => deporte = value; }
        
        public override string getData()
        {
            StringBuilder retorno=new StringBuilder();
            retorno.Append(base.getData());
            retorno.AppendLine(this.deporte.ToString());
            return retorno.ToString();
        }
    }
}
