﻿namespace TipoProyecto
{
    partial class Metodologias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Metodologias));
            this.Lbl_Descripcion = new System.Windows.Forms.Label();
            this.Lbl_Nombre = new System.Windows.Forms.Label();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.navegador1 = new Navegador.Navegador();
            this.Txt_Descripcion = new System.Windows.Forms.TextBox();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Actualizar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Insertar = new System.Windows.Forms.Button();
            this.Txt_Codigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Descripcion
            // 
            this.Lbl_Descripcion.AutoSize = true;
            this.Lbl_Descripcion.Location = new System.Drawing.Point(158, 241);
            this.Lbl_Descripcion.Name = "Lbl_Descripcion";
            this.Lbl_Descripcion.Size = new System.Drawing.Size(63, 13);
            this.Lbl_Descripcion.TabIndex = 3;
            this.Lbl_Descripcion.Text = "Descripcion";
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.Location = new System.Drawing.Point(423, 153);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(44, 13);
            this.Lbl_Nombre.TabIndex = 2;
            this.Lbl_Nombre.Text = "Nombre";
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(502, 153);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(100, 20);
            this.Txt_Nombre.TabIndex = 4;
            this.Txt_Nombre.Tag = "Nombre";
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
            this.navegador1.sNombreTabla = "metodologias";
            this.navegador1.sPass = null;
            this.navegador1.sServidor = "LOCALHOST";
            this.navegador1.sUsuario = "root";
            this.navegador1.TabIndex = 6;
            this.navegador1.NavInsertar += new System.EventHandler(this.navegador1_NavInsertar);
            this.navegador1.NavActualizar += new System.EventHandler(this.navegador1_NavActualizar);
            this.navegador1.NavEliminar += new System.EventHandler(this.navegador1_NavEliminar);
            this.navegador1.NavGuardar += new System.EventHandler(this.navegador1_NavGuardar);
            this.navegador1.NavInicio += new System.EventHandler(this.navegador1_NavInicio);
            this.navegador1.NavAnterior += new System.EventHandler(this.navegador1_NavAnterior);
            this.navegador1.NavSiguiente += new System.EventHandler(this.navegador1_NavSiguiente);
            this.navegador1.NavFin += new System.EventHandler(this.navegador1_NavFin);
            this.navegador1.NavAyuda += new System.EventHandler(this.navegador1_NavAyuda);
            this.navegador1.NavSalir += new System.EventHandler(this.navegador1_NavSalir);
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.Location = new System.Drawing.Point(237, 238);
            this.Txt_Descripcion.Multiline = true;
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.Size = new System.Drawing.Size(365, 89);
            this.Txt_Descripcion.TabIndex = 7;
            this.Txt_Descripcion.Tag = "Descripcion";
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Guardar.Image")));
            this.Btn_Guardar.Location = new System.Drawing.Point(12, 360);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(68, 55);
            this.Btn_Guardar.TabIndex = 19;
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Btn_Actualizar
            // 
            this.Btn_Actualizar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Actualizar.Image")));
            this.Btn_Actualizar.Location = new System.Drawing.Point(12, 238);
            this.Btn_Actualizar.Name = "Btn_Actualizar";
            this.Btn_Actualizar.Size = new System.Drawing.Size(68, 55);
            this.Btn_Actualizar.TabIndex = 18;
            this.Btn_Actualizar.UseVisualStyleBackColor = true;
            this.Btn_Actualizar.Click += new System.EventHandler(this.Btn_Actualizar_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Eliminar.Image")));
            this.Btn_Eliminar.Location = new System.Drawing.Point(12, 177);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(68, 55);
            this.Btn_Eliminar.TabIndex = 17;
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Btn_Insertar
            // 
            this.Btn_Insertar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Insertar.Image")));
            this.Btn_Insertar.Location = new System.Drawing.Point(12, 116);
            this.Btn_Insertar.Name = "Btn_Insertar";
            this.Btn_Insertar.Size = new System.Drawing.Size(68, 55);
            this.Btn_Insertar.TabIndex = 16;
            this.Btn_Insertar.UseVisualStyleBackColor = true;
            this.Btn_Insertar.Click += new System.EventHandler(this.Btn_Insertar_Click);
            // 
            // Txt_Codigo
            // 
            this.Txt_Codigo.Enabled = false;
            this.Txt_Codigo.Location = new System.Drawing.Point(237, 153);
            this.Txt_Codigo.Name = "Txt_Codigo";
            this.Txt_Codigo.Size = new System.Drawing.Size(100, 20);
            this.Txt_Codigo.TabIndex = 21;
            this.Txt_Codigo.Tag = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Codigo";
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Buscar.Image")));
            this.Btn_Buscar.Location = new System.Drawing.Point(12, 299);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(68, 55);
            this.Btn_Buscar.TabIndex = 22;
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Metodologias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 440);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Txt_Codigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Btn_Actualizar);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Insertar);
            this.Controls.Add(this.Txt_Descripcion);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.Lbl_Descripcion);
            this.Controls.Add(this.Lbl_Nombre);
            this.Name = "Metodologias";
            this.Text = "Metodologias";
            this.Load += new System.EventHandler(this.Metodologias_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Descripcion;
        private System.Windows.Forms.Label Lbl_Nombre;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private Navegador.Navegador navegador1;
        private System.Windows.Forms.TextBox Txt_Descripcion;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Actualizar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Insertar;
        private System.Windows.Forms.TextBox Txt_Codigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Buscar;
    }
}