using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bioblioteca;

namespace Formulario
{
    public partial class Form1 : Form
    {
        private Dictionary<int,Persona> lista;
        private DataGridView grillaDatos;
        public Form1()
        {
            InitializeComponent();
            lista=new Dictionary<int, Persona>();
            lista.Add(1,new Administrador("juan","jonas",123456,1));
            lista.Add(2,new Profesor("luis","lomas",123456,2));
            lista.Add(3,new Profesor("pipo","peposo",123456,3));
            lista.Add(4,new Alumno("julio","juad",123456,4));
            lista.Add(5,new Alumno("pepe","peam",123456,5));
            lista.Add(6,new Alumno("dario","damasco",123456,6));
            lista.Add(7,new Alumno("pedro","pescado",123456,7));
            lista.Add(8,new Alumno("walter","water",123456,8));
            grillaDatos = new DataGridView();
            
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            int i = confirmarUsuario();
            if (i !=-1)
            {
                if(this.lista[i].GetType()==typeof(Administrador))
                {
                    MessageBox.Show("Bienvenido administrador");
                    //this.Hide();
                    FormAdministrador formAdmin = new FormAdministrador(lista,i);
                    formAdmin.ShowDialog();
                }
                else if(this.lista[i].GetType()==typeof(Profesor))
                {
                    MessageBox.Show("Bienvenido profesor");
                    this.Hide();
                    FormProfesor formProf = new FormProfesor(lista,i);
                    formProf.ShowDialog();
                }
                else if (this.lista[i].GetType() == typeof(Alumno))
                {
                    MessageBox.Show("Bienvenido alumno");
                    this.Hide();
                    FormAlumno formAlum = new FormAlumno(lista,i);
                    formAlum.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
        }
        private int confirmarUsuario()
        {
            int retorno = -1;
            foreach(KeyValuePair<int,Persona> kvp in lista)
            {
                if (kvp.Value.Nombre == textBoxUsuario.Text && kvp.Value.Apellido == textBoxContraseña.Text)
                {
                    retorno = kvp.Key;
                }
            }
            return retorno;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lista[1].ToString());
        }
    }
}
