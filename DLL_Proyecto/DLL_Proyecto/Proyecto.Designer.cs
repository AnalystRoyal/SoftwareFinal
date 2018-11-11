namespace DLL_Proyecto
{
    partial class Proyecto
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
            this.Cmb_Tipo_Proyecto = new System.Windows.Forms.ComboBox();
            this.Cmb_Empresa = new System.Windows.Forms.ComboBox();
            this.Dtp_Fecha_Inicio = new System.Windows.Forms.DateTimePicker();
            this.Dtp_Fecha_Fin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Dtg_Ingreso_Auditores = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Dtg_Recursos_TI = new System.Windows.Forms.DataGridView();
            this.Dtg_Informes = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.Btn_Agregar_Tipo_Proyecto = new System.Windows.Forms.Button();
            this.Btn_Agregar_Empresa = new System.Windows.Forms.Button();
            this.Btn_Agregar_Informes = new System.Windows.Forms.Button();
            this.Btn_Agregar_Recursos_TI = new System.Windows.Forms.Button();
            this.Btn_Agregar_Auditores = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_Total_Dias_Proyecto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_Ingreso_Auditores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_Recursos_TI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_Informes)).BeginInit();
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
            this.navegador1.sNombreBD = null;
            this.navegador1.sNombreTabla = "proyecto";
            this.navegador1.sPass = null;
            this.navegador1.sServidor = "LOCALHOST";
            this.navegador1.sUsuario = "root";
            this.navegador1.TabIndex = 0;
            // 
            // Cmb_Tipo_Proyecto
            // 
            this.Cmb_Tipo_Proyecto.FormattingEnabled = true;
            this.Cmb_Tipo_Proyecto.Location = new System.Drawing.Point(162, 128);
            this.Cmb_Tipo_Proyecto.Name = "Cmb_Tipo_Proyecto";
            this.Cmb_Tipo_Proyecto.Size = new System.Drawing.Size(121, 21);
            this.Cmb_Tipo_Proyecto.TabIndex = 1;
            // 
            // Cmb_Empresa
            // 
            this.Cmb_Empresa.FormattingEnabled = true;
            this.Cmb_Empresa.Location = new System.Drawing.Point(541, 125);
            this.Cmb_Empresa.Name = "Cmb_Empresa";
            this.Cmb_Empresa.Size = new System.Drawing.Size(121, 21);
            this.Cmb_Empresa.TabIndex = 2;
            // 
            // Dtp_Fecha_Inicio
            // 
            this.Dtp_Fecha_Inicio.Location = new System.Drawing.Point(161, 93);
            this.Dtp_Fecha_Inicio.Name = "Dtp_Fecha_Inicio";
            this.Dtp_Fecha_Inicio.Size = new System.Drawing.Size(200, 20);
            this.Dtp_Fecha_Inicio.TabIndex = 3;
            // 
            // Dtp_Fecha_Fin
            // 
            this.Dtp_Fecha_Fin.Location = new System.Drawing.Point(513, 94);
            this.Dtp_Fecha_Fin.Name = "Dtp_Fecha_Fin";
            this.Dtp_Fecha_Fin.Size = new System.Drawing.Size(200, 20);
            this.Dtp_Fecha_Fin.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seleccione Tipo de Proyecto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Seleccione La Empersa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Seleccione Fecha de Inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Seleccione Fecha a Fin";
            // 
            // Dtg_Ingreso_Auditores
            // 
            this.Dtg_Ingreso_Auditores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtg_Ingreso_Auditores.Location = new System.Drawing.Point(16, 240);
            this.Dtg_Ingreso_Auditores.Name = "Dtg_Ingreso_Auditores";
            this.Dtg_Ingreso_Auditores.Size = new System.Drawing.Size(240, 150);
            this.Dtg_Ingreso_Auditores.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Auditores Del Proyecto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(353, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Recursos De TI";
            // 
            // Dtg_Recursos_TI
            // 
            this.Dtg_Recursos_TI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtg_Recursos_TI.Location = new System.Drawing.Point(262, 240);
            this.Dtg_Recursos_TI.Name = "Dtg_Recursos_TI";
            this.Dtg_Recursos_TI.Size = new System.Drawing.Size(240, 150);
            this.Dtg_Recursos_TI.TabIndex = 12;
            // 
            // Dtg_Informes
            // 
            this.Dtg_Informes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtg_Informes.Location = new System.Drawing.Point(508, 240);
            this.Dtg_Informes.Name = "Dtg_Informes";
            this.Dtg_Informes.Size = new System.Drawing.Size(240, 150);
            this.Dtg_Informes.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(605, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Informes";
            // 
            // Btn_Agregar_Tipo_Proyecto
            // 
            this.Btn_Agregar_Tipo_Proyecto.Image = global::DLL_Proyecto.Properties.Resources.nuevo;
            this.Btn_Agregar_Tipo_Proyecto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Agregar_Tipo_Proyecto.Location = new System.Drawing.Point(289, 119);
            this.Btn_Agregar_Tipo_Proyecto.Name = "Btn_Agregar_Tipo_Proyecto";
            this.Btn_Agregar_Tipo_Proyecto.Size = new System.Drawing.Size(121, 65);
            this.Btn_Agregar_Tipo_Proyecto.TabIndex = 20;
            this.Btn_Agregar_Tipo_Proyecto.Text = "Nuevo";
            this.Btn_Agregar_Tipo_Proyecto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Agregar_Tipo_Proyecto.UseVisualStyleBackColor = true;
            // 
            // Btn_Agregar_Empresa
            // 
            this.Btn_Agregar_Empresa.Image = global::DLL_Proyecto.Properties.Resources.nuevo;
            this.Btn_Agregar_Empresa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Agregar_Empresa.Location = new System.Drawing.Point(668, 120);
            this.Btn_Agregar_Empresa.Name = "Btn_Agregar_Empresa";
            this.Btn_Agregar_Empresa.Size = new System.Drawing.Size(121, 65);
            this.Btn_Agregar_Empresa.TabIndex = 19;
            this.Btn_Agregar_Empresa.Text = "Nuevo";
            this.Btn_Agregar_Empresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Agregar_Empresa.UseVisualStyleBackColor = true;
            // 
            // Btn_Agregar_Informes
            // 
            this.Btn_Agregar_Informes.Image = global::DLL_Proyecto.Properties.Resources.agregar;
            this.Btn_Agregar_Informes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Agregar_Informes.Location = new System.Drawing.Point(567, 396);
            this.Btn_Agregar_Informes.Name = "Btn_Agregar_Informes";
            this.Btn_Agregar_Informes.Size = new System.Drawing.Size(121, 65);
            this.Btn_Agregar_Informes.TabIndex = 18;
            this.Btn_Agregar_Informes.Text = "Agregar";
            this.Btn_Agregar_Informes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Agregar_Informes.UseVisualStyleBackColor = true;
            // 
            // Btn_Agregar_Recursos_TI
            // 
            this.Btn_Agregar_Recursos_TI.Image = global::DLL_Proyecto.Properties.Resources.agregar;
            this.Btn_Agregar_Recursos_TI.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Agregar_Recursos_TI.Location = new System.Drawing.Point(314, 396);
            this.Btn_Agregar_Recursos_TI.Name = "Btn_Agregar_Recursos_TI";
            this.Btn_Agregar_Recursos_TI.Size = new System.Drawing.Size(121, 65);
            this.Btn_Agregar_Recursos_TI.TabIndex = 17;
            this.Btn_Agregar_Recursos_TI.Text = "Agregar";
            this.Btn_Agregar_Recursos_TI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Agregar_Recursos_TI.UseVisualStyleBackColor = true;
            // 
            // Btn_Agregar_Auditores
            // 
            this.Btn_Agregar_Auditores.Image = global::DLL_Proyecto.Properties.Resources.agregar;
            this.Btn_Agregar_Auditores.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Agregar_Auditores.Location = new System.Drawing.Point(81, 396);
            this.Btn_Agregar_Auditores.Name = "Btn_Agregar_Auditores";
            this.Btn_Agregar_Auditores.Size = new System.Drawing.Size(121, 65);
            this.Btn_Agregar_Auditores.TabIndex = 16;
            this.Btn_Agregar_Auditores.Text = "Agregar";
            this.Btn_Agregar_Auditores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Agregar_Auditores.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Total De Dias Del Proyecto";
            // 
            // Txt_Total_Dias_Proyecto
            // 
            this.Txt_Total_Dias_Proyecto.Location = new System.Drawing.Point(151, 168);
            this.Txt_Total_Dias_Proyecto.Name = "Txt_Total_Dias_Proyecto";
            this.Txt_Total_Dias_Proyecto.Size = new System.Drawing.Size(100, 20);
            this.Txt_Total_Dias_Proyecto.TabIndex = 22;
            // 
            // Proyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 496);
            this.Controls.Add(this.Txt_Total_Dias_Proyecto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Btn_Agregar_Tipo_Proyecto);
            this.Controls.Add(this.Btn_Agregar_Empresa);
            this.Controls.Add(this.Btn_Agregar_Informes);
            this.Controls.Add(this.Btn_Agregar_Recursos_TI);
            this.Controls.Add(this.Btn_Agregar_Auditores);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Dtg_Informes);
            this.Controls.Add(this.Dtg_Recursos_TI);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Dtg_Ingreso_Auditores);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dtp_Fecha_Fin);
            this.Controls.Add(this.Dtp_Fecha_Inicio);
            this.Controls.Add(this.Cmb_Empresa);
            this.Controls.Add(this.Cmb_Tipo_Proyecto);
            this.Controls.Add(this.navegador1);
            this.Name = "Proyecto";
            this.Text = "Proyecto";
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_Ingreso_Auditores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_Recursos_TI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_Informes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.ComboBox Cmb_Tipo_Proyecto;
        private System.Windows.Forms.ComboBox Cmb_Empresa;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_Inicio;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_Fin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView Dtg_Ingreso_Auditores;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView Dtg_Recursos_TI;
        private System.Windows.Forms.DataGridView Dtg_Informes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Btn_Agregar_Auditores;
        private System.Windows.Forms.Button Btn_Agregar_Recursos_TI;
        private System.Windows.Forms.Button Btn_Agregar_Informes;
        private System.Windows.Forms.Button Btn_Agregar_Empresa;
        private System.Windows.Forms.Button Btn_Agregar_Tipo_Proyecto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_Total_Dias_Proyecto;
    }
}