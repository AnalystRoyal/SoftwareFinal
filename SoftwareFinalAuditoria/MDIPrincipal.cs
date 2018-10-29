using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Seguridad;
using ObjetivosFramework;
namespace SoftwareFinalAuditoria
{
    public partial class MDIPrincipal : Form
    {
        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void MDIPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void MDIPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void seguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Seguridad.Class1.iniciarsesion();
        }

        private void asignaciónDeObjetivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objetivo ob = new objetivo();
            ob.MdiParent = this;
            ob.Show();
        }
    }
}
