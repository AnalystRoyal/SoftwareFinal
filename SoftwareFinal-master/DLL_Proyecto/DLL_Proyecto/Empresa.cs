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
    public partial class Empresa : Form,Cambio
    {
        public Empresa()
        {
            InitializeComponent();
        }

        public void trasladoid(string area)
        {
            DataGridViewRow fila = new DataGridViewRow();

            fila.CreateCells(Dgv_Areas);
            fila.Cells[0].Value = area;
            Dgv_Areas.Rows.Add(fila);
            area = "";

            int c = Dgv_Areas.RowCount;
        }

        private void Btn_Agregar_Areas_Click(object sender, EventArgs e)
        {
            BusquedaAreas busqueda = new BusquedaAreas();
            busqueda.Show();
        }

        private void Empresa_Load(object sender, EventArgs e)
        {

        }

        private void guardar_Click(object sender, EventArgs e)
        {

        }
    }
}
