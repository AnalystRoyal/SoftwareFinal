namespace DLL_Proyecto
{
    partial class BusquedaAreas
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
            this.Dgv_Areas_Empresas = new System.Windows.Forms.DataGridView();
            this.Txt_IdAreas = new System.Windows.Forms.TextBox();
            this.Btn_Seleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Areas_Empresas)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Areas_Empresas
            // 
            this.Dgv_Areas_Empresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Areas_Empresas.Location = new System.Drawing.Point(12, 36);
            this.Dgv_Areas_Empresas.Name = "Dgv_Areas_Empresas";
            this.Dgv_Areas_Empresas.Size = new System.Drawing.Size(240, 150);
            this.Dgv_Areas_Empresas.TabIndex = 0;
            // 
            // Txt_IdAreas
            // 
            this.Txt_IdAreas.Location = new System.Drawing.Point(282, 22);
            this.Txt_IdAreas.Name = "Txt_IdAreas";
            this.Txt_IdAreas.Size = new System.Drawing.Size(100, 20);
            this.Txt_IdAreas.TabIndex = 2;
            // 
            // Btn_Seleccionar
            // 
            this.Btn_Seleccionar.Image = global::DLL_Proyecto.Properties.Resources.aceptar;
            this.Btn_Seleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Seleccionar.Location = new System.Drawing.Point(282, 65);
            this.Btn_Seleccionar.Name = "Btn_Seleccionar";
            this.Btn_Seleccionar.Size = new System.Drawing.Size(138, 68);
            this.Btn_Seleccionar.TabIndex = 1;
            this.Btn_Seleccionar.Text = "Seleccionar";
            this.Btn_Seleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Seleccionar.UseVisualStyleBackColor = true;
            this.Btn_Seleccionar.Click += new System.EventHandler(this.Btn_Seleccionar_Click);
            // 
            // BusquedaAreas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 214);
            this.Controls.Add(this.Txt_IdAreas);
            this.Controls.Add(this.Btn_Seleccionar);
            this.Controls.Add(this.Dgv_Areas_Empresas);
            this.Name = "BusquedaAreas";
            this.Text = "Busqueda Areas";
            this.Load += new System.EventHandler(this.BusquedaAreas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Areas_Empresas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_Areas_Empresas;
        private System.Windows.Forms.Button Btn_Seleccionar;
        private System.Windows.Forms.TextBox Txt_IdAreas;
    }
}