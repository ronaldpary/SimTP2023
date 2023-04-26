using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
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
        PruebasBondad oPB = new PruebasBondad();

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
                float desviacion = float.Parse(txtDE.Text);
                float media = float.Parse(txtMedia.Text);

                List<float> list = oDN.GenerarNumerosDEN(desviacion, media, n);

                dgvVariables.Rows.Clear();
                for (int i = 0; i < n * 2; i++)
                {
                    dgvVariables.Rows.Add(Math.Truncate(list[i] * 100) / 100);
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        float calculado = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvVariables.Rows.Count > 0)
            {
                List<float> list = new List<float>();

                foreach (DataGridViewRow row in dgvVariables.Rows)
                {
                    float nro = float.Parse(row.Cells[0].Value.ToString());
                    list.Add(nro);
                }

                int n = int.Parse(txtN.Text);
                int cantInt = int.Parse((string)comboBox1.SelectedItem);
                float desviacion = float.Parse(txtDE.Text);
                float media = float.Parse(txtMedia.Text);

                (List<int> listFO, List<float> listInt) = oDN.TablaN(n, desviacion, media, dgvTabla, list, cantInt);

                graficoN.Titles.Add("Histograma");
                for (int i = 0; i < listFO.Count; i++)
                {
                    Series serie = graficoN.Series.Add((listInt[i]).ToString());

                    serie.Label = listFO[i].ToString();
                    serie.Points.Add(float.Parse(listFO[i].ToString()));

                }

                float calc = oDN.PruebaKS_N(n, cantInt, dgvKSN, list, media, desviacion);
                calculado = calc;

            }
            else
            {
                MessageBox.Show("Primero debe generar los numeros aleatorios.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);
            double tabulado = oPB.AceptaRechazaKS(n);
            if (calculado < tabulado)
            {
                MessageBox.Show($"No se rechaza la hipotesis: Distribucion Normal \n Estadistico de prueba = {calculado}  Valor critico = {tabulado}");

            }
            else
            {
                MessageBox.Show($"Se rechaza la hipotesis \n Estadistico de prueba = {calculado}  Valor critico = {tabulado}");

            }
        }
    }
}
