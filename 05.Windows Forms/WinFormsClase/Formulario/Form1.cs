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
    public partial class Form1 : Form
    {
        private Persona[] personas;
        public Form1()
        {
            InitializeComponent();
            this.personas = new Persona[10];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAlta formAlta = new FormAlta();
            DialogResult dr=formAlta.ShowDialog();
            if(dr==DialogResult.OK)
            {
                MessageBox.Show(formAlta.Persona.MostrarInformacion());
                for(int i=0;i<personas.Length;i++)
                {
                    if(personas[i] is null && formAlta.Persona is not null)
                    {
                        personas[i] = formAlta.Persona;
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("No se pudo cargar");
            }
            richTextBox1.Text=String.Empty;
            for(int i=0;i<personas.Length;i++)
            {
                if(personas[i] is not null)
                {
                    richTextBox1.Text+=personas[i].MostrarInformacion();
                }
            }
        }

        private void cargatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }
    }
}
