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
    public partial class MdiSeguridad : Form
    {
        public MdiSeguridad()
        {
            InitializeComponent();
        }

        private void perfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantPerfiles per = new MantPerfiles();
            per.Show();
        }
    }
}
