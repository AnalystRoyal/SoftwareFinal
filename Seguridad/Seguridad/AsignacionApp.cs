using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Seguridad.Listas;
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
            Dgv_Asignacion.Columns.Add("ID", "ID");
            Dgv_Asignacion.Columns.Add("descrip", "descrip");
            //Dgv_Asignacion.Columns.Add("create", "Create");
            //Dgv_Asignacion.Columns.Add("update", "Update");
            //Dgv_Asignacion.Columns.Add("delete", "Delete");
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
            cargarCmbPerfil();
            cargarApp();
            Dgv_Asignacion.AllowUserToAddRows = false;
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
            int p = 0;
            int q = Convert.ToInt32(Dgv_App.CurrentRow.Cells[0].Value);
            bool res = false;
            foreach (DataGridViewRow item in Dgv_Asignacion.Rows)
            {
                p = Convert.ToInt32(item.Cells[0].Value);
                if (q == p)
                {
                    res = true;
                }
            }
            if (res == false)
            {
                Dgv_Asignacion.Rows.Add(
                Dgv_App.CurrentRow.Cells[0].Value,
                Dgv_App.CurrentRow.Cells[1].Value

                );
            }
            
           /* DataGridViewCheckBoxColumn create = new DataGridViewCheckBoxColumn();
            create.HeaderText = "Create";
            create.Width = 60;
            Dgv_Asignacion.Columns.Add(create);
            */
        }

        private void Btn_SelTodos_Click(object sender, EventArgs e)
        {
            int p = 0;
            int q = 0;
            bool resp = false;
            foreach (DataGridViewRow item in Dgv_App.Rows)
            {
                resp = false;
                p = Convert.ToInt32(item.Cells[0].Value);
                foreach (DataGridViewRow asig in Dgv_Asignacion.Rows)
                {
                    q = Convert.ToInt32(asig.Cells[0].Value);
                    if (p == q)
                    {
                        resp = true;
                    }
                }
                if (resp == false)
                {
                    Dgv_Asignacion.Rows.Add(item.Cells[0].Value, item.Cells[1].Value);
                }
            }
        }

        private void Btn_RegUno_Click(object sender, EventArgs e)
        {
            if (Dgv_Asignacion.Rows.Count !=0)
            {
                Dgv_Asignacion.Rows.RemoveAt(Dgv_Asignacion.CurrentRow.Index);
            }
           
        }

        private void Btn_RegTodos_Click(object sender, EventArgs e)
        {
            if (Dgv_Asignacion.Rows.Count !=0)
            {
                Dgv_Asignacion.Rows.Clear();
            }
            
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            int perfil = Cmb_Perfil.SelectedIndex;
            int ret = 0;
            AppDetalle appdet = new AppDetalle();
            appdet.id_Perfil = perfil;
           
            foreach (DataGridViewRow item in Dgv_Asignacion.Rows)
            {
                appdet.id_app = Convert.ToInt32(item.Cells[0].Value);
                bool create = Convert.ToBoolean(item.Cells[2].Value);
                bool update = Convert.ToBoolean(item.Cells[3].Value);
                bool delete = Convert.ToBoolean(item.Cells[4].Value);
                if (create == true)
                {
                    appdet.create = 1;
                }else
                {
                    appdet.create = 0;

                }
                if (update == true)
                {
                    appdet.update = 1;
                }else
                {
                    appdet.update = 0;
                }
                if (delete == true)
                {
                    appdet.delete = 1;
                }else
                {
                    appdet.delete = 0;
                }
                ret = Funciones.IngresoDetalleApp(appdet);
            }
            if (ret !=0)
            {
                MessageBox.Show("Ingreso Exitoso");
            }else
            {
                MessageBox.Show("Error");
            }
           
        }

        private void Cmb_Perfil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
