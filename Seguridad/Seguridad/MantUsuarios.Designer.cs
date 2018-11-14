namespace Seguridad
{
    partial class MantUsuarios
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
            this.Txt_nombre = new System.Windows.Forms.TextBox();
            this.Txt_apellido = new System.Windows.Forms.TextBox();
            this.Txt_telefono = new System.Windows.Forms.TextBox();
            this.Txt_correo = new System.Windows.Forms.TextBox();
            this.Txt_usuario = new System.Windows.Forms.TextBox();
            this.Txt_pswd1 = new System.Windows.Forms.TextBox();
            this.Txt_pswd2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Btn_ingresar = new System.Windows.Forms.Button();
            this.Dgv_Usuarios = new System.Windows.Forms.DataGridView();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.Location = new System.Drawing.Point(77, 98);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Size = new System.Drawing.Size(173, 20);
            this.Txt_nombre.TabIndex = 0;
            // 
            // Txt_apellido
            // 
            this.Txt_apellido.Location = new System.Drawing.Point(77, 138);
            this.Txt_apellido.Name = "Txt_apellido";
            this.Txt_apellido.Size = new System.Drawing.Size(173, 20);
            this.Txt_apellido.TabIndex = 1;
            // 
            // Txt_telefono
            // 
            this.Txt_telefono.Location = new System.Drawing.Point(77, 187);
            this.Txt_telefono.Name = "Txt_telefono";
            this.Txt_telefono.Size = new System.Drawing.Size(173, 20);
            this.Txt_telefono.TabIndex = 2;
            // 
            // Txt_correo
            // 
            this.Txt_correo.Location = new System.Drawing.Point(77, 235);
            this.Txt_correo.Name = "Txt_correo";
            this.Txt_correo.Size = new System.Drawing.Size(173, 20);
            this.Txt_correo.TabIndex = 3;
            // 
            // Txt_usuario
            // 
            this.Txt_usuario.Location = new System.Drawing.Point(77, 288);
            this.Txt_usuario.Name = "Txt_usuario";
            this.Txt_usuario.Size = new System.Drawing.Size(173, 20);
            this.Txt_usuario.TabIndex = 4;
            // 
            // Txt_pswd1
            // 
            this.Txt_pswd1.Location = new System.Drawing.Point(150, 324);
            this.Txt_pswd1.Name = "Txt_pswd1";
            this.Txt_pswd1.PasswordChar = '*';
            this.Txt_pswd1.Size = new System.Drawing.Size(100, 20);
            this.Txt_pswd1.TabIndex = 5;
            // 
            // Txt_pswd2
            // 
            this.Txt_pswd2.Location = new System.Drawing.Point(150, 374);
            this.Txt_pswd2.Name = "Txt_pswd2";
            this.Txt_pswd2.PasswordChar = '*';
            this.Txt_pswd2.Size = new System.Drawing.Size(100, 20);
            this.Txt_pswd2.TabIndex = 6;
            this.Txt_pswd2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_pswd2_KeyUp);
            this.Txt_pswd2.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_pswd2_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Correo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Usuario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Contraseña";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Confirmación de Contraseña";
            // 
            // Btn_ingresar
            // 
            this.Btn_ingresar.Location = new System.Drawing.Point(290, 420);
            this.Btn_ingresar.Name = "Btn_ingresar";
            this.Btn_ingresar.Size = new System.Drawing.Size(75, 23);
            this.Btn_ingresar.TabIndex = 14;
            this.Btn_ingresar.Text = "Ingresar";
            this.Btn_ingresar.UseVisualStyleBackColor = true;
            this.Btn_ingresar.Click += new System.EventHandler(this.Btn_ingresar_Click);
            // 
            // Dgv_Usuarios
            // 
            this.Dgv_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Usuarios.Location = new System.Drawing.Point(344, 90);
            this.Dgv_Usuarios.Name = "Dgv_Usuarios";
            this.Dgv_Usuarios.Size = new System.Drawing.Size(693, 300);
            this.Dgv_Usuarios.TabIndex = 15;
            this.Dgv_Usuarios.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Usuarios_CellContentDoubleClick);
            // 
            // Btn_Update
            // 
            this.Btn_Update.Location = new System.Drawing.Point(397, 420);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(75, 23);
            this.Btn_Update.TabIndex = 16;
            this.Btn_Update.Text = "Actualizar";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Location = new System.Drawing.Point(504, 419);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.Btn_Delete.TabIndex = 17;
            this.Btn_Delete.Text = "Eliminar";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // txt_ID
            // 
            this.txt_ID.Enabled = false;
            this.txt_ID.Location = new System.Drawing.Point(77, 63);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(100, 20);
            this.txt_ID.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "ID";
            // 
            // MantUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 470);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.Dgv_Usuarios);
            this.Controls.Add(this.Btn_ingresar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_pswd2);
            this.Controls.Add(this.Txt_pswd1);
            this.Controls.Add(this.Txt_usuario);
            this.Controls.Add(this.Txt_correo);
            this.Controls.Add(this.Txt_telefono);
            this.Controls.Add(this.Txt_apellido);
            this.Controls.Add(this.Txt_nombre);
            this.Name = "MantUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MantUsuarios";
            this.Load += new System.EventHandler(this.MantUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Usuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_nombre;
        private System.Windows.Forms.TextBox Txt_apellido;
        private System.Windows.Forms.TextBox Txt_telefono;
        private System.Windows.Forms.TextBox Txt_correo;
        private System.Windows.Forms.TextBox Txt_usuario;
        private System.Windows.Forms.TextBox Txt_pswd1;
        private System.Windows.Forms.TextBox Txt_pswd2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Btn_ingresar;
        private System.Windows.Forms.DataGridView Dgv_Usuarios;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label8;
    }
}