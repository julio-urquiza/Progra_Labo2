namespace VistaForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLitros = new System.Windows.Forms.Label();
            this.lblKilometros = new System.Windows.Forms.Label();
            this.txtBoxLitros = new System.Windows.Forms.TextBox();
            this.txtBoxKilometros = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLitros
            // 
            this.lblLitros.AutoSize = true;
            this.lblLitros.Location = new System.Drawing.Point(23, 162);
            this.lblLitros.Name = "lblLitros";
            this.lblLitros.Size = new System.Drawing.Size(36, 15);
            this.lblLitros.TabIndex = 0;
            this.lblLitros.Text = "Litros";
            // 
            // lblKilometros
            // 
            this.lblKilometros.AutoSize = true;
            this.lblKilometros.Location = new System.Drawing.Point(23, 60);
            this.lblKilometros.Name = "lblKilometros";
            this.lblKilometros.Size = new System.Drawing.Size(64, 15);
            this.lblKilometros.TabIndex = 1;
            this.lblKilometros.Text = "Kilómetros";
            // 
            // txtBoxLitros
            // 
            this.txtBoxLitros.Location = new System.Drawing.Point(23, 180);
            this.txtBoxLitros.Name = "txtBoxLitros";
            this.txtBoxLitros.Size = new System.Drawing.Size(209, 23);
            this.txtBoxLitros.TabIndex = 2;
            // 
            // txtBoxKilometros
            // 
            this.txtBoxKilometros.Location = new System.Drawing.Point(23, 78);
            this.txtBoxKilometros.Name = "txtBoxKilometros";
            this.txtBoxKilometros.Size = new System.Drawing.Size(209, 23);
            this.txtBoxKilometros.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(277, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(225, 262);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(65, 246);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(128, 31);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 324);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txtBoxKilometros);
            this.Controls.Add(this.txtBoxLitros);
            this.Controls.Add(this.lblKilometros);
            this.Controls.Add(this.lblLitros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLitros;
        private System.Windows.Forms.Label lblKilometros;
        private System.Windows.Forms.TextBox txtBoxLitros;
        private System.Windows.Forms.TextBox txtBoxKilometros;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnCalcular;
    }
}
