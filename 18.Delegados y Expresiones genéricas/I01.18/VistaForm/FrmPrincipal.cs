using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaForm
{
    public partial class FrmPrincipal : Form
    {
        FrmMostrar frmMostrar;
        FrmTestDelegados frmTestDelegados;
        public FrmPrincipal()
        {
            InitializeComponent();
            frmMostrar = new FrmMostrar();
            frmTestDelegados = new FrmTestDelegados();
        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.frmTestDelegados.Show();
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.frmMostrar.Show();
        }
    }
}
