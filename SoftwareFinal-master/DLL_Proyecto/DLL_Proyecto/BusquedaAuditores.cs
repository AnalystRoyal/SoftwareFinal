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
    

    public partial class BusquedaAuditores : Form
    {
        public string idAuditores;
        Capa_Datos cd = new Capa_Datos();
        string sentencia = "SELECT *FROM departamento";
        string tabla = "departamento";

        public BusquedaAuditores()
        {
            
            InitializeComponent();
            cd.llenar_dvg(Dgv_Auditores, sentencia, tabla);

        }

        private void BusquedaAuditores_Load(object sender, EventArgs e)
        {

        }
    }
}
