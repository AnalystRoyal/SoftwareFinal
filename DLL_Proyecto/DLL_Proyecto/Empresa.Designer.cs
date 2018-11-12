namespace DLL_Proyecto
{
    partial class Empresa
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
            this.navegador1 = new Navegador.Navegador();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Txt_Dirrecion = new System.Windows.Forms.TextBox();
            this.Txt_Telefono = new System.Windows.Forms.TextBox();
            this.Txt_Contacto = new System.Windows.Forms.TextBox();
            this.Dgv_Areas = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.Cancelar = new System.Windows.Forms.PictureBox();
            this.guardar = new System.Windows.Forms.PictureBox();
            this.Btn_Agregar_Areas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Areas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guardar)).BeginInit();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.Gainsboro;
            this.navegador1.Location = new System.Drawing.Point(12, 12);
            this.navegador1.Name = "navegador1";
            this.navegador1.sAppNumero = null;
            this.navegador1.Size = new System.Drawing.Size(675, 67);
            this.navegador1.sNom_Usuario = null;
            this.navegador1.sNombreBD = "auditoria";
            this.navegador1.sNombreTabla = "empresa";
            this.navegador1.sPass = null;
            this.navegador1.sServidor = "LOCALHOST";
            this.navegador1.sUsuario = "root";
            this.navegador1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre De La Empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Direccion De La Empresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telefono De La Empresa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Contacto De La Empresa";
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(153, 106);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(100, 20);
            this.Txt_Nombre.TabIndex = 5;
            this.Txt_Nombre.Tag = "Nombre";
            // 
            // Txt_Dirrecion
            // 
            this.Txt_Dirrecion.Location = new System.Drawing.Point(153, 136);
            this.Txt_Dirrecion.Name = "Txt_Dirrecion";
            this.Txt_Dirrecion.Size = new System.Drawing.Size(100, 20);
            this.Txt_Dirrecion.TabIndex = 6;
            this.Txt_Dirrecion.Tag = "Direccion";
            // 
            // Txt_Telefono
            // 
            this.Txt_Telefono.Location = new System.Drawing.Point(153, 166);
            this.Txt_Telefono.Name = "Txt_Telefono";
            this.Txt_Telefono.Size = new System.Drawing.Size(100, 20);
            this.Txt_Telefono.TabIndex = 7;
            this.Txt_Telefono.Tag = "Telefono";
            // 
            // Txt_Contacto
            // 
            this.Txt_Contacto.Location = new System.Drawing.Point(153, 196);
            this.Txt_Contacto.Name = "Txt_Contacto";
            this.Txt_Contacto.Size = new System.Drawing.Size(100, 20);
            this.Txt_Contacto.TabIndex = 8;
            this.Txt_Contacto.Tag = "Contacto";
            // 
            // Dgv_Areas
            // 
            this.Dgv_Areas.AllowUserToAddRows = false;
            this.Dgv_Areas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Areas.Location = new System.Drawing.Point(93, 235);
            this.Dgv_Areas.Name = "Dgv_Areas";
            this.Dgv_Areas.Size = new System.Drawing.Size(240, 150);
            this.Dgv_Areas.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Agregar Areas";
            // 
            // Cancelar
            // 
            this.Cancelar.Image = global::DLL_Proyecto.Properties.Resources.cancelar;
            this.Cancelar.Location = new System.Drawing.Point(226, 12);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(46, 46);
            this.Cancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cancelar.TabIndex = 19;
            this.Cancelar.TabStop = false;
            // 
            // guardar
            // 
            this.guardar.BackColor = System.Drawing.Color.Transparent;
            this.guardar.Image = global::DLL_Proyecto.Properties.Resources.guardar;
            this.guardar.Location = new System.Drawing.Point(174, 12);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(46, 46);
            this.guardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guardar.TabIndex = 18;
            this.guardar.TabStop = false;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // Btn_Agregar_Areas
            // 
            this.Btn_Agregar_Areas.Image = global::DLL_Proyecto.Properties.Resources.agregar;
            this.Btn_Agregar_Areas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Agregar_Areas.Location = new System.Drawing.Point(348, 235);
            this.Btn_Agregar_Areas.Name = "Btn_Agregar_Areas";
            this.Btn_Agregar_Areas.Size = new System.Drawing.Size(121, 65);
            this.Btn_Agregar_Areas.TabIndex = 17;
            this.Btn_Agregar_Areas.Text = "Agregar";
            this.Btn_Agregar_Areas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Agregar_Areas.UseVisualStyleBackColor = true;
            this.Btn_Agregar_Areas.Click += new System.EventHandler(this.Btn_Agregar_Areas_Click);
            // 
            // Empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 439);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.Btn_Agregar_Areas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Dgv_Areas);
            this.Controls.Add(this.Txt_Contacto);
            this.Controls.Add(this.Txt_Telefono);
            this.Controls.Add(this.Txt_Dirrecion);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.navegador1);
            this.Name = "Empresa";
            this.Text = "Empresa";
            this.Load += new System.EventHandler(this.Empresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Areas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guardar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.TextBox Txt_Dirrecion;
        private System.Windows.Forms.TextBox Txt_Telefono;
        private System.Windows.Forms.TextBox Txt_Contacto;
        private System.Windows.Forms.DataGridView Dgv_Areas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_Agregar_Areas;
        private System.Windows.Forms.PictureBox guardar;
        private System.Windows.Forms.PictureBox Cancelar;
    }
}