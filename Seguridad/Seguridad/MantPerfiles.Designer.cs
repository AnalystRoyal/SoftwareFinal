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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Dgv_Perfiles = new System.Windows.Forms.DataGridView();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Perfiles)).BeginInit();
            this.SuspendLayout();
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(204, 298);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 0;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Txt_IdPerfil
            // 
            this.Txt_IdPerfil.Location = new System.Drawing.Point(169, 102);
            this.Txt_IdPerfil.Name = "Txt_IdPerfil";
            this.Txt_IdPerfil.Size = new System.Drawing.Size(141, 20);
            this.Txt_IdPerfil.TabIndex = 1;
            // 
            // Txt_DescripPerfil
            // 
            this.Txt_DescripPerfil.Location = new System.Drawing.Point(169, 177);
            this.Txt_DescripPerfil.Name = "Txt_DescripPerfil";
            this.Txt_DescripPerfil.Size = new System.Drawing.Size(141, 20);
            this.Txt_DescripPerfil.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID Perfil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descripción Perfil";
            // 
            // Dgv_Perfiles
            // 
            this.Dgv_Perfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Perfiles.Location = new System.Drawing.Point(359, 56);
            this.Dgv_Perfiles.Name = "Dgv_Perfiles";
            this.Dgv_Perfiles.Size = new System.Drawing.Size(408, 204);
            this.Dgv_Perfiles.TabIndex = 5;
            this.Dgv_Perfiles.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Perfiles_CellContentDoubleClick);
            // 
            // Btn_Update
            // 
            this.Btn_Update.Location = new System.Drawing.Point(320, 298);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(75, 23);
            this.Btn_Update.TabIndex = 6;
            this.Btn_Update.Text = "Actualizar";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Location = new System.Drawing.Point(424, 297);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.Btn_Delete.TabIndex = 7;
            this.Btn_Delete.Text = "Eliminar";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // MantPerfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 363);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.Dgv_Perfiles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_DescripPerfil);
            this.Controls.Add(this.Txt_IdPerfil);
            this.Controls.Add(this.Guardar);
            this.Name = "MantPerfiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MantPerfiles";
            this.Load += new System.EventHandler(this.MantPerfiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Perfiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Guardar;
        public System.Windows.Forms.TextBox Txt_IdPerfil;
        public System.Windows.Forms.TextBox Txt_DescripPerfil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Dgv_Perfiles;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Button Btn_Delete;
    }
}