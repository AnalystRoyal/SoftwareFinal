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
    public partial class MantPerfiles : Form
    {
        public MantPerfiles()
        {
            InitializeComponent();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            Perfiles per = new Perfiles();
            if (string.IsNullOrEmpty(Txt_IdPerfil.Text)|| string.IsNullOrEmpty(Txt_DescripPerfil.Text))
            {
                MessageBox.Show("Ingrese todos los campos");
            }else
            {
                per.id_Perfil = Convert.ToInt32(Txt_IdPerfil.Text); ;
                per.descrip_Perfil = Txt_DescripPerfil.Text;
                int perfil = Funciones.InsertarPerfil(per);
                if (perfil != 0)
                {
                    MessageBox.Show("Ingreso Exitoso");
                    Funciones.IngresoBitacora("insertar", "mantperfiles");
                    cargarPerfil();
                }
                else
                {
                    MessageBox.Show("Error al ingresar");
                }
            }
            
        }

        private void MantPerfiles_Load(object sender, EventArgs e)
        {
            cargarPerfil();
        }

        public void cargarPerfil()
        {
            Dgv_Perfiles.DataSource = Funciones.MostarPerfiles();
            
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Txt_IdPerfil.Text);
            int ret = Funciones.EliminarMantPerfil(id);
            if (ret !=0)
            {
                MessageBox.Show("Eliminado con Exito");
                Funciones.IngresoBitacora("Eliminar", "Mantenimiento Perfil");
                Txt_DescripPerfil.Text = "";
                Txt_IdPerfil.Text = "";
                cargarPerfil();
            }else
            {
                MessageBox.Show("Error");
            }
        }

        private void Dgv_Perfiles_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Txt_IdPerfil.Text = Dgv_Perfiles.CurrentRow.Cells[0].Value.ToString();
            Txt_DescripPerfil.Text = Dgv_Perfiles.CurrentRow.Cells[1].Value.ToString();

        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            Perfiles per = new Perfiles();
            per.id_Perfil = Convert.ToInt32(Txt_IdPerfil.Text);
            per.descrip_Perfil = Txt_DescripPerfil.Text;
            int ret = Funciones.UpdatePerfil(per);
            if (ret != 0)
            {
                MessageBox.Show("Actualizado con Exito");
                Funciones.IngresoBitacora("Actualizar", "Mantenimiento Perfiles");
                cargarPerfil();

            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
