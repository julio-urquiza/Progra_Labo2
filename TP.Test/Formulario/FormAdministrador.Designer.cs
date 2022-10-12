namespace Formulario
{
    partial class FormAdministrador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonDarDeAlta = new System.Windows.Forms.Button();
            this.buttonCambiarEstadoMaterias = new System.Windows.Forms.Button();
            this.buttonCrearMaterias = new System.Windows.Forms.Button();
            this.buttonAsignarProfesorMateria = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDarDeAlta
            // 
            this.buttonDarDeAlta.Location = new System.Drawing.Point(45, 38);
            this.buttonDarDeAlta.Name = "buttonDarDeAlta";
            this.buttonDarDeAlta.Size = new System.Drawing.Size(215, 59);
            this.buttonDarDeAlta.TabIndex = 0;
            this.buttonDarDeAlta.Text = "Dar de alta un usuario";
            this.buttonDarDeAlta.UseVisualStyleBackColor = true;
            this.buttonDarDeAlta.Click += new System.EventHandler(this.buttonDarDeAlta_Click);
            // 
            // buttonCambiarEstadoMaterias
            // 
            this.buttonCambiarEstadoMaterias.Location = new System.Drawing.Point(45, 103);
            this.buttonCambiarEstadoMaterias.Name = "buttonCambiarEstadoMaterias";
            this.buttonCambiarEstadoMaterias.Size = new System.Drawing.Size(215, 59);
            this.buttonCambiarEstadoMaterias.TabIndex = 1;
            this.buttonCambiarEstadoMaterias.Text = "Cambiar estado de materias";
            this.buttonCambiarEstadoMaterias.UseVisualStyleBackColor = true;
            // 
            // buttonCrearMaterias
            // 
            this.buttonCrearMaterias.Location = new System.Drawing.Point(45, 168);
            this.buttonCrearMaterias.Name = "buttonCrearMaterias";
            this.buttonCrearMaterias.Size = new System.Drawing.Size(215, 59);
            this.buttonCrearMaterias.TabIndex = 2;
            this.buttonCrearMaterias.Text = "Crear materias";
            this.buttonCrearMaterias.UseVisualStyleBackColor = true;
            // 
            // buttonAsignarProfesorMateria
            // 
            this.buttonAsignarProfesorMateria.Location = new System.Drawing.Point(45, 233);
            this.buttonAsignarProfesorMateria.Name = "buttonAsignarProfesorMateria";
            this.buttonAsignarProfesorMateria.Size = new System.Drawing.Size(215, 59);
            this.buttonAsignarProfesorMateria.TabIndex = 3;
            this.buttonAsignarProfesorMateria.Text = "Asignar profesor a materias";
            this.buttonAsignarProfesorMateria.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 336);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAsignarProfesorMateria);
            this.Controls.Add(this.buttonCrearMaterias);
            this.Controls.Add(this.buttonCambiarEstadoMaterias);
            this.Controls.Add(this.buttonDarDeAlta);
            this.Name = "FormAdministrador";
            this.Text = "FormAdministrador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDarDeAlta;
        private System.Windows.Forms.Button buttonCambiarEstadoMaterias;
        private System.Windows.Forms.Button buttonCrearMaterias;
        private System.Windows.Forms.Button buttonAsignarProfesorMateria;
        private System.Windows.Forms.Button button1;
    }
}