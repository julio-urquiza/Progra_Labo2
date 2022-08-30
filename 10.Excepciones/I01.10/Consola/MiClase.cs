using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    public class MiClase
    {
        public static void MiMetodo()
        {
            throw new DivideByZeroException();
        }
        public MiClase()
        {
            try
            {
                MiClase.MiMetodo();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public MiClase(Exception excepcion)
        {
            try
            {
                MiClase miClase = new MiClase();
            }
            catch(Exception ex)
            {

            }

        }
    }
}
