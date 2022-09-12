using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FormularioDatos : Form
    {
        public FormularioDatos()
        {
            InitializeComponent();
        }

        private void buttonSaludar_Click(object sender, EventArgs e)
        {
            FormularioSaludo formSaludo=new FormularioSaludo(textBoxNombre.Text,textBoxApellido.Text,comboBoxMaterias.Text);
            formSaludo.ShowDialog();
        }

        private void FormularioDatos_Load(object sender, EventArgs e)
        {
            comboBoxMaterias.Items.Add("Programacion II");
            comboBoxMaterias.Items.Add("Laboratorio II ");
            comboBoxMaterias.Items.Add("Ingles");
            comboBoxMaterias.SelectedIndex = 0;
        }
    }
}
