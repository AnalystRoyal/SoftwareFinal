using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public partial class Form1 : Form
    { canvas = new Bunifu.DataViz.Canvas();
        public Form1()
        {
            InitializeComponent();
            bunifuDataViz2.colorSet.Add(Color.FromArgb(95, 225, 164));
            bunifuDataViz2.colorSet.Add(Color.FromArgb(95, 225, 164));
            bunifuDataViz2.colorSet.Add(Color.FromArgb(95, 225, 164));
            bunifuDataViz2.colorSet.Add(Color.FromArgb(95, 225, 164));
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (panel2.Width == 50)
            {
                LogoTransition.Show(label1);
                panel2.Visible = false;
                panel2.Width = 215;
                PanelTransition.ShowSync(panel2);
                LogoTransition.ShowSync(bunifuImageButton2);

            }
            else
            {
                LogoTransition.Hide(label1);
                panel2.Visible = false;
                panel2.Width = 50;
                PanelTransition.ShowSync(panel2);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
