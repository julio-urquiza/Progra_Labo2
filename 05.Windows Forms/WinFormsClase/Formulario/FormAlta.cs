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

namespace Formulario
{
    public partial class FormAlta : Form
    {
        private Persona persona;
        public FormAlta()
        {
            InitializeComponent();
     
        }

        public Persona Persona 
        { 
            get
            {
                return this.persona;
            }
            set
            {
                if(persona is not null)
                {
                    this.persona = value;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string apellido=textBox2.Text;
            persona=new Persona(nombre, apellido);
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
        }
    }
}
