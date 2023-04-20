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

            if (txtN.Text != "" && txtMediaLambda.Text != "")
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
            else
            {
                MessageBox.Show("Ingrese los valores correspondientes");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<float> list = new List<float>();
            dataGridViewPoisson.Rows.Clear();
            foreach (DataGridViewRow row in dgvVariables.Rows)
            {
                float nro = float.Parse(row.Cells[0].Value.ToString());     //Toma el valor de el DGV de generados y los pasa a una Lista llamada list
                list.Add(nro);
            }

            int n = int.Parse(txtN.Text);       //ERROR no ingreso nada
            float lambda = float.Parse(txtMediaLambda.Text);

            if (txtN.Text != "" && txtMediaLambda.Text != "")
            {

                
                list.Sort();        //
                List<float> listaSinR = list.Distinct().ToList();

                (float calculado, List<float>listSinR) = oDP.PruebaKS_P(listaSinR, list, lambda, n, dataGridViewPoisson);

               

                /////////
                int v = listSinR.Count - 1 - 1;
                List<double> gradoLibertad = new List<double> { 0, 3.84, 5.99, 7.81, 9.49, 11.1, 12.6, 14.1, 15.5, 16.9, 18.3, 19.7, 21.0, 22.4, 23.7, 25.0, 26.3, 27.6, 28.9, 30.1, 31.4, 32.7, 33.9, 35.2, 36.4, 37.7, 38.9, 40.1, 41.3, 42.6, 43.8, 55.8, 67.5, 79.1, 90.5, 101.9, 113.1, 124.3 };
                double valorLibertad = gradoLibertad[v];
                if (calculado <= valorLibertad)
                {
                    MessageBox.Show($"No se rechaza la hipotesis: Distribucion Poisson \n Estadistico de prueba = {calculado}  Valor critico = {valorLibertad}");

                }
                else
                {
                    MessageBox.Show($"Se rechaza la hipotesis \n Estadistico de prueba = {calculado}  Valor critico = {valorLibertad}");

                }
                ///

                /*                                                         Error al generar nueva serie
                chart1.Titles.Add("Histograma");
                for (int i = 0; i < grafico.Count; i++)
                {
                    Series serie = chart1.Series.Add((intervalos[i]).ToString()); //ERROR

                    serie.Label = grafico[i].ToString();
                    serie.Points.Add(float.Parse(grafico[i].ToString()));
                }
                */
                ///
            }
            else
            {
                MessageBox.Show("Error Seleccione un valor");
            }
        }
    }
}
