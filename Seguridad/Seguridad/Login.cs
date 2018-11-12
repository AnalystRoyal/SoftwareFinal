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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MdiSeguridad mdi = new MdiSeguridad();
             string usuario = Txt_Usuario.Text;
            string pswd = Txt_pswd.Text;
            if (usuario != "" || pswd != "")
            {
                bool rt = Funciones.IngresoSesion(usuario, pswd);
                if (rt == true)
                {
                    MessageBox.Show("Conexión Exitosa");
                    this.Hide();
                    mdi.Show();
                }
                else
                {
                    MessageBox.Show("Conexión Fallida");
                }
            }
            else
            {
                MessageBox.Show("Ingrese usuario o contraseña valida");
            }
        }
    }
}
