namespace VistaForm
{
    partial class FrmMenu
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
            this.GenerarLlamadaBtn = new System.Windows.Forms.Button();
            this.FacturacionTotalBtn = new System.Windows.Forms.Button();
            this.FacturacionLocalBtn = new System.Windows.Forms.Button();
            this.FacturacionProvincialBtn = new System.Windows.Forms.Button();
            this.SalirBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GenerarLlamadaBtn
            // 
            this.GenerarLlamadaBtn.Location = new System.Drawing.Point(63, 34);
            this.GenerarLlamadaBtn.Name = "GenerarLlamadaBtn";
            this.GenerarLlamadaBtn.Size = new System.Drawing.Size(224, 70);
            this.GenerarLlamadaBtn.TabIndex = 0;
            this.GenerarLlamadaBtn.Text = "Generar Llamada";
            this.GenerarLlamadaBtn.UseVisualStyleBackColor = true;
            this.GenerarLlamadaBtn.Click += new System.EventHandler(this.GenerarLlamadaBtn_Click);
            // 
            // FacturacionTotalBtn
            // 
            this.FacturacionTotalBtn.Location = new System.Drawing.Point(63, 110);
            this.FacturacionTotalBtn.Name = "FacturacionTotalBtn";
            this.FacturacionTotalBtn.Size = new System.Drawing.Size(224, 70);
            this.FacturacionTotalBtn.TabIndex = 1;
            this.FacturacionTotalBtn.Text = "Facturación Total";
            this.FacturacionTotalBtn.UseVisualStyleBackColor = true;
            this.FacturacionTotalBtn.Click += new System.EventHandler(this.FacturacionTotalBtn_Click);
            // 
            // FacturacionLocalBtn
            // 
            this.FacturacionLocalBtn.Location = new System.Drawing.Point(63, 186);
            this.FacturacionLocalBtn.Name = "FacturacionLocalBtn";
            this.FacturacionLocalBtn.Size = new System.Drawing.Size(224, 70);
            this.FacturacionLocalBtn.TabIndex = 2;
            this.FacturacionLocalBtn.Text = "Facturación Local";
            this.FacturacionLocalBtn.UseVisualStyleBackColor = true;
            this.FacturacionLocalBtn.Click += new System.EventHandler(this.FacturacionLocalBtn_Click);
            // 
            // FacturacionProvincialBtn
            // 
            this.FacturacionProvincialBtn.Location = new System.Drawing.Point(63, 262);
            this.FacturacionProvincialBtn.Name = "FacturacionProvincialBtn";
            this.FacturacionProvincialBtn.Size = new System.Drawing.Size(224, 70);
            this.FacturacionProvincialBtn.TabIndex = 3;
            this.FacturacionProvincialBtn.Text = "Facturación Provincial";
            this.FacturacionProvincialBtn.UseVisualStyleBackColor = true;
            this.FacturacionProvincialBtn.Click += new System.EventHandler(this.FacturacionProvincialBtn_Click);
            // 
            // SalirBtn
            // 
            this.SalirBtn.Location = new System.Drawing.Point(63, 338);
            this.SalirBtn.Name = "SalirBtn";
            this.SalirBtn.Size = new System.Drawing.Size(224, 70);
            this.SalirBtn.TabIndex = 4;
            this.SalirBtn.Text = "Salir";
            this.SalirBtn.UseVisualStyleBackColor = true;
            this.SalirBtn.Click += new System.EventHandler(this.SalirBtn_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 450);
            this.Controls.Add(this.SalirBtn);
            this.Controls.Add(this.FacturacionProvincialBtn);
            this.Controls.Add(this.FacturacionLocalBtn);
            this.Controls.Add(this.FacturacionTotalBtn);
            this.Controls.Add(this.GenerarLlamadaBtn);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Central Telefónica";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenu_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GenerarLlamadaBtn;
        private System.Windows.Forms.Button FacturacionTotalBtn;
        private System.Windows.Forms.Button FacturacionLocalBtn;
        private System.Windows.Forms.Button FacturacionProvincialBtn;
        private System.Windows.Forms.Button SalirBtn;
    }
}
