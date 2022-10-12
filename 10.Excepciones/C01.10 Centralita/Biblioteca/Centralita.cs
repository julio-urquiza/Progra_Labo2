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
        private string Mostrar()
        {
            StringBuilder retorno=new StringBuilder();
            retorno.AppendLine($"Razon Social: {this.razonSocial}");
            retorno.AppendLine($"Ganancia total: {this.GananciasPorTodos}");
            retorno.AppendLine($"Ganancia por llamadas Locales: {this.GananciasPorLocal}");
            retorno.AppendLine($"Ganancia por llamadas Proviciales: {this.GananciasPorProvincial}");
            retorno.AppendLine("LLAMADAS REALIZADAS:");
            foreach (Llamada llamada in listaDeLlamadas)
            {
                retorno.AppendLine(llamada.ToString());
            }
            return retorno.ToString();
        }
        public string MostrarLlamadasTipo(TipoLlamada tipo)
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendLine($"Razon Social: {this.razonSocial}");
            retorno.AppendLine($"Ganancia total: {this.GananciasPorTodos}");
            retorno.AppendLine($"Ganancia por llamadas Locales: {this.GananciasPorLocal}");
            retorno.AppendLine($"Ganancia por llamadas Proviciales: {this.GananciasPorProvincial}");
            retorno.AppendLine("LLAMADAS REALIZADAS:");
            foreach (Llamada llamada in listaDeLlamadas)
            {
                switch (tipo)
                {
                    case TipoLlamada.Local:
                        if (llamada.GetType() == typeof(Local))
                        {
                            retorno.AppendLine(llamada.ToString());
                        }
                        break;
                    case TipoLlamada.Provincial:
                        if (llamada.GetType() == typeof(Provincial))
                        {
                            retorno.AppendLine(llamada.ToString());
                        }
                        break;
                    case TipoLlamada.Todas:
                        retorno.AppendLine(llamada.ToString());
                        break;
                }
            }
            return retorno.ToString();
        }
        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdendarPorDuracion);
        }
        public override string ToString()
        {
            return this.Mostrar();  
        }
        private void AgregarLlamada(Llamada nuebaLlamada)
        {
            if(nuebaLlamada is not null)
            {
                this.listaDeLlamadas.Add(nuebaLlamada);
            }
        }
        public static bool operator ==(Centralita centralita,Llamada llamada)
        {
            if(centralita is not null && llamada is not null)
            {
                return centralita.listaDeLlamadas.Contains(llamada);
            }
            return false;
        }
        public static bool operator !=(Centralita centralita,Llamada llamada)
        {
            return !(centralita == llamada);
        }

        public static Centralita operator +(Centralita centralita,Llamada llamada)
        {
            if(centralita==llamada)
            {
                throw new CentralitaException("La llamada ya esta en registrada","Centralita","operador +");
            }
            centralita.AgregarLlamada(llamada);
            return centralita;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (ReferenceEquals(obj, null))
            {
                return false;
            }

            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
