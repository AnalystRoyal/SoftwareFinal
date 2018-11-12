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
    }
}
