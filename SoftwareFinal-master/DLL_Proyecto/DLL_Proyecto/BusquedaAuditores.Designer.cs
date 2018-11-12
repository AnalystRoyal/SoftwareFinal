namespace DLL_Proyecto
{
    partial class BusquedaAuditores
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
            this.Txt_IdAuditor = new System.Windows.Forms.TextBox();
            this.Dgv_Auditores = new System.Windows.Forms.DataGridView();
            this.Btn_Seleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Auditores)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_IdAuditor
            // 
            this.Txt_IdAuditor.Location = new System.Drawing.Point(282, 17);
            this.Txt_IdAuditor.Name = "Txt_IdAuditor";
            this.Txt_IdAuditor.Size = new System.Drawing.Size(100, 20);
            this.Txt_IdAuditor.TabIndex = 5;
            // 
            // Dgv_Auditores
            // 
            this.Dgv_Auditores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Auditores.Location = new System.Drawing.Point(12, 31);
            this.Dgv_Auditores.Name = "Dgv_Auditores";
            this.Dgv_Auditores.Size = new System.Drawing.Size(240, 150);
            this.Dgv_Auditores.TabIndex = 3;
            // 
            // Btn_Seleccionar
            // 
            this.Btn_Seleccionar.Image = global::DLL_Proyecto.Properties.Resources.aceptar;
            this.Btn_Seleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Seleccionar.Location = new System.Drawing.Point(282, 60);
            this.Btn_Seleccionar.Name = "Btn_Seleccionar";
            this.Btn_Seleccionar.Size = new System.Drawing.Size(138, 68);
            this.Btn_Seleccionar.TabIndex = 4;
            this.Btn_Seleccionar.Text = "Seleccionar";
            this.Btn_Seleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Seleccionar.UseVisualStyleBackColor = true;
            // 
            // BusquedaAuditores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 261);
            this.Controls.Add(this.Txt_IdAuditor);
            this.Controls.Add(this.Btn_Seleccionar);
            this.Controls.Add(this.Dgv_Auditores);
            this.Name = "BusquedaAuditores";
            this.Text = "BusquedaAuditores";
            this.Load += new System.EventHandler(this.BusquedaAuditores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Auditores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_IdAuditor;
        private System.Windows.Forms.Button Btn_Seleccionar;
        private System.Windows.Forms.DataGridView Dgv_Auditores;
    }
}