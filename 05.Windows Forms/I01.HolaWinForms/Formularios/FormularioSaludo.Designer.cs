namespace Formularios
{
    partial class FormularioSaludo
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
            this.labelHola = new System.Windows.Forms.Label();
            this.labelSoy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelHola
            // 
            this.labelHola.AutoSize = true;
            this.labelHola.Location = new System.Drawing.Point(114, 67);
            this.labelHola.Name = "labelHola";
            this.labelHola.Size = new System.Drawing.Size(120, 15);
            this.labelHola.TabIndex = 0;
            this.labelHola.Text = "Hola Windows Forms";
            // 
            // labelSoy
            // 
            this.labelSoy.AutoSize = true;
            this.labelSoy.Location = new System.Drawing.Point(114, 161);
            this.labelSoy.Name = "labelSoy";
            this.labelSoy.Size = new System.Drawing.Size(26, 15);
            this.labelSoy.TabIndex = 1;
            this.labelSoy.Text = "Soy";
            // 
            // FormularioSaludo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 243);
            this.Controls.Add(this.labelSoy);
            this.Controls.Add(this.labelHola);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioSaludo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saludo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHola;
        private System.Windows.Forms.Label labelSoy;
    }
}