using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimTP2Q.Presentación;

namespace SimTP2Q
{
    public partial class frmVariablesAleatorias : Form
    {
        public frmVariablesAleatorias()
        {
            InitializeComponent();
        }

        private void btNl_Click(object sender, EventArgs e)
        {
            frmDistribucionNormal fn = new frmDistribucionNormal();
            fn.ShowDialog();
            fn.Dispose();
        }

        private void btnUf_Click(object sender, EventArgs e)
        {
            frmDistribucionUniforme fu = new frmDistribucionUniforme();
            fu.ShowDialog();
            fu.Dispose();
        }

        private void btExp_Click(object sender, EventArgs e)
        {
            frmDistribucionExponencial fe = new frmDistribucionExponencial();
            fe.ShowDialog();
            fe.Dispose();
        }

        private void btnPs_Click(object sender, EventArgs e)
        {
            frmDistribucionPoisson fp = new frmDistribucionPoisson();
            fp.ShowDialog();
            fp.Dispose();
        }

        private void frmVariablesAleatorias_Load(object sender, EventArgs e)
        {

        }
    }
}
