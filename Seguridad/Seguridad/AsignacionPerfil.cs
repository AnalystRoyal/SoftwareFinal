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
    public partial class AsignacionPerfil : Form
    {
        public AsignacionPerfil()
        {
            InitializeComponent();
        }

        private void AsignacionPerfil_Load(object sender, EventArgs e)
        {
            Dgv_Asignacion.Columns.Add("ID", "ID");
            Dgv_Asignacion.Columns.Add("descrip", "Descripcion");
            llenarcmbUsuario();
            llenardgvPerfil();
           
            Dgv_Asignacion.AllowUserToAddRows = false;
        }

        public void llenarcmbUsuario()
        {
            Cmb_Usuario.DataSource = Funciones.LlenarDgvUsuarios();
            Cmb_Usuario.ValueMember = "ID";
            Cmb_Usuario.DisplayMember = "USUARIO";
        }

        public void llenardgvPerfil()
        {
            Dgv_Perfil.DataSource = Funciones.MostarPerfiles();
        }

        private void Btn_SelUno_Click(object sender, EventArgs e)
        {
            int p = 0;
            int q = Convert.ToInt32(Dgv_Perfil.CurrentRow.Cells[0].Value);
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
                Dgv_Perfil.CurrentRow.Cells[0].Value,
                Dgv_Perfil.CurrentRow.Cells[1].Value
                );
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

        private void Btn_SelTodos_Click(object sender, EventArgs e)
        {
            int p = 0;
            int q = 0;
            bool resp = false;
            foreach (DataGridViewRow item in Dgv_Perfil.Rows)
            {
                resp = false;
                p = Convert.ToInt32( item.Cells[0].Value);
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

        private void button1_Click(object sender, EventArgs e)
        {
            bool resp = false;
            DetalleAsigPerfil dap = new DetalleAsigPerfil();
            dap.IDUsuario = Convert.ToInt32(Cmb_Usuario.SelectedValue);
            foreach (DataGridViewRow item in Dgv_Asignacion.Rows)
            {
                dap.IDPerfil = Convert.ToInt32(item.Cells[0].Value);
                int ret = Funciones.IngresoDetalleAsigPerfil(dap);
                if (ret ==0)
                {
                    MessageBox.Show("Error al ingresar");
                    resp = true;
                }
            }
            if (resp==false)
            {
                MessageBox.Show("Ingreso Exitoso");
            }
        }

        private void Cmb_Usuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            
          //  Dgv_Asignacion.DataSource = Funciones.mostrarAsignacion(idu);
        }

        private void Cmb_Usuario_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Dgv_Asignacion.Rows.Clear();
            int idu = Convert.ToInt32(Cmb_Usuario.SelectedValue);
            int p = 0;
            int q = Funciones.mostrarAsignacion(idu).Count;
            foreach (var item in Funciones.mostrarAsignacion(idu))
            {
                if (p != q)
                {
                    Dgv_Asignacion.Rows.Add(item.id_Perfil, item.descrip_Perfil);
                    p++;
                }
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            int perfil = Convert.ToInt32(Cmb_Usuario.SelectedValue);
            int ret = Funciones.EliminarAsigPerfil(perfil);
            if (ret != 0)
            {
                MessageBox.Show("Eliminado Con Exito");
                Funciones.IngresoBitacora("Eliminar", "Asignacion Perfil");
                Dgv_Asignacion.Rows.Clear();
            }
            else
            {
                MessageBox.Show("Error");
            }

        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            DetalleAsigPerfil dap = new DetalleAsigPerfil();
            bool resp = false;
            int id = Convert.ToInt32(Cmb_Usuario.SelectedValue);
            int ret2 = Funciones.EliminarAsigPerfil(id);
            if (ret2 !=0)
            {
                dap.IDUsuario = Convert.ToInt32(Cmb_Usuario.SelectedValue);
                foreach (DataGridViewRow item in Dgv_Asignacion.Rows)
                {
                    dap.IDPerfil = Convert.ToInt32(item.Cells[0].Value);
                    int ret = Funciones.IngresoDetalleAsigPerfil(dap);
                    if (ret == 0)
                    {
                        MessageBox.Show("Error al Actualizar");
                        resp = true;
                    }
                }
                if (resp == false)
                {
                    MessageBox.Show("Actualizar Exitoso");
                    Funciones.IngresoBitacora("Actualizar", "Asignacion Perfil");
                }
            }else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
