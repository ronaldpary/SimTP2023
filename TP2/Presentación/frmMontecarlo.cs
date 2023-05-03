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
    public partial class frmMontecarlo : Form
    {

        Normal obN = new Normal();
        NumerosAleatorios obNA = new NumerosAleatorios();
        public frmMontecarlo()
        {
            InitializeComponent();
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);

            //List<float> listNA = obNA.GenerarNumeros(n);
            (List<float> listRnd, List<float> listDN) = obN.GenerarNumerosDENMontecarlo(3, 20, n/2);

            for (int i = 0; i < n; i++)

            {

                //(List<float> listNA, float rnd1, float rnd2) = obN.GenerarNumerosDENMontecarlo(3, 20, n);

                dgvMontecarlo.Rows.Add(1);

                dgvMontecarlo.Rows[i].Cells[i*(i-i)].Value = i+1;
                dgvMontecarlo.Rows[i].Cells[(i * (i - i))+ (1 / (1 + 0 * i))].Value = Math.Truncate(listRnd[i] * 100) / 100;

                double cantidadLLamadas = ((double)(dgvMontecarlo.Rows[i].Cells[(i * (i - i)) + (2 / (1 + 0 * i))].Value = Math.Truncate(listDN[i])));

                List<float> listNA = obNA.GenerarNumeros((int)cantidadLLamadas);
                for (int j = 0; j < cantidadLLamadas; j++)
                {
                    dgvMontecarlo.Rows[i].Cells[(i * (i - i)) + (3 / (1 + 0 * i))].Value = listNA[j];
                }
              


            }
        }

        private void frmMontecarlo_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
