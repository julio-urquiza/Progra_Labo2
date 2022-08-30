using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;
namespace I02._5
{
    public partial class Form1 : Form
    {
        private string[] curso;
        private string direccion;
        private int edad;
        private string genero;
        private string nombre;
        private string pais;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.nombre = this.textBoxNombre.Text;
            this.direccion = this.textBoxDireccion.Text;
            this.edad = (int)this.numericUpDownEdad.Value;
            this.genero =this.radioButtonMasculino.Text;
            this.pais=this.listBoxPaises.Text;
            //this.curso=this.groupBoxCursos;
            
            Ingresante ingresante = new Ingresante(this.nombre,this.direccion,this.genero,this.pais,this.curso,this.edad);

            MessageBox.Show(ingresante.Mostrar());
        }
    }
}
