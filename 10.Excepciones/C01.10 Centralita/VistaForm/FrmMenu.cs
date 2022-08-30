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

namespace VistaForm
{
    public partial class FrmMenu : Form
    {
        Centralita centralita;
        public FrmMenu()
        {
            InitializeComponent();
            centralita= new Centralita("Pepillos Corporation");
        }

        private void GenerarLlamadaBtn_Click(object sender, EventArgs e)
        {
            FrmLlamdor frmLlamador = new FrmLlamdor(centralita);
            frmLlamador.ShowDialog();
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void SalirBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FacturacionTotalBtn_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(centralita,TipoLlamada.Todas);
            frmMostrar.ShowDialog();
        }

        private void FacturacionLocalBtn_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(centralita, TipoLlamada.Local);
            frmMostrar.ShowDialog();
        }

        private void FacturacionProvincialBtn_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(centralita, TipoLlamada.Provincial);
            frmMostrar.ShowDialog();
        }
    }
}
