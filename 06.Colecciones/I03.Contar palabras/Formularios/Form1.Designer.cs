namespace Formularios
{
    partial class FormContar
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
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.buttonContar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(0, 0);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(462, 375);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            // 
            // buttonContar
            // 
            this.buttonContar.Location = new System.Drawing.Point(327, 400);
            this.buttonContar.Name = "buttonContar";
            this.buttonContar.Size = new System.Drawing.Size(124, 53);
            this.buttonContar.TabIndex = 1;
            this.buttonContar.Text = "Contar";
            this.buttonContar.UseVisualStyleBackColor = true;
            this.buttonContar.Click += new System.EventHandler(this.buttonContar_Click);
            // 
            // FormContar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 465);
            this.Controls.Add(this.buttonContar);
            this.Controls.Add(this.richTextBox);
            this.Name = "FormContar";
            this.Text = "Contar Palabras";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button buttonContar;
    }
}
