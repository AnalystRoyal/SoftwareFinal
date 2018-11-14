namespace Seguridad
{
    partial class AsignacionApp
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
            this.Cmb_Perfil = new System.Windows.Forms.ComboBox();
            this.Dgv_App = new System.Windows.Forms.DataGridView();
            this.Dgv_Asignacion = new System.Windows.Forms.DataGridView();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_SelUno = new System.Windows.Forms.Button();
            this.Btn_SelTodos = new System.Windows.Forms.Button();
            this.Btn_RegUno = new System.Windows.Forms.Button();
            this.Btn_RegTodos = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_App)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Asignacion)).BeginInit();
            this.SuspendLayout();
            // 
            // Cmb_Perfil
            // 
            this.Cmb_Perfil.FormattingEnabled = true;
            this.Cmb_Perfil.Location = new System.Drawing.Point(129, 55);
            this.Cmb_Perfil.Name = "Cmb_Perfil";
            this.Cmb_Perfil.Size = new System.Drawing.Size(356, 21);
            this.Cmb_Perfil.TabIndex = 0;
            this.Cmb_Perfil.SelectedIndexChanged += new System.EventHandler(this.Cmb_Perfil_SelectedIndexChanged);
            this.Cmb_Perfil.SelectionChangeCommitted += new System.EventHandler(this.Cmb_Perfil_SelectionChangeCommitted);
            this.Cmb_Perfil.SelectedValueChanged += new System.EventHandler(this.Cmb_Perfil_SelectedValueChanged);
            // 
            // Dgv_App
            // 
            this.Dgv_App.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_App.Location = new System.Drawing.Point(32, 111);
            this.Dgv_App.Name = "Dgv_App";
            this.Dgv_App.Size = new System.Drawing.Size(240, 230);
            this.Dgv_App.TabIndex = 1;
            // 
            // Dgv_Asignacion
            // 
            this.Dgv_Asignacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Asignacion.Location = new System.Drawing.Point(425, 111);
            this.Dgv_Asignacion.Name = "Dgv_Asignacion";
            this.Dgv_Asignacion.Size = new System.Drawing.Size(410, 230);
            this.Dgv_Asignacion.TabIndex = 2;
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Location = new System.Drawing.Point(254, 391);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Guardar.TabIndex = 3;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Btn_SelUno
            // 
            this.Btn_SelUno.Location = new System.Drawing.Point(320, 136);
            this.Btn_SelUno.Name = "Btn_SelUno";
            this.Btn_SelUno.Size = new System.Drawing.Size(59, 34);
            this.Btn_SelUno.TabIndex = 4;
            this.Btn_SelUno.Text = ">";
            this.Btn_SelUno.UseVisualStyleBackColor = true;
            this.Btn_SelUno.Click += new System.EventHandler(this.Btn_SelUno_Click);
            // 
            // Btn_SelTodos
            // 
            this.Btn_SelTodos.Location = new System.Drawing.Point(320, 192);
            this.Btn_SelTodos.Name = "Btn_SelTodos";
            this.Btn_SelTodos.Size = new System.Drawing.Size(59, 33);
            this.Btn_SelTodos.TabIndex = 5;
            this.Btn_SelTodos.Text = ">>";
            this.Btn_SelTodos.UseVisualStyleBackColor = true;
            this.Btn_SelTodos.Click += new System.EventHandler(this.Btn_SelTodos_Click);
            // 
            // Btn_RegUno
            // 
            this.Btn_RegUno.Location = new System.Drawing.Point(320, 242);
            this.Btn_RegUno.Name = "Btn_RegUno";
            this.Btn_RegUno.Size = new System.Drawing.Size(59, 35);
            this.Btn_RegUno.TabIndex = 6;
            this.Btn_RegUno.Text = "<";
            this.Btn_RegUno.UseVisualStyleBackColor = true;
            this.Btn_RegUno.Click += new System.EventHandler(this.Btn_RegUno_Click);
            // 
            // Btn_RegTodos
            // 
            this.Btn_RegTodos.Location = new System.Drawing.Point(320, 293);
            this.Btn_RegTodos.Name = "Btn_RegTodos";
            this.Btn_RegTodos.Size = new System.Drawing.Size(59, 35);
            this.Btn_RegTodos.TabIndex = 7;
            this.Btn_RegTodos.Text = "<<";
            this.Btn_RegTodos.UseVisualStyleBackColor = true;
            this.Btn_RegTodos.Click += new System.EventHandler(this.Btn_RegTodos_Click);
            // 
            // Btn_Update
            // 
            this.Btn_Update.Location = new System.Drawing.Point(367, 391);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(75, 23);
            this.Btn_Update.TabIndex = 8;
            this.Btn_Update.Text = "Actualizar";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Location = new System.Drawing.Point(484, 391);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.Btn_Delete.TabIndex = 9;
            this.Btn_Delete.Text = "Eliminar";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // AsignacionApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 455);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.Btn_RegTodos);
            this.Controls.Add(this.Btn_RegUno);
            this.Controls.Add(this.Btn_SelTodos);
            this.Controls.Add(this.Btn_SelUno);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Dgv_Asignacion);
            this.Controls.Add(this.Dgv_App);
            this.Controls.Add(this.Cmb_Perfil);
            this.Name = "AsignacionApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AsignacionApp";
            this.Load += new System.EventHandler(this.AsignacionApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_App)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Asignacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Cmb_Perfil;
        private System.Windows.Forms.DataGridView Dgv_App;
        private System.Windows.Forms.DataGridView Dgv_Asignacion;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_SelUno;
        private System.Windows.Forms.Button Btn_SelTodos;
        private System.Windows.Forms.Button Btn_RegUno;
        private System.Windows.Forms.Button Btn_RegTodos;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Button Btn_Delete;
    }
}