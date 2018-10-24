namespace Seguridad
{
    partial class MantPerfiles
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
            this.Guardar = new System.Windows.Forms.Button();
            this.Txt_IdPerfil = new System.Windows.Forms.TextBox();
            this.Txt_DescripPerfil = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(225, 237);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 0;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Txt_IdPerfil
            // 
            this.Txt_IdPerfil.Location = new System.Drawing.Point(199, 103);
            this.Txt_IdPerfil.Name = "Txt_IdPerfil";
            this.Txt_IdPerfil.Size = new System.Drawing.Size(141, 20);
            this.Txt_IdPerfil.TabIndex = 1;
            // 
            // Txt_DescripPerfil
            // 
            this.Txt_DescripPerfil.Location = new System.Drawing.Point(199, 177);
            this.Txt_DescripPerfil.Name = "Txt_DescripPerfil";
            this.Txt_DescripPerfil.Size = new System.Drawing.Size(141, 20);
            this.Txt_DescripPerfil.TabIndex = 2;
            // 
            // MantPerfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 363);
            this.Controls.Add(this.Txt_DescripPerfil);
            this.Controls.Add(this.Txt_IdPerfil);
            this.Controls.Add(this.Guardar);
            this.Name = "MantPerfiles";
            this.Text = "MantPerfiles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Guardar;
        public System.Windows.Forms.TextBox Txt_IdPerfil;
        public System.Windows.Forms.TextBox Txt_DescripPerfil;
    }
}