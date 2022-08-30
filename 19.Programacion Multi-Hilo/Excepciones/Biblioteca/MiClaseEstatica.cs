using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class MiClaseEstatica
    {
        public static string MiMetodoEstaitico(string value)
        {
            MiClase miClase;
            try
            {
                miClase = new MiClase(value);
            }
            catch (NombreInvalidoException ex)
            {
                throw new NuevaExcepcion("Error producido en mi excepcion estática",ex);
            }
            return "No se produjo ningun error";
        }
    }
}
