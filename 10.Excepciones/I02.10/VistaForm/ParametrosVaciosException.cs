using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistaForm
{
    internal class ParametrosVaciosException:Exception
    {
        public ParametrosVaciosException(string mensaje):base(mensaje,null)
        {

        }
        public ParametrosVaciosException(string mensaje, Exception inner):base(mensaje, inner)
        {

        }
    }
}
