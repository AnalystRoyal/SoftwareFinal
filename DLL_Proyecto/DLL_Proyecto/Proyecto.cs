using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLL_Proyecto
{
    public partial class Proyecto : Form

    {
        //se instancia la clase capa logica
        Capa_Logica cl = new Capa_Logica();

        public Proyecto()
        {
            InitializeComponent();

            //se modifica para ingresar la fecha
            Dtp_Fecha_Inicio.Format = DateTimePickerFormat.Custom;
            Dtp_Fecha_Inicio.CustomFormat = "yyyy-MM-dd";
            Dtp_Fecha_Fin.Format = DateTimePickerFormat.Custom;
            Dtp_Fecha_Fin.CustomFormat = "yyyy-MM-dd";

            //se instacia el metodo buscar id
            cl.buscar(Txt_idProyecto);
            //se convierte el dato en int y se le suma 1 para el ingreso nuevo
            if (Txt_idProyecto.Text == "")
            {
                Txt_idProyecto.Text = "1";
            }
            else
            {
                Int32 ida = Convert.ToInt32(Txt_idProyecto.Text);
                ida = ida + 1;
                Txt_idProyecto.Text = ida.ToString();
            }

        }

        private void Proyecto_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Agregar_Empresa_Click(object sender, EventArgs e)
        {
            Empresa empresa = new Empresa();
            empresa.Show();
        }

        private void Btn_Agregar_Tipo_Proyecto_Click(object sender, EventArgs e)
        {

        }
    }
}
