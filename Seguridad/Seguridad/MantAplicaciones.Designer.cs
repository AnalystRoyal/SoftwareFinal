namespace Seguridad
{
    partial class MantAplicaciones
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
            this.button1 = new System.Windows.Forms.Button();
            this.txt_IdApp = new System.Windows.Forms.TextBox();
            this.txt_DescripApp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Dgv_App = new System.Windows.Forms.DataGridView();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_App)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_IdApp
            // 
            this.txt_IdApp.Location = new System.Drawing.Point(128, 89);
            this.txt_IdApp.Name = "txt_IdApp";
            this.txt_IdApp.Size = new System.Drawing.Size(188, 20);
            this.txt_IdApp.TabIndex = 1;
            // 
            // txt_DescripApp
            // 
            this.txt_DescripApp.Location = new System.Drawing.Point(128, 180);
            this.txt_DescripApp.Name = "txt_DescripApp";
            this.txt_DescripApp.Size = new System.Drawing.Size(188, 20);
            this.txt_DescripApp.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 92);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID Aplicación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descripción";
            // 
            // Dgv_App
            // 
            this.Dgv_App.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_App.Location = new System.Drawing.Point(354, 53);
            this.Dgv_App.Name = "Dgv_App";
            this.Dgv_App.Size = new System.Drawing.Size(421, 202);
            this.Dgv_App.TabIndex = 5;
            this.Dgv_App.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_App_CellContentDoubleClick);
            // 
            // Btn_Update
            // 
            this.Btn_Update.Location = new System.Drawing.Point(314, 315);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(75, 23);
            this.Btn_Update.TabIndex = 6;
            this.Btn_Update.Text = "Actualizar";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Location = new System.Drawing.Point(449, 314);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.Btn_Delete.TabIndex = 7;
            this.Btn_Delete.Text = "Eliminar";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // MantAplicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 403);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.Dgv_App);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_DescripApp);
            this.Controls.Add(this.txt_IdApp);
            this.Controls.Add(this.button1);
            this.Name = "MantAplicaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MantAplicaciones";
            this.Load += new System.EventHandler(this.MantAplicaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_App)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_IdApp;
        private System.Windows.Forms.TextBox txt_DescripApp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Dgv_App;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Button Btn_Delete;
    }
}