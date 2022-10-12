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
        DataTable dt;

        public Form1()
        {
            InitializeComponent();
            dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Apellido");
            dt.Columns.Add("DNI");
            dt.Columns.Add("Genero");
            DataRow row = dt.NewRow();
            row["ID"] = 1;
            row["Nombre"] = "Julio";
            row["Apellido"] = "Urquiza";
            row["DNI"] = 12345678;
            row["Genero"] = "masculino";

            dt.Rows.Add(row);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.dgvDatos.DataSource=dt;
            MessageBox.Show("hola que tal");

        }
        
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{dt.Rows[0]["ID"]}");

        }
    }
}
