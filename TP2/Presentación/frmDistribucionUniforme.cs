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
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;

namespace SimTP2Q.Presentación
{
    public partial class frmDistribucionUniforme : Form
    {
        public frmDistribucionUniforme()
        {
            InitializeComponent();
        }
       
        Uniforme oDU = new Uniforme();
        PruebasBondad oPB = new PruebasBondad();
        private void frmDistribucionUniforme_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {

            

            if (txtA.Text == "" || txtB.Text == "" || txtN.Text == "")
            {
                MessageBox.Show("Debe ingresar todos los valores (A, B y n).");
                txtA.Focus();
                return;
            }
            else
            {
                int n = int.Parse(txtN.Text);
                if (n > 1000000)
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
                            dgvVariables.Rows.Add(Math.Truncate(list[i] * 100) / 100);

                        }

                    }
                    else
                    {
                        MessageBox.Show("El valor de A debe ser menor al de B");
                        return;
                    }

                }
            }

            
        }

        private void dgvVariables_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        float calculado = 0;
        private void button1_Click(object sender, EventArgs e)
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
                int A = int.Parse(txtA.Text);
                int B = int.Parse(txtB.Text);

                if (comboBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe ingresar un intervalo.");
                    comboBox1.Focus();
                }
                else
                {
                    int cantInt = int.Parse((string)comboBox1.SelectedItem);

                    (float calc, List<int> listFO, List<float> listInt) = oDU.PruebaChiCuadrado(n, cantInt, dataGridView1, list);

                    calculado = calc;

                    chart1.Titles.Add("Histograma");
                    for (int i = 0; i < listFO.Count; i++)
                    {
                        Series serie = chart1.Series.Add((listInt[i]).ToString());

                        serie.Label = listFO[i].ToString();
                        serie.Points.Add(float.Parse(listFO[i].ToString()));

                    }
                }

                button2.Enabled = true;
            }
            else
            {
                MessageBox.Show("Debe primero generar los numeros aleatorios.");
            }

        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            int cantInt = int.Parse((string)comboBox1.SelectedItem);
            double tabulado = oPB.AceptaRechazaCC(cantInt, "Uniforme");
            if (calculado < tabulado)
            {
                MessageBox.Show($"No se rechaza la hipotesis: Distribucion Uniforme \n Estadistico de prueba = {calculado}  Valor critico = {tabulado}");

            }
            else
            {
                MessageBox.Show($"Se rechaza la hipotesis \n Estadistico de prueba = {calculado}  Valor critico = {tabulado}");

            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
