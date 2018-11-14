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
    public partial class MantUsuarios : Form
    {
        public MantUsuarios()
        {
            InitializeComponent();
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            Usuarios usu = new Usuarios();
            usu.NOMBRE = Txt_nombre.Text;
            usu.APELLIDO = Txt_apellido.Text;
            usu.TELEFONO = Convert.ToInt32( Txt_telefono.Text);
            usu.CORREO = Txt_correo.Text;
            usu.USUARIO = Txt_usuario.Text;
            usu.PSWD = Txt_pswd1.Text;
            int rt = Funciones.IngresoUsuario(usu);
            if (rt !=0)
            {
                MessageBox.Show("Ingreso Exitoso");
            }else
            {
                MessageBox.Show("Error en el ingreso");
            }

        }

        private void Txt_pswd2_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void Txt_pswd2_Validating(object sender, CancelEventArgs e)
        {
            if (Txt_pswd1.Text != Txt_pswd2.Text)
            {
                MessageBox.Show("Las contraseñas no son iguales");
                Btn_ingresar.Enabled = false;
            }else {
                Btn_ingresar.Enabled = true;
            }
        }

        private void MantUsuarios_Load(object sender, EventArgs e)
        {
            Txt_nombre.Focus();
            Dgv_Usuarios.DataSource = Funciones.LlenarDgvUsuarios();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_ID.Text);
            int ret = Funciones.EliminarMantUsuarios(id);
            if (ret !=0)
            {
                MessageBox.Show("Eliminado con Exito");
                Funciones.IngresoBitacora("Eliminar", "Mantenimiento Usuarios");
                Dgv_Usuarios.DataSource = Funciones.LlenarDgvUsuarios();

            }else {
                MessageBox.Show("Error");
            }
        }

        private void Dgv_Usuarios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ID.Text = Dgv_Usuarios.CurrentRow.Cells[0].Value.ToString();
            Txt_nombre.Text = Dgv_Usuarios.CurrentRow.Cells[1].Value.ToString();
            Txt_apellido.Text = Dgv_Usuarios.CurrentRow.Cells[2].Value.ToString();
            Txt_telefono.Text = Dgv_Usuarios.CurrentRow.Cells[3].Value.ToString();
            Txt_correo.Text = Dgv_Usuarios.CurrentRow.Cells[4].Value.ToString();
            Txt_usuario.Text = Dgv_Usuarios.CurrentRow.Cells[5].Value.ToString(); 
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            Usuarios usu = new Usuarios();
            usu.ID = Convert.ToInt32(txt_ID.Text);
            usu.NOMBRE = Txt_nombre.Text;
            usu.APELLIDO = Txt_apellido.Text;
            usu.TELEFONO = Convert.ToInt32(Txt_telefono.Text);
            usu.CORREO = Txt_correo.Text;
            usu.USUARIO = Txt_usuario.Text;
            int ret = Funciones.UpdateMantUsuarios(usu);
            if (ret !=0)
            {
                MessageBox.Show("Actualizado con Exito");
                Funciones.IngresoBitacora("Actualizar", "Mantenimiento Usuario");
                Dgv_Usuarios.DataSource = Funciones.LlenarDgvUsuarios();
            }else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
