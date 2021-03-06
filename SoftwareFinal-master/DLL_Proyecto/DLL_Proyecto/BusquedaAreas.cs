﻿using System;
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
    public partial class BusquedaAreas : Form
    {

        public string idAreas;
        Capa_Datos cd = new Capa_Datos();
        string sentencia = "SELECT *FROM departamento";
        string tabla = "departamento";

        public BusquedaAreas()
        {
            InitializeComponent();
            cd.llenar_dvg(Dgv_Areas_Empresas, sentencia, tabla);

        }

        private void BusquedaAreas_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Seleccionar_Click(object sender, EventArgs e)
        {
            Txt_IdAreas.Text = this.Dgv_Areas_Empresas.CurrentRow.Cells[0].Value.ToString();

            idAreas = Txt_IdAreas.Text.ToString();

            Cambio cam = this.Owner as Cambio;

            if (cam != null)
                cam.trasladoid(idAreas);

            this.Hide();
        }
    }
}
