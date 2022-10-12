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
    public partial class FrmLlamdor : Form
    {
        Centralita centralita;
        private bool focus =true;
        public FrmLlamdor(Centralita centralita)
        {
            InitializeComponent();
            this.centralita = centralita;

        }

        private void textBoxNroDeDestino_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.focus = true;   
        }

        private void textBoxNroDeOrigen_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.focus = false;
        }

        private void FrmLlamdor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        # region botones
        private void button1_Click(object sender, EventArgs e)
        {
            if(focus)
            {
                this.textBoxNroDeDestino.Text += "1";
            }
            else
            {
                this.textBoxNroDeOrigen.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (focus)
            {
                this.textBoxNroDeDestino.Text += "2";
            }
            else
            {
                this.textBoxNroDeOrigen.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (focus)
            {
                this.textBoxNroDeDestino.Text += "3";
            }
            else
            {
                this.textBoxNroDeOrigen.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (focus)
            {
                this.textBoxNroDeDestino.Text += "4";
            }
            else
            {
                this.textBoxNroDeOrigen.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (focus)
            {
                this.textBoxNroDeDestino.Text += "5";
            }
            else
            {
                this.textBoxNroDeOrigen.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (focus)
            {
                this.textBoxNroDeDestino.Text += "6";
            }
            else
            {
                this.textBoxNroDeOrigen.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (focus)
            {
                this.textBoxNroDeDestino.Text += "7";
            }
            else
            {
                this.textBoxNroDeOrigen.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (focus)
            {
                this.textBoxNroDeDestino.Text += "8";
            }
            else
            {
                this.textBoxNroDeOrigen.Text += "8";
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (focus)
            {
                this.textBoxNroDeDestino.Text += "9";
            }
            else
            {
                this.textBoxNroDeOrigen.Text += "9";

            }
        }

        private void buttonAsterico_Click(object sender, EventArgs e)
        {
            if (focus)
            {
                this.textBoxNroDeDestino.Text += "*";
            }
            else
            {
                this.textBoxNroDeOrigen.Text += "*";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (focus)
            {
                this.textBoxNroDeDestino.Text += "0";
            }
            else
            {
                this.textBoxNroDeOrigen.Text += "0";
            }
        }

        private void buttonNumeral_Click(object sender, EventArgs e)
        {
            if (focus)
            {
                this.textBoxNroDeDestino.Text += "#";
            }
            else
            {
                this.textBoxNroDeOrigen.Text += "#";
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            if(focus)
            {
                this.textBoxNroDeDestino.Text = String.Empty;
            }
            else
            {
                this.textBoxNroDeOrigen.Text = String.Empty;
            }
        }
        # endregion 

        private void buttonLlamar_Click(object sender, EventArgs e)
        {
            if(!(this.textBoxNroDeDestino.Text==string.Empty || this.textBoxNroDeOrigen.Text==string.Empty))
            {
                Llamada llamada;
                if(textBoxNroDeDestino.Text.Contains("#"))
                {
                    llamada = new Provincial(this.textBoxNroDeOrigen.Text,(Franja)comboBoxFranja.SelectedItem, 12f, this.textBoxNroDeDestino.Text);
                }
                else
                {
                    llamada=new Local(this.textBoxNroDeOrigen.Text,12f,this.textBoxNroDeDestino.Text,150f);
                }
                _ = centralita + llamada;
                MessageBox.Show(llamada.ToString());
            }
            else
            {
                MessageBox.Show("rellane los textBox capo");
            }

        }

        private void FrmLlamdor_Load(object sender, EventArgs e)
        {
            // Carga
            this.comboBoxFranja.DataSource = Enum.GetValues(typeof(Franja));
            // Lectura
            Franja franjas;
            Enum.TryParse<Franja>(comboBoxFranja.SelectedValue.ToString(),out franjas);
            this.comboBoxFranja.Enabled=false;
        }

        private void textBoxNroDeDestino_TextChanged(object sender, EventArgs e)
        {
            if(!textBoxNroDeDestino.Text.Contains("#"))
            {
                comboBoxFranja.Text = "Desabilitado";
                comboBoxFranja.Enabled=false;
            }
            else
            {
                comboBoxFranja.Text = "Franja";
                comboBoxFranja.Enabled = true;
            }

        }
    }

}
