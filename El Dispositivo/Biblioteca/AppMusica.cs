using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class AppMusica:Aplicacion
    {
        private List<string> listaCanciones;

        protected override int Tamanio
        {
            get 
            {
                return this.tamanioMB+(this.listaCanciones.Count*2);
            }
        }

        public AppMusica(string nombre, SistemaOperativo sistemaOperativo, int tamanioMB) : base(nombre, sistemaOperativo, tamanioMB)
        {
            this.listaCanciones = new List<string>();
        }
        public AppMusica(string nombre, SistemaOperativo sistemaOperativo, int tamanioMB,List<string> listaCanciones) : this(nombre, sistemaOperativo, tamanioMB)
        {
            this.listaCanciones = listaCanciones;
        }
        public override string ObtenerInformacion()
        {
            StringBuilder retorno=new StringBuilder();
            retorno.AppendLine(base.ObtenerInformacion());
            retorno.AppendLine("Lista de canciones");
            foreach (string s in listaCanciones)
            {
                retorno.AppendLine($"Nombre de la Canción: {s}");
            }
            return retorno.ToString();
        }
    }
}
