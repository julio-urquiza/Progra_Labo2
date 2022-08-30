using System;

namespace Biblioteca
{
    public static class Fechas
    {
        public static int CalcularDias(DateTime fecha)
        {
            int retorno;
            DateTime dateTime = new DateTime();
            dateTime=DateTime.Today;
            retorno =dateTime.Subtract(fecha).Days;

            return retorno;
        }
    }
}
