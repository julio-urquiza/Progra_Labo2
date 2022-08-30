using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        public float GananciasPorLocal { get=>this.CalcularGanancia(TipoLlamada.Local);}
        public float GananciasPorProvincial{ get => this.CalcularGanancia(TipoLlamada.Provincial);}
        public float GananciasPorTodos{ get => this.CalcularGanancia(TipoLlamada.Todas);}
        public List<Llamada> Llamadas { get => listaDeLlamadas;}

        private float CalcularGanancia(TipoLlamada tipo)
        {
            float retorno = 0;
            foreach(Llamada llamada in listaDeLlamadas)
            {
                switch(tipo)
                {
                    case TipoLlamada.Local:
                        if (llamada.GetType() == typeof(Local))
                            retorno += ((Local)llamada).CostoLlamada;
                        break;
                    case TipoLlamada.Provincial:
                        if (llamada.GetType() == typeof(Provincial))
                            retorno += ((Provincial)llamada).CostoLlamada;
                        break;
                    case TipoLlamada.Todas:
                        if(llamada.GetType()== typeof(Provincial))
                        {
                            retorno += ((Provincial)llamada).CostoLlamada;
                        }
                        else
                        {
                            retorno += ((Local)llamada).CostoLlamada;
                        }
                        break;


                }
            }
            return retorno;
        }
        public string Mostrar()
        {
            StringBuilder retorno=new StringBuilder();
            retorno.AppendLine($"Razon Social: {this.razonSocial}");
            retorno.AppendLine($"Ganancia total: {this.GananciasPorTodos}");
            retorno.AppendLine($"Ganancia por llamadas Locales: {this.GananciasPorLocal}");
            retorno.AppendLine($"Ganancia por llamadas Proviciales: {this.GananciasPorProvincial}");
            retorno.AppendLine("LLAMADAS REALIZADAS:");
            foreach (Llamada llamada in listaDeLlamadas)
            {
                retorno.AppendLine(llamada.Mostrar());
            }
            return retorno.ToString();
        }
        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdendarPorDuracion);
        }

    }
}
