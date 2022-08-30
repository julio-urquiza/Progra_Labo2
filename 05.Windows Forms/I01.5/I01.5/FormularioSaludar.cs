using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I01._5
{
    public partial class FormularioSaludar : Form
    {
        private string nombre;
        private string apellido;
        public FormularioSaludar()
        {
            InitializeComponent();
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        private void botonSaludar_Click(object sender, EventArgs e)
        {
            this.nombre = this.textBox1.Text;
            this.apellido = this.textBox2.Text;
            if(this.Nombre=="julio" && this.Apellido=="urquiza")
            {
                Form2 formulario2 = new Form2(this.Nombre, this.apellido);

                formulario2.Show();
                this.Hide();
            }

        }
    }
}
