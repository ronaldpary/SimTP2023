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
    public partial class frmDistribucionExponencial : Form
    {
        public frmDistribucionExponencial()
        {
            InitializeComponent();
        }

        Exponencial oDEN = new Exponencial();

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
                float lambda = float.Parse(txtLambda.Text);

                List<float> list = oDEN.GenerarNumerosDEN(lambda, n);

                dgvVariables.Rows.Clear();
                for (int i = 0; i < n; i++)
                {
                    dgvVariables.Rows.Add(list[i]);
                }
            }
            
        }

        private void frmDistribucionExponencial_Load(object sender, EventArgs e)
        {

        }
    }
}
