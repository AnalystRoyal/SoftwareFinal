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
            int id = Convert.ToInt32(Txt_IdPerfil.Text);
            Perfiles per = new Perfiles();
            per.id_Perfil = id;
            per.descrip_Perfil = Txt_DescripPerfil.Text;
            int perfil = Funciones.InsertarPerfil(per);
            if (perfil != 0)
            {
                MessageBox.Show("Ingreso Exitoso");
            }
            else
            {
                MessageBox.Show("Error al ingresar");
            }
        }
    }
}
