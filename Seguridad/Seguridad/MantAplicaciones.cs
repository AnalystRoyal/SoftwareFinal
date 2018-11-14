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
            if (string.IsNullOrEmpty(txt_IdApp.Text)|| string.IsNullOrEmpty(txt_DescripApp.Text))
            {
                MessageBox.Show("Ingrese todos los campos");
            }else
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
            
        }

        private void MantAplicaciones_Load(object sender, EventArgs e)
        {
            cargarDgv();
        }

        public void cargarDgv()
        {
            Dgv_App.DataSource = Funciones.MostarApp();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_IdApp.Text);
            int ret = Funciones.EliminarMantApp(id);
            if (ret !=0)
            {
                MessageBox.Show("Eliminado con Exito");
                Funciones.IngresoBitacora("Eliminar", "Mantenimiento APP");
                txt_DescripApp.Text = "";
                txt_IdApp.Text = "";
                cargarDgv();
            }else
            {
                MessageBox.Show("Error");
            }

        }

        private void Dgv_App_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_IdApp.Text = Dgv_App.CurrentRow.Cells[0].Value.ToString();
            txt_DescripApp.Text = Dgv_App.CurrentRow.Cells[1].Value.ToString();
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            Aplicaciones app = new Aplicaciones();
            app.id_App = Convert.ToInt32(txt_IdApp.Text);
            app.descrip_App = txt_DescripApp.Text;
            int ret = Funciones.UpdateMantApp(app);
            if (ret !=0)
            {
                MessageBox.Show("Actualizado con Exito");
                Funciones.IngresoBitacora("Actualizar", "Mantenimiento App");
                cargarDgv();
            }else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
