namespace Formulario
{
    partial class FormProfesor
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
            this.buttonCrearExamen = new System.Windows.Forms.Button();
            this.buttonPonerNotaExamen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCrearExamen
            // 
            this.buttonCrearExamen.Location = new System.Drawing.Point(43, 73);
            this.buttonCrearExamen.Name = "buttonCrearExamen";
            this.buttonCrearExamen.Size = new System.Drawing.Size(154, 55);
            this.buttonCrearExamen.TabIndex = 0;
            this.buttonCrearExamen.Text = "Crear Examenes";
            this.buttonCrearExamen.UseVisualStyleBackColor = true;
            // 
            // buttonPonerNotaExamen
            // 
            this.buttonPonerNotaExamen.Location = new System.Drawing.Point(43, 174);
            this.buttonPonerNotaExamen.Name = "buttonPonerNotaExamen";
            this.buttonPonerNotaExamen.Size = new System.Drawing.Size(154, 55);
            this.buttonPonerNotaExamen.TabIndex = 1;
            this.buttonPonerNotaExamen.Text = "Poner nota examen";
            this.buttonPonerNotaExamen.UseVisualStyleBackColor = true;
            // 
            // FormProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 324);
            this.Controls.Add(this.buttonPonerNotaExamen);
            this.Controls.Add(this.buttonCrearExamen);
            this.Name = "FormProfesor";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCrearExamen;
        private System.Windows.Forms.Button buttonPonerNotaExamen;
    }
}