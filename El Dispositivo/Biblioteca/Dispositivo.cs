using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Dispositivo
    {
        private static List<Aplicacion> appInstaladas;
        private static SistemaOperativo sistemaOperativo;

        static Dispositivo()
        {
            Dispositivo.appInstaladas = new List<Aplicacion>();
            Dispositivo.sistemaOperativo = SistemaOperativo.ANDROID;

        }
        public static bool InstalarApp(Aplicacion app)
        {
            if(app is not null && app.SistemaOperativo==Dispositivo.sistemaOperativo)
            {
                return appInstaladas + app;
            }
            return false;
        }
        public static string ObtenerInformacionDispositivo()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendLine(Dispositivo.sistemaOperativo.ToString());
            foreach(Aplicacion aplicacion in appInstaladas)
            {
                retorno.AppendLine(aplicacion.ObtenerInformacion());
            }
            return retorno.ToString();
        }
    }
}
