using Seguridad.Listas;
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
    public partial class MantAplicaciones : Form
    {
        public MantAplicaciones()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aplicaciones app = new Aplicaciones();
            app.id_App = Convert.ToInt32(txt_IdApp.Text); ;
            app.descrip_App = txt_DescripApp.Text;
            int perfil = Funciones.InsertarApp(app);
            if (perfil != 0)
            {
                MessageBox.Show("Ingreso Exitoso");
                Dgv_App.DataSource = Funciones.MostarApp();
            }
            else
            {
                MessageBox.Show("Error al ingresar");
            }
        }

        private void MantAplicaciones_Load(object sender, EventArgs e)
        {
            cargarDgv();
        }

        public void cargarDgv()
        {
            Dgv_App.DataSource = Funciones.MostarApp();
        }
    }
}
