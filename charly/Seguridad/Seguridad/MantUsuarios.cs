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
    }
}
