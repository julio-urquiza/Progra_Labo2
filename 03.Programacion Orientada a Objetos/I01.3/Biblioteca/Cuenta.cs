using System;
using System.Text;

namespace Biblioteca
{
    public class Cuenta
    {
        #region atributos
        public string titular;
        public decimal cantidad;
        #endregion

        public Cuenta(string titular, decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }
        public string GetTitular()
        {
            return this.titular;
        }
        public decimal GetCantidad()
        {
            return this.cantidad;
        }

        public string MostrarDatosCuenta()
        {
            StringBuilder dato = new StringBuilder();
            dato.AppendLine(GetCantidad().ToString());
            dato.AppendLine(GetTitular());

            return dato.ToString();
        }
        public void Ingresar(decimal monto)
        {
            if (monto>0)
            {
                this.cantidad += monto;
            }
        }
        public void Retirar(decimal monto)
        {
            this.cantidad -= monto;
        }
    }
}
