﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaForm
{
    public partial class Form1 : Form
    {
        DateTime diaHora;
        public Form1()
        {
            InitializeComponent();
        }


        public void asignarHora()
        {
            if(this.InvokeRequired)
            {
                Action delegado = asignarHora;
                this.Invoke(delegado); 
            }
            else
            {
                this.lblHora.Text = DateTime.Now.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                do
                {
                    asignarHora();
                    Thread.Sleep(1000);
                } while (true);
            });
        }
    }
}
