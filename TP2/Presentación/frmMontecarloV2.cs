using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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

        float ingresoPorHora;

        List<float> ingresos = new List<float>();

        int sumaLLamadas = 0;

        int hora = 0;

        private void btnSimular_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);
            float media = float.Parse(txtME.Text);
            float desviacion;
            if (txtDE.Text == "")
            {
                desviacion = 0;
            }
            else
            {
                desviacion  = float.Parse(txtDE.Text);
            }

            //List<float> listNA = obNA.GenerarNumeros(n);
            (List<float> listRnd, List<float> listDN) = obN.GenerarNumerosDENMontecarlo(desviacion, media, n / 2);

            List<int> listaLlamadas = new List<int>();

            for (int i = 0; i < n; i++)

            {

                dgvMontecarlo.Rows.Add(1);

                dgvMontecarlo.Rows[i].Cells[i * (i - i)].Value = i + 1;
                dgvMontecarlo.Rows[i].Cells[(i * (i - i)) + (1 / (1 + 0 * i))].Value = Math.Truncate(listRnd[i] * 100) / 100;

                double cantidadLLamadas = ((double)(dgvMontecarlo.Rows[i].Cells[(i * (i - i)) + (2 / (1 + 0 * i))].Value = Math.Truncate(listDN[i])));
                listaLlamadas.Add((int)Math.Truncate(cantidadLLamadas));


            }

            sumaLLamadas = listaLlamadas.Sum();


            float acumulador = 0;

            float rndA = 0;
            string atiende = "";

            float rndQ = 0;
            string sexo = "";

            float rndD = 0;
            string compra = "";

            float rndG = 0;
            string costo = "";

            List<float> listAtencion = obNA.GenerarNumeros(sumaLLamadas);
            List<float> listQuien = obNA.GenerarNumeros(sumaLLamadas);
            List<float> listDemanda = obNA.GenerarNumeros(sumaLLamadas);
            List<float> ListGasto = obNA.GenerarNumeros(sumaLLamadas);


            /////////////////////////////////////////////////////////////

            //Controls.Add(dataGridView2);
            int rowIndex = 0;
            //DataGridView dataGridView2 = new DataGridView();

            DataTable dt = new DataTable();
            dt.Columns.Add("Hora", typeof(int));
            dt.Columns.Add("Llamada", typeof(int));
            dt.Columns.Add("Rnd atención", typeof(float));
            dt.Columns.Add("¿Atiende?", typeof(string));
            dt.Columns.Add("Rnd quien", typeof(float));
            dt.Columns.Add("¿Quién?", typeof(string));
            dt.Columns.Add("Rnd compra", typeof(float));
            dt.Columns.Add("¿Compra?", typeof(string));
            dt.Columns.Add("Rnd gasto", typeof(float));
            dt.Columns.Add("Gasto en la rifa", typeof(string));
            dt.Columns.Add("Ingreso AC", typeof(float));
            dt.Columns.Add("Ingreso por hora", typeof(float));
            

            for (int i = 0; i < listaLlamadas.Count; i++)
            {

                int numero = listaLlamadas[i];

                for (int j = 0; j < numero; j++)
                {

                    DataRow newRow = dt.NewRow();

                    //DataGridViewRow row = new DataGridViewRow();
                    //row.CreateCells(dataGridView2);

                    hora = i + 1;
                    

                    //row.Cells[0].Value = hora;
                    newRow["Hora"] = hora;

                    //row.Cells[1].Value = rowIndex + 1;
                    newRow["Llamada"] = rowIndex + 1;



                    //dataGridView1.Rows.Add(1);

                    rndA = listAtencion[rowIndex];
                    newRow["Rnd atención"] = rndA;

                    //row.Cells[2].Value = rndA;


                    //row.Cells[2].Value = listAtencion[rowIndex];

                    if (rndA < (float)3 / 20)
                    {
                        atiende = "No";
                        newRow["¿Atiende?"] = atiende;

                        //row.Cells[3].Value = "No";
                        

                        //row.Cells[9].Value = "0";
                        newRow["Gasto en la rifa"] = "0";

                        //row.Cells[10].Value = acumulador;
                        newRow["Ingreso AC"] = acumulador;

                        newRow["Ingreso por hora"] = acumulador / n;
                        dt.Rows.Add(newRow);

                        //dataGridView2.Rows.Add(row);
                        rowIndex++;

                    }
                    else
                    {
                        atiende = "Si";
                        newRow["¿Atiende?"] = atiende;

                        //row.Cells[3].Value = "Si";

                        rndQ = listQuien[rowIndex];
                        newRow["Rnd quien"] = rndQ;

                        //row.Cells[4].Value = listQuien[rowIndex];
                        

                        if (rndQ < (float)4 / 5)
                        {

                            sexo = "Mujer";

                            //row.Cells[5].Value = "Mujer";
                            newRow["¿Quién?"] = sexo;
                        }
                        else
                        {
                            sexo = "Hombre";

                            //row.Cells[5].Value = "Hombre";
                            newRow["¿Quién?"] = sexo;
                        }




                        rndD = listDemanda[rowIndex];
                        //row.Cells[6].Value = listDemanda[rowIndex];
                        newRow["Rnd compra"] = rndD;

                        if (sexo == "Mujer")
                        {
                            if (rndD < (float)7 / 10)
                            {

                                compra = "Si";

                                //row.Cells[7].Value = "Si";
                                newRow["¿Compra?"] = compra;

                                rndG = ListGasto[rowIndex];

                                //row.Cells[8].Value = ListGasto[rowIndex];
                                newRow["Rnd gasto"] = rndG;

                                if (rndG < (float)2 / 10)
                                {

                                    costo = "5";

                                    //row.Cells[9].Value = "5";
                                    newRow["Gasto en la rifa"] = costo;

                                    acumulador = acumulador + 5;
                                    newRow["Ingreso AC"] = acumulador;

                                    // ver
                                    //row.Cells[10].Value = acumulador;

                                    newRow["Ingreso por hora"] = acumulador / n;
                                    dt.Rows.Add(newRow);

                                    //dataGridView2.Rows.Add(row);
                                    rowIndex++;

                                }
                                else
                                {
                                    if (rndG >= (float)2 / 10 && rndG < (float)8 / 10)
                                    {
                                        costo = "10";

                                        //row.Cells[9].Value = "10";
                                        newRow["Gasto en la rifa"] = costo;

                                        acumulador = acumulador + 10;
                                        newRow["Ingreso AC"] = acumulador;

                                        //row.Cells[10].Value = acumulador;

                                        newRow["Ingreso por hora"] = acumulador / n;
                                        dt.Rows.Add(newRow);

                                        //dataGridView2.Rows.Add(row);
                                        rowIndex++;

                                    }
                                    else
                                    {
                                        if (rndG >= (float)8 / 10 && rndG < (float)19 / 20)
                                        {
                                            costo = "15";

                                            //row.Cells[9].Value = "15";
                                            newRow["Gasto en la rifa"] = costo;

                                            acumulador = acumulador + 15;
                                            newRow["Ingreso AC"] = acumulador;

                                            //row.Cells[10].Value = acumulador;

                                            newRow["Ingreso por hora"] = acumulador / n;
                                            dt.Rows.Add(newRow);

                                            //dataGridView2.Rows.Add(row);
                                            rowIndex++;
                                        }
                                        else
                                        {
                                            costo = "25";

                                            //row.Cells[9].Value = "25";
                                            newRow["Gasto en la rifa"] = costo;

                                            acumulador = acumulador + 25;
                                            newRow["Ingreso AC"] = acumulador;

                                            //ver
                                            //row.Cells[10].Value = acumulador;

                                            newRow["Ingreso por hora"] = acumulador / n;
                                            dt.Rows.Add(newRow);

                                            //dataGridView2.Rows.Add(row);
                                            rowIndex++;
                                        }
                                    }
                                }



                            }
                            else
                            {
                                compra = "No";

                                //row.Cells[7].Value = "No";
                                newRow["¿Compra?"] = compra;


                                //row.Cells[9].Value = "0";
                                newRow["Gasto en la rifa"] = "0";

                                //row.Cells[10].Value = acumulador;
                                newRow["Ingreso AC"] = acumulador;

                                newRow["Ingreso por hora"] = acumulador / n;
                                dt.Rows.Add(newRow);

                                //dataGridView2.Rows.Add(row);
                                rowIndex++;
                            }
                        }
                        else
                        {
                            if (rndD < (float)2 / 5)
                            {
                                compra = "Si";

                                //row.Cells[7].Value = "Si";
                                newRow["¿Compra?"] = compra;

                                rndG = ListGasto[rowIndex];
                                newRow["Rnd gasto"] = rndG;

                                //row.Cells[8].Value = ListGasto[rowIndex];

                                if (rndG < (float)2 / 40)
                                {
                                    costo = "5";

                                    //row.Cells[9].Value = "5";
                                    newRow["Gasto en la rifa"] = costo;

                                    acumulador = acumulador + 5;
                                    newRow["Ingreso AC"] = acumulador;

                                    //row.Cells[10].Value = acumulador;

                                    newRow["Ingreso por hora"] = acumulador / n;
                                    dt.Rows.Add(newRow);

                                    //dataGridView2.Rows.Add(row);
                                    rowIndex++;
                                }
                                else
                                {
                                    if (rndG >= (float)2 / 40 && rndG < (float)1 / 4)
                                    {
                                        costo = "10";

                                        //row.Cells[9].Value = "10";
                                        newRow["Gasto en la rifa"] = costo;

                                        acumulador = acumulador + 10;
                                        newRow["Ingreso AC"] = acumulador;

                                        //row.Cells[10].Value = acumulador;

                                        newRow["Ingreso por hora"] = acumulador / n;
                                        dt.Rows.Add(newRow);

                                        //dataGridView2.Rows.Add(row);
                                        rowIndex++;

                                    }
                                    else
                                    {
                                        if (rndG >= (float)1 / 4 && rndG < (float)3 / 5)
                                        {
                                            costo = "15";

                                            //row.Cells[9].Value = "15";
                                            newRow["Gasto en la rifa"] = costo;

                                            acumulador = acumulador + 15;
                                            newRow["Ingreso AC"] = acumulador;

                                            //row.Cells[10].Value = acumulador;

                                            newRow["Ingreso por hora"] = acumulador / n;
                                            dt.Rows.Add(newRow);

                                            //dataGridView2.Rows.Add(row);
                                            rowIndex++;
                                        }
                                        else
                                        {
                                            costo = "25";

                                            //row.Cells[9].Value = "25";
                                            newRow["Gasto en la rifa"] = costo;

                                            acumulador = acumulador + 25;
                                            newRow["Ingreso AC"] = acumulador;

                                            //row.Cells[10].Value = acumulador;

                                            newRow["Ingreso por hora"] = acumulador / n;
                                            dt.Rows.Add(newRow);

                                            //dataGridView2.Rows.Add(row);
                                            rowIndex++;
                                        }
                                    }
                                }

                            }
                            else
                            {
                                compra = "No";

                                //row.Cells[7].Value = "No";
                                newRow["¿Compra?"] = compra;

                                //row.Cells[9].Value = "0";
                                newRow["Gasto en la rifa"] = "0";

                                //row.Cells[10].Value = acumulador;
                                newRow["Ingreso AC"] = acumulador;

                                newRow["Ingreso por hora"] = acumulador / n;
                                dt.Rows.Add(newRow);

                                //dataGridView2.Rows.Add(row);
                                rowIndex++;
                            }
                        }
                    }

                }
            }


            DataRow fila = dt.NewRow();

            fila["Hora"] = hora;
            fila["Llamada"] = rowIndex;
            fila["Rnd atención"] = rndA;
            fila["¿Atiende?"] = atiende;
            fila["Rnd quien"] = rndQ;
            fila["¿Quién?"] = sexo;
            fila["Rnd compra"] = rndD;
            fila["¿Compra?"] = compra;
            fila["Rnd gasto"] = rndG;
            fila["Gasto en la rifa"] = costo;
            fila["Ingreso AC"] = acumulador;
            fila["Ingreso por hora"] = acumulador/n;

            dt.Rows.Add(fila);

            foreach (DataRow fila1 in dt.Rows)
            {
                ingresos.Add((float)fila1["Ingreso por hora"]);
            }
            //////////////////////////////////////////////////////////


            //dgvFinal.DataSource = dt;

            //DataTable copia = dt();


            int desde;
            if (txtDesde.Text == "")
            {
                desde = 0;
            }
            else
            {
                desde = int.Parse(txtDesde.Text);
            }

            int hasta;
            if (txtHasta.Text == "")
            {
                hasta = 0;
            }
            else
            {
                hasta = int.Parse(txtHasta.Text);
            }

            if (desde == 0 && hasta == 0)
            {
                DataTable last = dt.Clone();
                last.ImportRow(dt.Rows[dt.Rows.Count - 1]);

                dgvFinal.DataSource = last;
                dgvFinal.Rows[0].DefaultCellStyle.BackColor = Color.Yellow;
            }
            else
            {
                DataRow[] filasIntervalo = dt.Select("Hora >= " + desde + "and Hora <= " + hasta);
                DataTable tablafinal = dt.Clone();
                foreach (DataRow fila2 in filasIntervalo)
                {
                    tablafinal.ImportRow(fila2);
                }

                DataRow fila3 = tablafinal.NewRow();

                fila3["Hora"] = hora;
                fila3["Llamada"] = rowIndex;
                fila3["Rnd atención"] = rndA;
                fila3["¿Atiende?"] = atiende;
                fila3["Rnd quien"] = rndQ;
                fila3["¿Quién?"] = sexo;
                fila3["Rnd compra"] = rndD;
                fila3["¿Compra?"] = compra;
                fila3["Gasto en la rifa"] = costo;
                fila3["Ingreso AC"] = acumulador;
                fila3["Ingreso por hora"] = acumulador / n;

                tablafinal.Rows.Add(fila3);
                
                dgvFinal.DataSource = tablafinal;
                dgvFinal.Rows[tablafinal.Rows.Count-1].DefaultCellStyle.BackColor = Color.Yellow;
            }
            


            //for (int h = 0; h < 1; h++)
            //{


            //    dgvFinal.Rows.Add(1);
            //    dgvFinal.Rows[sumaLLamadas].DefaultCellStyle.BackColor = Color.Yellow;

            //    dgvFinal.Rows[sumaLLamadas].Cells[2].Value = rndA;
            //    dgvFinal.Rows[sumaLLamadas].Cells[3].Value = atiende;

            //    dgvFinal.Rows[sumaLLamadas].Cells[4].Value = rndQ;
            //    dgvFinal.Rows[sumaLLamadas].Cells[5].Value = sexo;

            //    dgvFinal.Rows[sumaLLamadas].Cells[6].Value = rndD;
            //    dgvFinal.Rows[sumaLLamadas].Cells[7].Value = compra;

            //    dgvFinal.Rows[sumaLLamadas].Cells[8].Value = rndG;
            //    dgvFinal.Rows[sumaLLamadas].Cells[9].Value = costo;

            //    dgvFinal.Rows[sumaLLamadas].Cells[10].Value = acumulador;
            //    ingresoPorHora = (float)(dgvFinal.Rows[sumaLLamadas].Cells[11].Value = acumulador / n);

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

        private void btnComparar_Click(object sender, EventArgs e)
        {

            ingresoPorHora = ingresos[sumaLLamadas - 1];

            int n = int.Parse(txtN.Text);
            frmCallcenter frmCc = new frmCallcenter(n, ingresoPorHora);
            frmCc.ShowDialog();
            frmCc.Dispose();
        }
    }
}
