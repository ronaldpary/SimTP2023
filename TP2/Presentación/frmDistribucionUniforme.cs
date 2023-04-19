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
                        dgvVariables.Rows.Add(Math.Truncate(list[i]*100)/100);
                        
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

        private void button1_Click(object sender, EventArgs e)
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

            int cantInt = int.Parse((string)comboBox1.SelectedItem);
            //float uno = 1 / 5;
            

            float min = list.Min();
            float max = list.Max();

            float diferencia = max - min;
            float ancho = diferencia/ (float)cantInt;

            float acumulador = 0;

            List<int> grafico = new List<int>();
            List<float> intervalos = new List<float>();

            for (int i = 0; i < cantInt; i++)
            {
                //int desde = dataGridView1.Rows.Add(min+(i*(ancho)));
                
                dataGridView1.Rows.Add(1);
                float desde = ((float)(dataGridView1.Rows[i].Cells[0].Value = min + (i * (ancho))));
                float hasta = ((float)(dataGridView1.Rows[i].Cells[1].Value = desde + ancho));
                int fo = ((int)(dataGridView1.Rows[i].Cells[2].Value = frecuenciaObservada(list, desde, hasta)));
                float fe = ((float)(dataGridView1.Rows[i].Cells[3].Value = (float)n / cantInt));
                float c = ((float)(dataGridView1.Rows[i].Cells[4].Value = (float)(Math.Pow((fe-(float)fo),2)/fe)));
                acumulador += c;
                float ca = ((float)(dataGridView1.Rows[i].Cells[5].Value = acumulador));

                grafico.Add(fo);
                intervalos.Add(hasta);
                ////int hasta = dataGridView1.Rows[1].Add((int)desde);

            }

            chart1.Titles.Add("Histograma");
            for (int i = 0; i < grafico.Count; i++)
            {
                Series serie = chart1.Series.Add((intervalos[i]).ToString());

                serie.Label = grafico[i].ToString();
                serie.Points.Add(float.Parse(grafico[i].ToString()));

            }

        }
        public int frecuenciaObservada(List<float> lista, float desde, float hasta)
        {
            int fo = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] >= desde & lista[i] <= hasta)
                    fo += 1;
            }
            return fo;
        }

        private void button2_Click(object sender, EventArgs e)
        {
        //    int cantInt = int.Parse((string)comboBox1.SelectedItem);
        //    int gradosL = cantInt - 1;
        }
    }
}
