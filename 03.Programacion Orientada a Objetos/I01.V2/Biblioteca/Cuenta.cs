using System;

namespace Biblioteca
{
    public class Cuenta
    {
        private string titular;
        private float cantidad;

        public Cuenta(string titular, float cantidad)
        {
            this.titular = titular; 
            this.cantidad = cantidad;
        }
        public string getTitular()
        {
            return this.titular;
        }
        public float getCantidad()
        {
            return this.cantidad;
        }
        public string mostrar()
        {
            return String.Format("Cuenta de: {0} con {1} pesos",this.titular,this.cantidad);
        }
        public void ingresar(float cantidadIngresar)
        {
            if (Math.Sign(cantidadIngresar) != -1)
            {
                this.cantidad+=cantidadIngresar;
            }
        }
        public void retirar(float cantidadRetirar)
        {
            this.cantidad -= cantidadRetirar;
        }
    }
}
