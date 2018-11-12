namespace Seguridad
{
    partial class AsignacionPerfil
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
            this.Cmb_Usuario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Dgv_Perfil = new System.Windows.Forms.DataGridView();
            this.Btn_RegTodos = new System.Windows.Forms.Button();
            this.Btn_RegUno = new System.Windows.Forms.Button();
            this.Btn_SelTodos = new System.Windows.Forms.Button();
            this.Btn_SelUno = new System.Windows.Forms.Button();
            this.Dgv_Asignacion = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Perfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Asignacion)).BeginInit();
            this.SuspendLayout();
            // 
            // Cmb_Usuario
            // 
            this.Cmb_Usuario.FormattingEnabled = true;
            this.Cmb_Usuario.Location = new System.Drawing.Point(201, 58);
            this.Cmb_Usuario.Name = "Cmb_Usuario";
            this.Cmb_Usuario.Size = new System.Drawing.Size(456, 21);
            this.Cmb_Usuario.TabIndex = 0;
            this.Cmb_Usuario.SelectedIndexChanged += new System.EventHandler(this.Cmb_Usuario_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // Dgv_Perfil
            // 
            this.Dgv_Perfil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Perfil.Location = new System.Drawing.Point(12, 129);
            this.Dgv_Perfil.Name = "Dgv_Perfil";
            this.Dgv_Perfil.Size = new System.Drawing.Size(240, 297);
            this.Dgv_Perfil.TabIndex = 2;
            // 
            // Btn_RegTodos
            // 
            this.Btn_RegTodos.Location = new System.Drawing.Point(330, 286);
            this.Btn_RegTodos.Name = "Btn_RegTodos";
            this.Btn_RegTodos.Size = new System.Drawing.Size(59, 35);
            this.Btn_RegTodos.TabIndex = 11;
            this.Btn_RegTodos.Text = "<<";
            this.Btn_RegTodos.UseVisualStyleBackColor = true;
            this.Btn_RegTodos.Click += new System.EventHandler(this.Btn_RegTodos_Click);
            // 
            // Btn_RegUno
            // 
            this.Btn_RegUno.Location = new System.Drawing.Point(330, 235);
            this.Btn_RegUno.Name = "Btn_RegUno";
            this.Btn_RegUno.Size = new System.Drawing.Size(59, 35);
            this.Btn_RegUno.TabIndex = 10;
            this.Btn_RegUno.Text = "<";
            this.Btn_RegUno.UseVisualStyleBackColor = true;
            this.Btn_RegUno.Click += new System.EventHandler(this.Btn_RegUno_Click);
            // 
            // Btn_SelTodos
            // 
            this.Btn_SelTodos.Location = new System.Drawing.Point(330, 185);
            this.Btn_SelTodos.Name = "Btn_SelTodos";
            this.Btn_SelTodos.Size = new System.Drawing.Size(59, 33);
            this.Btn_SelTodos.TabIndex = 9;
            this.Btn_SelTodos.Text = ">>";
            this.Btn_SelTodos.UseVisualStyleBackColor = true;
            this.Btn_SelTodos.Click += new System.EventHandler(this.Btn_SelTodos_Click);
            // 
            // Btn_SelUno
            // 
            this.Btn_SelUno.Location = new System.Drawing.Point(330, 129);
            this.Btn_SelUno.Name = "Btn_SelUno";
            this.Btn_SelUno.Size = new System.Drawing.Size(59, 34);
            this.Btn_SelUno.TabIndex = 8;
            this.Btn_SelUno.Text = ">";
            this.Btn_SelUno.UseVisualStyleBackColor = true;
            this.Btn_SelUno.Click += new System.EventHandler(this.Btn_SelUno_Click);
            // 
            // Dgv_Asignacion
            // 
            this.Dgv_Asignacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Asignacion.Location = new System.Drawing.Point(452, 129);
            this.Dgv_Asignacion.Name = "Dgv_Asignacion";
            this.Dgv_Asignacion.Size = new System.Drawing.Size(240, 297);
            this.Dgv_Asignacion.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(330, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AsignacionPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 487);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Dgv_Asignacion);
            this.Controls.Add(this.Btn_RegTodos);
            this.Controls.Add(this.Btn_RegUno);
            this.Controls.Add(this.Btn_SelTodos);
            this.Controls.Add(this.Btn_SelUno);
            this.Controls.Add(this.Dgv_Perfil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cmb_Usuario);
            this.Name = "AsignacionPerfil";
            this.Text = "AsignacionPerfil";
            this.Load += new System.EventHandler(this.AsignacionPerfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Perfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Asignacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Cmb_Usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Dgv_Perfil;
        private System.Windows.Forms.Button Btn_RegTodos;
        private System.Windows.Forms.Button Btn_RegUno;
        private System.Windows.Forms.Button Btn_SelTodos;
        private System.Windows.Forms.Button Btn_SelUno;
        private System.Windows.Forms.DataGridView Dgv_Asignacion;
        private System.Windows.Forms.Button button1;
    }
}