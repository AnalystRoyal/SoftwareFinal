using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Seguridad
{
    public partial class AsignacionApp : Form
    {
        public AsignacionApp()
        {
            InitializeComponent();
        }

        private void AsignacionApp_Load(object sender, EventArgs e)
        {
            cargarCmbPerfil();
            cargarApp();
            Dgv_Asignacion.Columns.Add("ID", "ID");
            Dgv_Asignacion.Columns.Add("descrip", "descrip");
            
        }

        public void cargarCmbPerfil()
        {
            Cmb_Perfil.DataSource = Funciones.MostarPerfiles();
            Cmb_Perfil.DisplayMember = "descrip_Perfil";
            Cmb_Perfil.ValueMember = "id_Perfil";

        }

        public void cargarApp()
        {
            Dgv_App.DataSource = Funciones.MostarApp();
        }

        private void Btn_SelUno_Click(object sender, EventArgs e)
        {
            Dgv_Asignacion.Rows.Add(
                Dgv_App.CurrentRow.Cells[0].Value,
                Dgv_App.CurrentRow.Cells[1].Value
                );
            DataGridViewCheckBoxColumn create = new DataGridViewCheckBoxColumn();
            create.HeaderText = "Create";
            create.Width = 60;
            Dgv_Asignacion.Columns.Add(create);
            DataGridViewCheckBoxColumn update = new DataGridViewCheckBoxColumn();
            update.Width = 60;
            update.HeaderText = "Update";
            Dgv_Asignacion.Columns.Add(update);
            DataGridViewCheckBoxColumn delete = new DataGridViewCheckBoxColumn();
            delete.Width = 60;
            delete.HeaderText = "Delete";
            Dgv_Asignacion.Columns.Add(delete);
        }

        private void Btn_SelTodos_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in Dgv_App.Rows)
            {

                Dgv_Asignacion.Rows.Add(item.Cells[0].Value, item.Cells[1].Value);
               
            }
        }

        private void Btn_RegUno_Click(object sender, EventArgs e)
        {
            Dgv_Asignacion.Rows.RemoveAt(Dgv_Asignacion.CurrentRow.Index);
        }

        private void Btn_RegTodos_Click(object sender, EventArgs e)
        {
            Dgv_Asignacion.Rows.Clear();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in Dgv_Asignacion.Rows)
            {
                
            }
        }
    }
}
