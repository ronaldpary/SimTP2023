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
    public partial class frmDistribucionUniforme : Form
    {
        public frmDistribucionUniforme()
        {
            InitializeComponent();
        }
        //NumerosAleatorios oNA = new NumerosAleatorios();
        Uniforme oDU = new Uniforme();
        private void frmDistribucionUniforme_Load(object sender, EventArgs e)
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
                int A = int.Parse(txtA.Text);
                int B = int.Parse(txtB.Text);

                if (B > A)
                {
                    List<float> list = oDU.GenerarNumerosDU(A, B, n);
                    dgvVariables.Rows.Clear();
                    for (int i = 0; i < n; i++)
                    {
                        dgvVariables.Rows.Add(list[i]);
                    }

                }
                else
                {
                    MessageBox.Show("El valor de A debe ser menor al de B");
                    return;
                }

                

                
            }
            

        }

        private void dgvVariables_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
