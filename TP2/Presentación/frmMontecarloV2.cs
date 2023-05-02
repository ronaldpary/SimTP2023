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
    public partial class frmMontecarloV2 : Form
    {

        Normal obN = new Normal();
        NumerosAleatorios obNA = new NumerosAleatorios();

        public frmMontecarloV2()
        {
            InitializeComponent();
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);

            //List<float> listNA = obNA.GenerarNumeros(n);
            (List<float> listRnd, List<float> listDN) = obN.GenerarNumerosDENMontecarlo(3, 20, n / 2);

            List<float> listaLlamadas = new List<float>();

            for (int i = 0; i < n; i++)

            {

                dgvMontecarlo.Rows.Add(1);

                dgvMontecarlo.Rows[i].Cells[i * (i - i)].Value = i + 1;
                dgvMontecarlo.Rows[i].Cells[(i * (i - i)) + (1 / (1 + 0 * i))].Value = Math.Truncate(listRnd[i] * 100) / 100;

                double cantidadLLamadas = ((double)(dgvMontecarlo.Rows[i].Cells[(i * (i - i)) + (2 / (1 + 0 * i))].Value = Math.Truncate(listDN[i])));
                listaLlamadas.Add((float)Math.Truncate(cantidadLLamadas));


            }

            int sumaLLamadas = (int)listaLlamadas.Sum();

            List<float> listAtencion = obNA.GenerarNumeros(sumaLLamadas);
            List<float> listQuien = obNA.GenerarNumeros(sumaLLamadas);
            List<float> listDemanda = obNA.GenerarNumeros(sumaLLamadas);
            List<float> ListGasto = obNA.GenerarNumeros(sumaLLamadas);

            float acumulador = 0;

            for (int j = 0; j < sumaLLamadas; j++)
            {


                //float suma = 0;

                dataGridView1.Rows.Add(1);

                //float a = listAtencion[j];
                //float b = (float)4/5;

                dataGridView1.Rows[j].Cells[0].Value = listAtencion[j];

                if (listAtencion[j] < (float)3 / 20)
                {
                    dataGridView1.Rows[j].Cells[1].Value = "No";
                }
                else
                {
                    dataGridView1.Rows[j].Cells[1].Value = "Si";
                }



                dataGridView1.Rows[j].Cells[2].Value = listQuien[j];

                string sexo = "";

                if (listQuien[j] < (float)4 / 5)
                {
                    sexo = (string)(dataGridView1.Rows[j].Cells[3].Value = "Mujer");
                }
                else
                {
                    sexo = (string)(dataGridView1.Rows[j].Cells[3].Value = "Hombre");
                }



                dataGridView1.Rows[j].Cells[4].Value = listDemanda[j];

                if (sexo == "Mujer" )
                {
                    if (listDemanda[j] < (float)7 / 10)
                    {
                        dataGridView1.Rows[j].Cells[5].Value = "Si";

                        dataGridView1.Rows[j].Cells[6].Value = ListGasto[j];

                        if (ListGasto[j] < (float)2/10)
                        {
                            dataGridView1.Rows[j].Cells[7].Value = "5";

                            acumulador = acumulador + 5;

                            dataGridView1.Rows[j].Cells[8].Value = acumulador;

                        }
                        else
                        {
                            dataGridView1.Rows[j].Cells[7].Value = "10";

                            acumulador = acumulador + 10;

                            dataGridView1.Rows[j].Cells[8].Value = acumulador;
                        }

                    }
                    else
                    {
                        dataGridView1.Rows[j].Cells[5].Value = "No";
                    }
                }
                else
                {
                    if (listDemanda[j] < (float)2 / 5)
                    {
                        dataGridView1.Rows[j].Cells[5].Value = "Si";

                        dataGridView1.Rows[j].Cells[6].Value = ListGasto[j];

                        if (ListGasto[j] < (float)2 / 40)
                        {
                            dataGridView1.Rows[j].Cells[7].Value = "5";

                            acumulador = acumulador + 5;

                            dataGridView1.Rows[j].Cells[8].Value = acumulador;
                        }
                        else
                        {
                            dataGridView1.Rows[j].Cells[7].Value = "10";

                            acumulador = acumulador + 10;

                            dataGridView1.Rows[j].Cells[8].Value = acumulador;
                        }
                    }
                    else
                    {
                        dataGridView1.Rows[j].Cells[5].Value = "No";
                    }
                }

                
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
        }

        private void frmMontecarloV2_Load(object sender, EventArgs e)
        {
            //dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Green;
        }
    }
}
