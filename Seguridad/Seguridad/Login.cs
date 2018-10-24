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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MdiSeguridad mdi = new MdiSeguridad();
            bool con = Conexion.comprobacionConexion();
            if (con == true)
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
    }
}
