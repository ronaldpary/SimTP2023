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
    public partial class frmDistribucionExponencial : Form
    {
        public frmDistribucionExponencial()
        {
            InitializeComponent();
        }

        Exponencial oDEN = new Exponencial();
        PruebasBondad oPB = new PruebasBondad();

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
            button2.Enabled = false;
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

                int lambda = int.Parse(txtLambda.Text);

                int cantInt = int.Parse((string)comboBox1.SelectedItem);

                (List<int> listFO, List<float> listInt) = oDEN.TablaExp(n, cantInt, dgvTabla, list, lambda);

                

                graficoEX.Titles.Add("Histograma");
                for (int i = 0; i < listFO.Count; i++)
                {
                    Series serie = graficoEX.Series.Add((listInt[i]).ToString());

                    serie.Label = listFO[i].ToString();
                    serie.Points.Add(float.Parse(listFO[i].ToString()));

                }

                //float calculado = oDEN.PruebaChiCuadradoEx(n, cantInt, dgvChiCuadradoE, list, lambda);

                float calc = oDEN.PruebaKS_Ex(n, cantInt, dgvKSEx, list, lambda);
                calculado = calc;

                button2.Enabled = true;
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
                MessageBox.Show($"No se rechaza la hipotesis: Distribucion Exponencial \n Estadistico de prueba = {calculado}  Valor critico = {tabulado}");

            }
            else
            {
                MessageBox.Show($"Se rechaza la hipotesis \n Estadistico de prueba = {calculado}  Valor critico = {tabulado}");

            }
        }
    }
}
