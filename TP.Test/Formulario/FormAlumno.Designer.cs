namespace Formulario
{
    partial class FormAlumno
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
            this.buttonInscribirseMateria = new System.Windows.Forms.Button();
            this.buttonDarAsistencia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonInscribirseMateria
            // 
            this.buttonInscribirseMateria.Location = new System.Drawing.Point(49, 109);
            this.buttonInscribirseMateria.Name = "buttonInscribirseMateria";
            this.buttonInscribirseMateria.Size = new System.Drawing.Size(238, 55);
            this.buttonInscribirseMateria.TabIndex = 0;
            this.buttonInscribirseMateria.Text = "Inscribirse a materias";
            this.buttonInscribirseMateria.UseVisualStyleBackColor = true;
            // 
            // buttonDarAsistencia
            // 
            this.buttonDarAsistencia.Location = new System.Drawing.Point(49, 167);
            this.buttonDarAsistencia.Name = "buttonDarAsistencia";
            this.buttonDarAsistencia.Size = new System.Drawing.Size(238, 55);
            this.buttonDarAsistencia.TabIndex = 1;
            this.buttonDarAsistencia.Text = "Dar asistencia a materias";
            this.buttonDarAsistencia.UseVisualStyleBackColor = true;
            // 
            // FormAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 319);
            this.Controls.Add(this.buttonDarAsistencia);
            this.Controls.Add(this.buttonInscribirseMateria);
            this.Name = "FormAlumno";
            this.Text = "FormAlumno";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonInscribirseMateria;
        private System.Windows.Forms.Button buttonDarAsistencia;
    }
}