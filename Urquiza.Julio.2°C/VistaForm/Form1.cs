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
    public partial class FormAtencion : Form
    {
        public FormAtencion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstMedicos.Items.Add(new PersonalMedico("Fede", "Dávila", new DateTime(1999, 12, 12), false));
            lstMedicos.Items.Add(new PersonalMedico("Esteban", "Prieto", new DateTime(1951, 11, 12), true));
            lstPacientes.Items.Add(new Paciente("Diego", "Cagna", new DateTime(1998, 6, 16), "Tigre"));
            lstPacientes.Items.Add(new Paciente("Alfredo", "Moreno", new DateTime(1989, 1, 21), "DF"));
            lstPacientes.Items.Add(new Paciente("Blas", "Giunta", new DateTime(1912, 12, 12), "La Boca"));
            lstPacientes.Items.Add(new Paciente("John Jairo", "Trelles", new DateTime(1978, 8, 30), "Medellín"));
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            if(lstMedicos.SelectedItems.Count==1 && lstPacientes.SelectedItems.Count==1)
            {
                PersonalMedico doctor = (PersonalMedico)lstMedicos.SelectedItem;
                Paciente paciente=(Paciente)lstPacientes.SelectedItem;
                paciente.Diagnostico = "Paciente curado";
                Consulta consulta = doctor + paciente;

                MessageBox.Show("Paciente atendido");
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Medico y un Paciente para poder continuar.","Error de datos",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void FormAtencion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.rtbInfoMedico.Text=Persona.FichaPersonal((Persona)lstMedicos.SelectedItem);
        }
    }
}
