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
    public partial class frmCallcenter : Form
    {
        Normal obN = new Normal();
        NumerosAleatorios obNA = new NumerosAleatorios();
        private int n;
        private float ingresoPorHora;
        private float ingresoPorHoraCC;

        //public frmCallcenter()
        //{
        //    InitializeComponent();
        //}

        public frmCallcenter(int n, float ingresoPorHora)
        {
            InitializeComponent();
            this.n = n;
            this.ingresoPorHora = ingresoPorHora;
        }

        private void frmCallcenter_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSimular_Click(object sender, EventArgs e)
        {

            dgvMontecarlo.Rows.Clear();
            dataGridView1.Rows.Clear();

            //int n = int.Parse(txtN.Text);
            float media = float.Parse(txtME.Text);
            float desviacion;
            if (txtDE.Text == "")
            {
                desviacion = 0;
            }
            else
            {
                desviacion = float.Parse(txtDE.Text);
            }

            (List<float> listRnd, List<float> listDN) = obN.GenerarNumerosDENMontecarlo(desviacion, media, n);

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


            float acumulador = 0;
                //float acumulador2 = 0;

            float rndA = 0;
            string atiende = "";

            float rndQ = 0;
            string sexo = "";

            float rndD = 0;
            string compra = "";

            float rndG = 0;
            string costo = "";

            List<float> listAtencion = obNA.DesordenarNumeros(obNA.GenerarNumeros(sumaLLamadas));
            List<float> listQuien = obNA.GenerarNumeros(sumaLLamadas);
            List<float> listDemanda = obNA.DesordenarNumeros(obNA.GenerarNumeros(sumaLLamadas));
            List<float> ListGasto = obNA.GenerarNumeros(sumaLLamadas);

            for (int j = 0; j < sumaLLamadas; j++)
            {

                //dataGridView1.Rows.Add(1);
                rndA = listAtencion[j];
                //dataGridView1.Rows[j].Cells[0].Value = listAtencion[j];

                if (rndA < (float)3 / 20)
                {
                    atiende = "No";
                    //dataGridView1.Rows[j].Cells[1].Value = "No";
                    //dataGridView1.Rows[j].Cells[7].Value = "0";
                    //dataGridView1.Rows[j].Cells[8].Value = acumulador;
                    
                    rndQ = 0;
                    sexo = "";
                    rndD = 0;
                    compra = "";
                    rndG = 0;
                    costo = "0";
                }
                else
                {
                    atiende = "Si";
                    //dataGridView1.Rows[j].Cells[1].Value = "Si";
                    rndQ = listQuien[j];

                    //dataGridView1.Rows[j].Cells[2].Value = listQuien[j];


                    if (rndQ < (float)4 / 5)
                    {

                        sexo = "Mujer";
                        //dataGridView1.Rows[j].Cells[3].Value = "Mujer";
                    }
                    else
                    {
                        sexo = "Hombre";
                        //dataGridView1.Rows[j].Cells[3].Value = "Hombre";
                    }


                    rndD = listDemanda[j];
                    //dataGridView1.Rows[j].Cells[4].Value = listDemanda[j];

                    if (sexo == "Mujer")
                    {
                        if (rndD < (float)7 / 10)
                        {

                            compra = "Si";
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
                                if (rndG >= (float)2 / 10 && rndG < (float)8 / 10)
                                {
                                    costo = "10";
                                    //dataGridView1.Rows[j].Cells[7].Value = "10";

                                    acumulador = acumulador + 10;
                                    //dataGridView1.Rows[j].Cells[8].Value = acumulador;

                                }
                                else
                                {
                                    if (rndG >= (float)8 / 10 && rndG < (float)19 / 20)
                                    {
                                        costo = "15";
                                        //dataGridView1.Rows[j].Cells[7].Value = "15";

                                        acumulador = acumulador + 15;
                                        //dataGridView1.Rows[j].Cells[8].Value = acumulador;
                                    }
                                    else
                                    {
                                        costo = "25";
                                        //dataGridView1.Rows[j].Cells[7].Value = "25";

                                        acumulador = acumulador + 25;

                                        //ver
                                        //dataGridView1.Rows[j].Cells[8].Value = acumulador;
                                    }
                                }
                            }



                        }
                        else
                        {
                            compra = "No";
                            //rndD = 0;
                            rndG = 0;
                            costo = "0";
                            //dataGridView1.Rows[j].Cells[5].Value = "No";
                            //dataGridView1.Rows[j].Cells[7].Value = "0";
                            //dataGridView1.Rows[j].Cells[8].Value = acumulador;
                        }
                    }
                    else
                    {
                        if (rndD < (float)2 / 5)
                        {
                            compra = "Si";
                            //dataGridView1.Rows[j].Cells[5].Value = "Si";

                            rndG = ListGasto[j];
                            //dataGridView1.Rows[j].Cells[6].Value = ListGasto[j];

                            if (rndG < (float)2 / 40)
                            {
                                costo = "5";
                                //dataGridView1.Rows[j].Cells[7].Value = "5";

                                acumulador = acumulador + 5;

                                //dataGridView1.Rows[j].Cells[8].Value = acumulador;
                            }
                            else
                            {
                                if (rndG >= (float)2 / 40 && rndG < (float)1 / 4)
                                {
                                    costo = "10";
                                    //dataGridView1.Rows[j].Cells[7].Value = "10";

                                    acumulador = acumulador + 10;
                                    //dataGridView1.Rows[j].Cells[8].Value = acumulador;

                                }
                                else
                                {
                                    if (rndG >= (float)1 / 4 && rndG < (float)3 / 5)
                                    {
                                        costo = "15";
                                        //dataGridView1.Rows[j].Cells[7].Value = "15";

                                        acumulador = acumulador + 15;
                                        //dataGridView1.Rows[j].Cells[8].Value = acumulador;
                                    }
                                    else
                                    {
                                        costo = "25";
                                        //dataGridView1.Rows[j].Cells[7].Value = "25";

                                        acumulador = acumulador + 25;

                                        //dataGridView1.Rows[j].Cells[8].Value = acumulador;
                                    }
                                }
                            }

                        }
                        else
                        {
                            compra = "No";
                            rndG = 0;
                            costo = "0";
                            //dataGridView1.Rows[j].Cells[5].Value = "No";
                            //dataGridView1.Rows[j].Cells[7].Value = "0";
                            //dataGridView1.Rows[j].Cells[8].Value = acumulador;
                        }
                    }
                }




            }


            for (int h = 0; h < 1; h++)
            {

                dataGridView1.Rows.Add(1);
                dataGridView1.Rows[h].DefaultCellStyle.BackColor = Color.Yellow;

                dataGridView1.Rows[h].Cells[0].Value = rndA;
                dataGridView1.Rows[h].Cells[1].Value = atiende;

                if (rndQ == 0)
                {
                    dataGridView1.Rows[h].Cells[2].Value = "";
                }
                else
                {
                    dataGridView1.Rows[h].Cells[2].Value = rndQ;
                }
                dataGridView1.Rows[h].Cells[3].Value = sexo;

                if (rndD == 0)
                {
                    dataGridView1.Rows[h].Cells[4].Value = "";
                }
                else
                {
                    dataGridView1.Rows[h].Cells[4].Value = rndD;
                }             
                dataGridView1.Rows[h].Cells[5].Value = compra;

                if (rndG == 0)
                {
                    dataGridView1.Rows[h].Cells[6].Value = "";
                }
                else
                {
                    dataGridView1.Rows[h].Cells[6].Value = rndG;
                }
                dataGridView1.Rows[h].Cells[7].Value = costo;

                dataGridView1.Rows[h].Cells[8].Value = acumulador;
                ingresoPorHoraCC = (float)(dataGridView1.Rows[h].Cells[9].Value = acumulador / n);

            }




        }

        private void btnConclusion_Click(object sender, EventArgs e)
        {

            float porcentaje;
            if (txtN.Text == "")
            {
                porcentaje = 1;
            }
            else
            {
                porcentaje = (100 - float.Parse(txtN.Text)) / 100;
            }

            
            float ingresoNeto = ingresoPorHoraCC  *   porcentaje;

            if (ingresoNeto > ingresoPorHora)
            {
                MessageBox.Show($"Ingreso por hora sin Callcenter  : {(Math.Truncate(ingresoPorHora*100))/100} $\n" +
                    $"Ingreso por hora con Callcenter : {(Math.Truncate(ingresoPorHoraCC*100)/100)} $\n\n" +
                    $"Ingreso por hora con Callcenter menos la comisión : {Math.Truncate(ingresoNeto*100)/100} $\n\n" +
                    $"Se recomienda contratar el Callcenter, puesto que sus ingresos son mayores.");
            }
            else
            {
                MessageBox.Show($"Ingreso por hora sin Callcenter  : {(Math.Truncate(ingresoPorHora * 100)) / 100} $\n" +
                    $"Ingreso por hora con Callcenter : {(Math.Truncate(ingresoPorHoraCC * 100) / 100)} $\n\n" +
                    $"Ingreso por hora con Callcenter menos la comisión : {Math.Truncate(ingresoNeto * 100) / 100} $\n\n" +
                    $"Se recomienda NO contratar el Callcenter, puesto que sus ingresos son menores.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
