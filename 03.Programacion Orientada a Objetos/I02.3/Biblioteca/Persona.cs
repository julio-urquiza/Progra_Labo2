using System;
using System.Text;
namespace Biblioteca
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaDeNacimiento;
        private int dni;

        public Persona(string nombre,DateTime fechaDeNacimiento,int dni)
        {
            this.SetNombre(nombre);
            this.SetFecha(fechaDeNacimiento); 
            this.SetDni(dni);
        }
        public void SetNombre(string nombre)
        {
            this.nombre=nombre;
        }
        public void SetFecha(DateTime fechaDeNacimiento)
        {
            this.fechaDeNacimiento = fechaDeNacimiento;
        }
        public void SetDni(int dni)
        {
            this.dni = dni;
        }

        public string GetNombre()
        {
            return this.nombre;
        }
        public DateTime GetFecha()
        {
            return this.fechaDeNacimiento;
        }
        public int GetDni()
        {
            return this.dni;
        }

        public int CalcularEdad()
        {
            DateTime diaHoy = DateTime.Today;
            return (diaHoy.Subtract(this.GetFecha()).Days)/360;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.GetNombre());
            sb.AppendLine(this.GetDni().ToString());
            sb.AppendLine(this.GetFecha().ToShortDateString().ToString());
            sb.Append(this.CalcularEdad().ToString());
            return sb.ToString();
        }
        public string EsMayorDeEdad()
        {
            string retorno = "Es menor";
            if (this.CalcularEdad()>=18)
            {
                retorno = "Es mayor de edad";
            }
            return retorno;
        }
    }
}
