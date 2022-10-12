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
    public partial class Form1 : Form
    {

        private int i=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.agregarDatos("1", "juan", "perez", "12345678", "masculino");
            this.agregarDatos("2", "agustina", "sanches", "32165487", "femenino");
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(!comprobarId() && !string.IsNullOrWhiteSpace(txtId.Text))
            {
                i=dgvEmpleados.Rows.Add();
                this.modificarDatos();
            }
            txtId.Text = String.Empty;
            txtNombre.Text =String.Empty;
            txtApellido.Text = String.Empty;
            txtDNI.Text = String.Empty;
            txtGenero.Text = String.Empty;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.modificarDatos();
        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            if(i!=-1)
            {
                txtId.Text = (string)dgvEmpleados.Rows[i].Cells[0].Value;
                txtNombre.Text=(string)dgvEmpleados.Rows[i].Cells[1].Value;
                txtApellido.Text= (string)dgvEmpleados.Rows[i].Cells[2].Value;
                txtDNI.Text= (string)dgvEmpleados.Rows[i].Cells[3].Value;
                txtGenero.Text= (string)dgvEmpleados.Rows[i].Cells[4].Value;
            }
        }
        public bool modificarDatos()
        {
            bool retono = false;
            if(i!=-1 && !string.IsNullOrWhiteSpace(txtNombre.Text) && !string.IsNullOrWhiteSpace(txtApellido.Text) && !string.IsNullOrWhiteSpace(txtDNI.Text) && !string.IsNullOrWhiteSpace(txtGenero.Text) && !string.IsNullOrWhiteSpace(txtId.Text))
            {
                dgvEmpleados.Rows[i].Cells[0].Value = txtId.Text;
                dgvEmpleados.Rows[i].Cells[1].Value = txtNombre.Text;
                dgvEmpleados.Rows[i].Cells[2].Value = txtApellido.Text;
                dgvEmpleados.Rows[i].Cells[3].Value = txtDNI.Text;
                dgvEmpleados.Rows[i].Cells[4].Value = txtGenero.Text;
                retono = true;
            }
            return retono;
        }
        public bool comprobarId()
        {
            bool retorno=false;
            if(!string.IsNullOrWhiteSpace(txtId.Text))
            {
                foreach(DataGridViewRow row in dgvEmpleados.Rows)
                {
                    if((string)row.Cells[0].Value== txtId.Text)
                    {
                        retorno=true;
                    }
                }
            }
            return retorno;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if(dgvEmpleados.Rows.Count>0)
            {
                dgvEmpleados.Rows.RemoveAt(i);
                i--;
            }
        }
        public void agregarDatos(string id,string nombre,string apellido,string DNI,string genero)
        {
            i = dgvEmpleados.Rows.Add();
            dgvEmpleados.Rows[i].Cells[0].Value =id;
            dgvEmpleados.Rows[i].Cells[1].Value =nombre;
            dgvEmpleados.Rows[i].Cells[2].Value =apellido;
            dgvEmpleados.Rows[i].Cells[3].Value =DNI;
            dgvEmpleados.Rows[i].Cells[4].Value =genero;
        }

        private void btnAbrirOtroForm_Click(object sender, EventArgs e)
        {
            Form2 formulario2 = new Form2(this.dgvEmpleados);
            formulario2.ShowDialog();

        }
    }
}
