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
    public partial class frmDistribucionNormal : Form
    {
        public frmDistribucionNormal()
        {
            InitializeComponent();
        }

        Normal oDN = new Normal();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmDistribucionNormal_Load(object sender, EventArgs e)
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
                int desviacion = int.Parse(txtDE.Text);
                int media = int.Parse(txtMedia.Text);

                List<float> list = oDN.GenerarNumerosDEN(desviacion, media, n);

                dgvVariables.Rows.Clear();
                for (int i = 0; i < n * 2; i++)
                {
                    dgvVariables.Rows.Add(list[i]);
                }
            }
            
        }
    }
}
