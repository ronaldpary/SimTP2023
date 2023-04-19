using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimTP2Q.Lógica;

namespace SimTP2Q.Presentación
{
    public partial class frmDistribucionPoisson : Form
    {
        public frmDistribucionPoisson()
        {
            InitializeComponent();
        }

        Poisson oDP = new Poisson();

        private void frmDistribucionPoisson_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);
            if (n > 50000)
            {
                MessageBox.Show("Debe ingresar un número de muestra no mayor a 50000.");
                return;
            }
            else
            {
                int mediaL = int.Parse(txtMediaLambda.Text);

                List<float> list = oDP.GenerarNumerosDP(mediaL, n);

                dgvVariables.Rows.Clear();
                for (int i = 0; i < n; i++)
                {
                    dgvVariables.Rows.Add(list[i]);
                }
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
