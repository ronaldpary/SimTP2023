using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
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
            float media = float.Parse(txtME.Text);
            float desviacion = float.Parse(txtDE.Text);


            //List<float> listNA = obNA.GenerarNumeros(n);
            (List<float> listRnd, List<float> listDN) = obN.GenerarNumerosDENMontecarlo(desviacion, media, n / 2);

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
            float acumulador2 = 0;

            float rndA = 0;
            string atiende = "";

            float rndQ = 0;
            string sexo = "";

            float rndD = 0;
            string compraMujer = "";
            string compraHombre = "";

            float rndG = 0;
            string costo = "";




            for (int j = 0; j < sumaLLamadas; j++)
            {


                //float suma = 0;

                //dataGridView1.Rows.Add(1);

                //float a = listAtencion[j];
                //float b = (float)4/5;

                rndA = listAtencion[j];
                //dataGridView1.Rows[j].Cells[0].Value = listAtencion[j];

                if (rndA < (float)3 / 20)
                {
                    atiende = "No";
                    //dataGridView1.Rows[j].Cells[1].Value = "No";
                }
                else
                {
                    atiende = "Si";
                    //dataGridView1.Rows[j].Cells[1].Value = "Si";
                }


                rndQ = listQuien[j];

                //dataGridView1.Rows[j].Cells[2].Value = listQuien[j];

                //sexo = "";

                if (rndQ < (float)4 / 5)
                {

                    sexo = "Mujer";
                    //sexo = (string)(dataGridView1.Rows[j].Cells[3].Value = "Mujer");
                }
                else
                {
                    sexo = "Hombre";
                    //sexo = (string)(dataGridView1.Rows[j].Cells[3].Value = "Hombre");
                }


                rndD = listDemanda[j];
                //dataGridView1.Rows[j].Cells[4].Value = listDemanda[j];

                if (sexo == "Mujer")
                {
                    if (rndD < (float)7 / 10)
                    {

                        compraMujer = "Si";
                        //dataGridView1.Rows[j].Cells[5].Value = "Si";

                        rndG = ListGasto[j];
                        //dataGridView1.Rows[j].Cells[6].Value = ListGasto[j];

                        if (rndG < (float)2 / 10)
                        {

                            costo = "5";
                            //dataGridView1.Rows[j].Cells[7].Value = "5";

                            acumulador = acumulador + 5;

                            // ver
                            //dataGridView1.Rows[j].Cells[8].Value = acumulador;

                        }
                        else
                        {
                            costo = "10";
                            //dataGridView1.Rows[j].Cells[7].Value = "10";

                            acumulador = acumulador + 10;

                            //ver
                            //dataGridView1.Rows[j].Cells[8].Value = acumulador;
                        }

                    }
                    else
                    {
                        compraMujer = "No";
                        //dataGridView1.Rows[j].Cells[5].Value = "No";
                    }
                }
                else
                {
                    if (rndD < (float)2 / 5)
                    {
                        compraHombre = "Si";
                        //dataGridView1.Rows[j].Cells[5].Value = "Si";

                        rndG = ListGasto[j];
                        //dataGridView1.Rows[j].Cells[6].Value = ListGasto[j];

                        if (rndG < (float)2 / 40)
                        {
                            costo = "5";
                            //dataGridView1.Rows[j].Cells[7].Value = "5";

                            acumulador = acumulador + 5;

                            //ver
                            //dataGridView1.Rows[j].Cells[8].Value = acumulador;
                        }
                        else
                        {
                            costo = "10";
                            //dataGridView1.Rows[j].Cells[7].Value = "10";

                            acumulador = acumulador + 10;

                            //ver
                            //dataGridView1.Rows[j].Cells[8].Value = acumulador;
                        }
                    }
                    else
                    {
                        compraHombre = "No";
                        //dataGridView1.Rows[j].Cells[5].Value = "No";
                    }
                }


            }


            for (int h = 0; h < 1; h++)
            {
                
                dataGridView1.Rows.Add(1);
                dataGridView1.Rows[h].Cells[0].Value = rndA;
                dataGridView1.Rows[h].Cells[1].Value = atiende;
                dataGridView1.Rows[h].Cells[2].Value = rndQ;
                dataGridView1.Rows[h].Cells[3].Value = quien;
                dataGridView1.Rows[h].Cells[4].Value = rndD;
                dataGridView1.Rows[h].Cells[5].Value = compraMujer;
                dataGridView1.Rows[h].Cells[6].Value = rndG;
                dataGridView1.Rows[h].Cells[7].Value = costo;
                dataGridView1.Rows[h].Cells[8].Value = acumulador;
            }

            // Veer

            //int desde = int.Parse(txtDesde.Text);
            //int hasta = int.Parse(txtHasta.Text);

            //for (int j = 0; j < sumaLLamadas; j++)
            //{

            //    if (j >= desde/* && j <= hasta*/)
            //    {
            //        dgvVersion2.Rows.Add(1);

            //        //float a = listAtencion[j];
            //        //float b = (float)4/5;

            //        dgvVersion2.Rows[j].Cells[0].Value = listAtencion[j];

            //        if (listAtencion[j] < (float)3 / 20)
            //        {
            //            dgvVersion2.Rows[j].Cells[1].Value = "No";
            //        }
            //        else
            //        {
            //            dgvVersion2.Rows[j].Cells[1].Value = "Si";
            //        }



            //        dgvVersion2.Rows[j].Cells[2].Value = listQuien[j];

            //        string sexo1 = "";

            //        if (listQuien[j] < (float)4 / 5)
            //        {
            //            sexo1 = (string)(dgvVersion2.Rows[j].Cells[3].Value = "Mujer");
            //        }
            //        else
            //        {
            //            sexo1 = (string)(dgvVersion2.Rows[j].Cells[3].Value = "Hombre");
            //        }



            //        dgvVersion2.Rows[j].Cells[4].Value = listDemanda[j];

            //        if (sexo1 == "Mujer")
            //        {
            //            if (listDemanda[j] < (float)7 / 10)
            //            {
            //                dgvVersion2.Rows[j].Cells[5].Value = "Si";

            //                dgvVersion2.Rows[j].Cells[6].Value = ListGasto[j];

            //                if (ListGasto[j] < (float)2 / 10)
            //                {
            //                    dgvVersion2.Rows[j].Cells[7].Value = "5";

            //                    acumulador2 = acumulador2 + 5;

            //                    dgvVersion2.Rows[j].Cells[8].Value = acumulador2;

            //                }
            //                else
            //                {
            //                    dgvVersion2.Rows[j].Cells[7].Value = "10";

            //                    acumulador2 = acumulador2 + 10;

            //                    dgvVersion2.Rows[j].Cells[8].Value = acumulador2;
            //                }

            //            }
            //            else
            //            {
            //                dgvVersion2.Rows[j].Cells[5].Value = "No";
            //            }
            //        }
            //        else
            //        {
            //            if (listDemanda[j] < (float)2 / 5)
            //            {
            //                dgvVersion2.Rows[j].Cells[5].Value = "Si";

            //                dgvVersion2.Rows[j].Cells[6].Value = ListGasto[j];

            //                if (ListGasto[j] < (float)2 / 40)
            //                {
            //                    dgvVersion2.Rows[j].Cells[7].Value = "5";

            //                    acumulador2 = acumulador2 + 5;

            //                    dgvVersion2.Rows[j].Cells[8].Value = acumulador2;
            //                }
            //                else
            //                {
            //                    dgvVersion2.Rows[j].Cells[7].Value = "10";

            //                    acumulador2 = acumulador2 + 10;

            //                    dgvVersion2.Rows[j].Cells[8].Value = acumulador2;
            //                }
            //            }
            //            else
            //            {
            //                dgvVersion2.Rows[j].Cells[5].Value = "No";
            //            }
            //        }
            //    }
            //    //float suma = 0;

                


            //}
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
        }

        private void frmMontecarloV2_Load(object sender, EventArgs e)
        {
            //dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Green;
        }

        private void dgvVersion2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
