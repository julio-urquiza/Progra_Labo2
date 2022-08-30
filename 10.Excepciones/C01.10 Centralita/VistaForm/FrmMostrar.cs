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
    public partial class FrmMostrar : Form
    {
        Centralita centralita;
        TipoLlamada tipoLlamada;
        public FrmMostrar(Centralita centralita,TipoLlamada tipoLlamada)
        {
            InitializeComponent();
            this.centralita = centralita;
            this.tipoLlamada = tipoLlamada;
        }

        private void FrmMostrar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            this.richTextBoxFacturacion.Text=centralita.MostrarLlamadasTipo(tipoLlamada);
        }
    }
}
