using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public enum SistemaOperativo
    {
        ANDROID,IOS
    }
    public abstract class Aplicacion
    {
        protected string nombre;
        private SistemaOperativo sistemaOperativo;
        protected int tamanioMB;


        public SistemaOperativo SistemaOperativo
        {
            get
            {
                return this.sistemaOperativo;
            }
        }
        protected abstract int Tamanio { get;}


        protected Aplicacion(string nombre, SistemaOperativo sistemaOperativo, int tamanioMB)
        {
            this.nombre = nombre;
            this.sistemaOperativo = sistemaOperativo;
            this.tamanioMB = tamanioMB;
        }
        public virtual string ObtenerInformacion()
        {
            StringBuilder retorno=new StringBuilder();
            retorno.AppendLine($"Nombre: {this.nombre}");
            retorno.AppendLine($"Sistema operativo: {this.sistemaOperativo}");
            retorno.AppendLine($"Tamaño en Mb: {this.tamanioMB}");
            return retorno.ToString();
        }
        public override string ToString()
        {
            return this.nombre; 
        }
        public static implicit operator Aplicacion(List<Aplicacion> listApp)
        {
            int mayorTamanio=int.MinValue;
            Aplicacion retorno=null;
            foreach(Aplicacion aplicacion in listApp)
            {
                if(aplicacion.tamanioMB>mayorTamanio)
                {
                    retorno = aplicacion;
                }
            }
            return retorno;
        }
        public static bool operator ==(List<Aplicacion> listApp,Aplicacion app)
        {
            foreach(Aplicacion aplicacion in listApp)
            {
                if(app.nombre==aplicacion.nombre)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(List<Aplicacion> listApp, Aplicacion app)
        {
            return !(listApp == app);
        }
        public static bool operator +(List<Aplicacion> listApp, Aplicacion app)
        {
            if(listApp is not null && app is not null && listApp!=app)
            {
                listApp.Add(app);
                return true;
            }
            return false;
        }
    }
}
