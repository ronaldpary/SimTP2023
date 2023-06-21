using System;
using System.CodeDom.Compiler;
using System.Collections;
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

        int simulaciones = 0;
        int desde = 0;
        int hasta = 0;

        Random rnd = new Random();

        //Variables
        int hora;
        int llamadas;

        double rnd_atencion;
        string atencion;

        double rnd_quien;
        string quien;

        double rnd_compra;
        string compra;

        double rnd_gasto;
        int gasto;

        int ingresoAC;
        double ingreso_hora;

        int sumaLlamadas = 0;
        int contador = 0;


        List<int> lista_de_LLamadas = new List<int>();

        private void btnSimular_Click(object sender, EventArgs e)
        {


            if (txtN.Text == "" || txtDE.Text == "" || txtME.Text == "" || txtDesde.Text == "")
            {
                MessageBox.Show("Complete todos los datos");
            }
            else
            {
                cargarPrimerTabla();

                desde = int.Parse(txtDesde.Text);
                simulaciones = sumaLlamadas;
                hasta = desde + 500;

                txtHasta.Text = Convert.ToString(hasta);
                textLlamada.Text = Convert.ToString(simulaciones+1);

                if (desde < simulaciones)
                {
                    for (int i = 0; i < lista_de_LLamadas.Count; i++)
                    {
                        int numero = lista_de_LLamadas[i];

                        for (int j = 0; j < numero; j++)
                        {

                            hora = i + 1;

                            contador = contador + 1;

                            if (contador >= desde && contador <= hasta)
                            {
                                simular();
                                cargarGrilla();
                            }
                            else
                            {
                                simular();
                                
                            }


                        }
                    }

                    if (contador==simulaciones)
                    {
                        simular();
                        cargarGrilla();
                    }

                    dataGridView1.Rows[501].DefaultCellStyle.BackColor = Color.Yellow;

                }
                else
                {
                    MessageBox.Show("Ingrese un desde menor al de la cantidad de llamadas");
                }
                
            }



        }

        private void cargarPrimerTabla()
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
                desviacion = float.Parse(txtDE.Text);
            }
            (List<float> listRnd, List<float> listDN) = obN.GenerarNumerosDENMontecarlo(desviacion, media, n / 2);


            // PROBLEMA ACA, AL MOSTRAR ESTOS DATOS

            //for (int i = 0; i < n; i++)
            //{
            //    dgvMontecarlo.Rows.Add(1);
            //    dgvMontecarlo.Rows[i].Cells[0].Value = i + 1;
            //    dgvMontecarlo.Rows[i].Cells[1].Value = Math.Truncate(listRnd[i] * 100) / 100;
            //    double cantidadLLamadas = ((double)(dgvMontecarlo.Rows[i].Cells[2].Value = Math.Truncate(listDN[i])));
            //    
            //}

            for (int i = 0; i < n; i++)
            {
                double cantidadLLamadas = Math.Truncate(listDN[i]);
                lista_de_LLamadas.Add((int)Math.Truncate(cantidadLLamadas));
            }

            sumaLlamadas = lista_de_LLamadas.Sum();


        }

        private void cargarGrilla()
        {
            
            dataGridView1.Rows.Add(hora, Convert.ToString(llamadas), rnd_atencion, atencion, rnd_quien, quien, rnd_compra, compra, rnd_gasto, gasto, ingresoAC, ingreso_hora);
            dataGridView1.Columns["ingresoHora"].DefaultCellStyle.Format = "N3";

        }

        private void simular()
        {
            llamadas++;
            rnd_atencion = rnd.NextDouble();
            atiende();
        }

        private void atiende()
        {
            //int n = int.Parse(txtN.Text);
            if (rnd_atencion < (float)3 / 20)
            {
                atencion = "No";

                rnd_quien = 0;
                quien = "";
                rnd_compra = 0;
                compra = "";
                rnd_gasto = 0;
                gasto = 0;

                ingresoAC = ingresoAC + 0;
                //ingreso_hora = ingresoAC / n;
            }
            else
            {
                atencion = "Si";
                rnd_quien = rnd.NextDouble();
                quienAtiende();
            }
        }

        private void quienAtiende()
        {
            if (rnd_quien < (float)4 / 5)
            {
                quien = "Mujer";
            }
            else
            {
                quien = "Hombre";
            }

            rnd_compra = rnd.NextDouble();
            compraRifa();
        }

        private void compraRifa()
        {
            //int n = int.Parse(txtN.Text);
            if (quien == "Mujer")
            {
                if (rnd_compra < (float)7 / 10)
                {
                    compra = "Si";
                    rnd_gasto = rnd.NextDouble();
                    gastoMujer();
                }
                else
                {
                    compra = "No";
                    rnd_gasto = 0;
                    gasto = 0;
                    ingresoAC = ingresoAC + 0;
                    //ingreso_hora = ingresoAC / n;
                }
            }
            else
            {
                if (rnd_compra < (float)2 / 5)
                {
                    compra = "Si";
                    rnd_gasto = rnd.NextDouble();
                    gastoHombre();
                }
                else
                {
                    compra = "No";
                    rnd_gasto = 0;
                    gasto = 0;
                    ingresoAC = ingresoAC + 0;
                    //ingreso_hora = ingresoAC / n;
                }
            }
        }

        private void gastoMujer()
        {
            //int n = int.Parse(txtN.Text);
            if (rnd_gasto < (float)2 / 10)
            {
                gasto = 5;
                ingresoAC = ingresoAC + gasto;
                //ingreso_hora = ingresoAC / n;
            }
            else
            {
                if (rnd_gasto >= (float)2 / 10 && rnd_gasto < (float)8 / 10)
                {
                    gasto = 10;
                    ingresoAC = ingresoAC + gasto;
                    //ingreso_hora = ingresoAC / n;
                }
                else
                {
                    if (rnd_gasto >= (float)8 / 10 && rnd_gasto < (float)19 / 20)
                    {
                        gasto = 15;
                        ingresoAC = ingresoAC + gasto;
                        //ingreso_hora = ingresoAC / n;
                    }
                    else
                    {
                        gasto = 25;
                        ingresoAC = ingresoAC + gasto;
                        //ingreso_hora = ingresoAC / n;
                    }
                }
            }
        }

        private void gastoHombre()
        {
            //int n = int.Parse(txtN.Text);
            if (rnd_gasto < (float)2 / 40)
            {
                gasto = 5;
                ingresoAC = ingresoAC + gasto;
                //ingreso_hora = ingresoAC / n;
            }
            else
            {
                if (rnd_gasto >= (float)2 / 40 && rnd_gasto < (float)1 / 4)
                {
                    gasto = 10;
                    ingresoAC = ingresoAC + gasto;
                    //ingreso_hora = ingresoAC / n;
                }
                else
                {
                    if (rnd_gasto >= (float)1 / 4 && rnd_gasto < (float)3 / 5)
                    {
                        gasto = 15;
                        ingresoAC = ingresoAC + gasto;
                        //ingreso_hora = ingresoAC / n;
                    }
                    else
                    {
                        gasto = 25;
                        ingresoAC = ingresoAC + gasto;
                        //ingreso_hora = ingresoAC / n;
                    }
                }
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void frmMontecarloV2_Load(object sender, EventArgs e)
        {

        }

        private void dgvVersion2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            //dgvCallCenter.Rows.Clear();
            ////dgvFinal.Rows.Clear();

            //int n = int.Parse(txtN.Text);
            //float media = float.Parse(txtMedia.Text);
            //float desviacion;
            //if (txtDesviacion.Text == "")
            //{
            //    desviacion = 0;
            //}
            //else
            //{
            //    desviacion = float.Parse(txtDesviacion.Text);
            //}

            //(List<float> listRnd, List<float> listDN) = obN.GenerarNumerosDENMontecarlo(desviacion, media, n);

            //List<int> listaLlamadas = new List<int>();

            //for (int i = 0; i < n; i++)

            //{

            //    dgvCallCenter.Rows.Add(1);

            //    dgvCallCenter.Rows[i].Cells[i * (i - i)].Value = i + 1;
            //    dgvCallCenter.Rows[i].Cells[(i * (i - i)) + (1 / (1 + 0 * i))].Value = Math.Truncate(listRnd[i] * 100) / 100;

            //    double cantidadLLamadas = ((double)(dgvCallCenter.Rows[i].Cells[(i * (i - i)) + (2 / (1 + 0 * i))].Value = Math.Truncate(listDN[i])));
            //    listaLlamadas.Add((int)Math.Truncate(cantidadLLamadas));
            //}

            //int sumaLLamadas = (int)listaLlamadas.Sum();


            //float acumulador = 0;
            ////float acumulador2 = 0;

            //float rndA = 0;
            //string atiende = "";

            //float rndQ = 0;
            //string sexo = "";

            //float rndD = 0;
            //string compra = "";

            //float rndG = 0;
            //string costo = "";

            //List<float> listAtencion = obNA.DesordenarNumeros(obNA.GenerarNumeros(sumaLLamadas));
            //List<float> listQuien = obNA.GenerarNumeros(sumaLLamadas);
            //List<float> listDemanda = obNA.DesordenarNumeros(obNA.GenerarNumeros(sumaLLamadas));
            //List<float> ListGasto = obNA.GenerarNumeros(sumaLLamadas);

            //int rowIndex = 0;

            //DataTable dt = new DataTable();
            //dt.Columns.Add("Hora", typeof(int));
            //dt.Columns.Add("Llamada", typeof(int));
            //dt.Columns.Add("Rnd atención", typeof(float));
            //dt.Columns.Add("¿Atiende?", typeof(string));
            //dt.Columns.Add("Rnd quien", typeof(float));
            //dt.Columns.Add("¿Quién?", typeof(string));
            //dt.Columns.Add("Rnd compra", typeof(float));
            //dt.Columns.Add("¿Compra?", typeof(string));
            //dt.Columns.Add("Rnd gasto", typeof(float));
            //dt.Columns.Add("Gasto en la rifa", typeof(string));
            //dt.Columns.Add("Ingreso AC", typeof(float));
            //dt.Columns.Add("Ingreso por hora", typeof(float));

            //for (int i = 0; i < listaLlamadas.Count; i++)
            //{

            //    int numero = listaLlamadas[i];

            //    for (int j = 0; j < numero; j++)
            //    {

            //        DataRow newRow = dt.NewRow();

            //        //DataGridViewRow row = new DataGridViewRow();
            //        //row.CreateCells(dataGridView2);

            //        horaCC = i + 1;


            //        //row.Cells[0].Value = hora;
            //        newRow["Hora"] = horaCC;

            //        //row.Cells[1].Value = rowIndex + 1;
            //        newRow["Llamada"] = rowIndex + 1;



            //        //dataGridView1.Rows.Add(1);

            //        rndA = listAtencion[rowIndex];
            //        newRow["Rnd atención"] = rndA;

            //        //row.Cells[2].Value = rndA;


            //        //row.Cells[2].Value = listAtencion[rowIndex];

            //        if (rndA < (float)3 / 20)
            //        {
            //            atiende = "No";
            //            newRow["¿Atiende?"] = atiende;

            //            //row.Cells[3].Value = "No";

            //            //newRow["Rnd quien"] = 0;


            //            //row.Cells[9].Value = "0";
            //            newRow["Gasto en la rifa"] = "0";

            //            //row.Cells[10].Value = acumulador;
            //            newRow["Ingreso AC"] = acumulador;

            //            //newRow["Ingreso por hora"] = acumulador / n;
            //            dt.Rows.Add(newRow);

            //            //dataGridView2.Rows.Add(row);
            //            rowIndex++;

            //        }
            //        else
            //        {
            //            atiende = "Si";
            //            newRow["¿Atiende?"] = atiende;

            //            //row.Cells[3].Value = "Si";

            //            rndQ = listQuien[rowIndex];
            //            newRow["Rnd quien"] = rndQ;

            //            //row.Cells[4].Value = listQuien[rowIndex];


            //            if (rndQ < (float)4 / 5)
            //            {

            //                sexo = "Mujer";

            //                //row.Cells[5].Value = "Mujer";
            //                newRow["¿Quién?"] = sexo;
            //            }
            //            else
            //            {
            //                sexo = "Hombre";

            //                //row.Cells[5].Value = "Hombre";
            //                newRow["¿Quién?"] = sexo;
            //            }




            //            rndD = listDemanda[rowIndex];
            //            //row.Cells[6].Value = listDemanda[rowIndex];
            //            newRow["Rnd compra"] = rndD;

            //            if (sexo == "Mujer")
            //            {
            //                if (rndD < (float)7 / 10)
            //                {

            //                    compra = "Si";

            //                    //row.Cells[7].Value = "Si";
            //                    newRow["¿Compra?"] = compra;

            //                    rndG = ListGasto[rowIndex];

            //                    //row.Cells[8].Value = ListGasto[rowIndex];
            //                    newRow["Rnd gasto"] = rndG;

            //                    if (rndG < (float)2 / 10)
            //                    {

            //                        costo = "5";

            //                        //row.Cells[9].Value = "5";
            //                        newRow["Gasto en la rifa"] = costo;

            //                        acumulador = acumulador + 5;
            //                        newRow["Ingreso AC"] = acumulador;

            //                        // ver
            //                        //row.Cells[10].Value = acumulador;

            //                        //newRow["Ingreso por hora"] = acumulador / n;
            //                        dt.Rows.Add(newRow);

            //                        //dataGridView2.Rows.Add(row);
            //                        rowIndex++;

            //                    }
            //                    else
            //                    {
            //                        if (rndG >= (float)2 / 10 && rndG < (float)8 / 10)
            //                        {
            //                            costo = "10";

            //                            //row.Cells[9].Value = "10";
            //                            newRow["Gasto en la rifa"] = costo;

            //                            acumulador = acumulador + 10;
            //                            newRow["Ingreso AC"] = acumulador;

            //                            //row.Cells[10].Value = acumulador;

            //                            //newRow["Ingreso por hora"] = acumulador / n;
            //                            dt.Rows.Add(newRow);

            //                            //dataGridView2.Rows.Add(row);
            //                            rowIndex++;

            //                        }
            //                        else
            //                        {
            //                            if (rndG >= (float)8 / 10 && rndG < (float)19 / 20)
            //                            {
            //                                costo = "15";

            //                                //row.Cells[9].Value = "15";
            //                                newRow["Gasto en la rifa"] = costo;

            //                                acumulador = acumulador + 15;
            //                                newRow["Ingreso AC"] = acumulador;

            //                                //row.Cells[10].Value = acumulador;

            //                                //newRow["Ingreso por hora"] = acumulador / n;
            //                                dt.Rows.Add(newRow);

            //                                //dataGridView2.Rows.Add(row);
            //                                rowIndex++;
            //                            }
            //                            else
            //                            {
            //                                costo = "25";

            //                                //row.Cells[9].Value = "25";
            //                                newRow["Gasto en la rifa"] = costo;

            //                                acumulador = acumulador + 25;
            //                                newRow["Ingreso AC"] = acumulador;

            //                                //ver
            //                                //row.Cells[10].Value = acumulador;

            //                                //newRow["Ingreso por hora"] = acumulador / n;
            //                                dt.Rows.Add(newRow);

            //                                //dataGridView2.Rows.Add(row);
            //                                rowIndex++;
            //                            }
            //                        }
            //                    }



            //                }
            //                else
            //                {
            //                    compra = "No";

            //                    //row.Cells[7].Value = "No";
            //                    newRow["¿Compra?"] = compra;


            //                    //row.Cells[9].Value = "0";
            //                    newRow["Gasto en la rifa"] = "0";

            //                    //row.Cells[10].Value = acumulador;
            //                    newRow["Ingreso AC"] = acumulador;

            //                    //newRow["Ingreso por hora"] = acumulador / n;
            //                    dt.Rows.Add(newRow);

            //                    //dataGridView2.Rows.Add(row);
            //                    rowIndex++;
            //                }
            //            }
            //            else
            //            {
            //                if (rndD < (float)2 / 5)
            //                {
            //                    compra = "Si";

            //                    //row.Cells[7].Value = "Si";
            //                    newRow["¿Compra?"] = compra;

            //                    rndG = ListGasto[rowIndex];
            //                    newRow["Rnd gasto"] = rndG;

            //                    //row.Cells[8].Value = ListGasto[rowIndex];

            //                    if (rndG < (float)2 / 40)
            //                    {
            //                        costo = "5";

            //                        //row.Cells[9].Value = "5";
            //                        newRow["Gasto en la rifa"] = costo;

            //                        acumulador = acumulador + 5;
            //                        newRow["Ingreso AC"] = acumulador;

            //                        //row.Cells[10].Value = acumulador;

            //                        //newRow["Ingreso por hora"] = acumulador / n;
            //                        dt.Rows.Add(newRow);

            //                        //dataGridView2.Rows.Add(row);
            //                        rowIndex++;
            //                    }
            //                    else
            //                    {
            //                        if (rndG >= (float)2 / 40 && rndG < (float)1 / 4)
            //                        {
            //                            costo = "10";

            //                            //row.Cells[9].Value = "10";
            //                            newRow["Gasto en la rifa"] = costo;

            //                            acumulador = acumulador + 10;
            //                            newRow["Ingreso AC"] = acumulador;

            //                            //row.Cells[10].Value = acumulador;

            //                            //newRow["Ingreso por hora"] = acumulador / n;
            //                            dt.Rows.Add(newRow);

            //                            //dataGridView2.Rows.Add(row);
            //                            rowIndex++;

            //                        }
            //                        else
            //                        {
            //                            if (rndG >= (float)1 / 4 && rndG < (float)3 / 5)
            //                            {
            //                                costo = "15";

            //                                //row.Cells[9].Value = "15";
            //                                newRow["Gasto en la rifa"] = costo;

            //                                acumulador = acumulador + 15;
            //                                newRow["Ingreso AC"] = acumulador;

            //                                //row.Cells[10].Value = acumulador;

            //                                //newRow["Ingreso por hora"] = acumulador / n;
            //                                dt.Rows.Add(newRow);

            //                                //dataGridView2.Rows.Add(row);
            //                                rowIndex++;
            //                            }
            //                            else
            //                            {
            //                                costo = "25";

            //                                //row.Cells[9].Value = "25";
            //                                newRow["Gasto en la rifa"] = costo;

            //                                acumulador = acumulador + 25;
            //                                newRow["Ingreso AC"] = acumulador;

            //                                //row.Cells[10].Value = acumulador;

            //                                //newRow["Ingreso por hora"] = acumulador / n;
            //                                dt.Rows.Add(newRow);

            //                                //dataGridView2.Rows.Add(row);
            //                                rowIndex++;
            //                            }
            //                        }
            //                    }

            //                }
            //                else
            //                {
            //                    compra = "No";

            //                    //row.Cells[7].Value = "No";
            //                    newRow["¿Compra?"] = compra;

            //                    //row.Cells[9].Value = "0";
            //                    newRow["Gasto en la rifa"] = "0";

            //                    //row.Cells[10].Value = acumulador;
            //                    newRow["Ingreso AC"] = acumulador;

            //                    //newRow["Ingreso por hora"] = acumulador / n;
            //                    dt.Rows.Add(newRow);

            //                    //dataGridView2.Rows.Add(row);
            //                    rowIndex++;
            //                }
            //            }
            //        }

            //    }
            //}

            //int desdeCC;
            //if (txtD.Text == "")
            //{
            //    desdeCC = 0;
            //}
            //else
            //{
            //    desdeCC = int.Parse(txtD.Text);
            //}

            //int hastaCC;
            //if (txtH.Text == "")
            //{
            //    hastaCC = 0;
            //}
            //else
            //{
            //    hastaCC = int.Parse(txtH.Text);
            //}

            //if (desdeCC == 0 && hastaCC == 0)
            //{
            //    DataTable last = dt.Clone();
            //    last.ImportRow(dt.Rows[dt.Rows.Count - 1]);

            //    ingresoPorHoraCC = (float)(last.Rows[last.Rows.Count - 1]["Ingreso por hora"] = (float)Math.Truncate((acumulador / n) * 100) / 100);

            //    dgvCC.DataSource = last;
            //    dgvCC.Rows[0].DefaultCellStyle.BackColor = Color.Yellow;
            //}
            //else
            //{
            //    DataRow[] filasIntervalo = dt.Select("Hora >= " + desdeCC + "and Hora <= " + hastaCC);
            //    DataTable tablafinal = dt.Clone();
            //    foreach (DataRow fila2 in filasIntervalo)
            //    {
            //        tablafinal.ImportRow(fila2);
            //    }

            //    DataRow fila3 = tablafinal.NewRow();

            //    fila3["Hora"] = horaCC;
            //    fila3["Llamada"] = rowIndex;
            //    fila3["Rnd atención"] = rndA;
            //    fila3["¿Atiende?"] = atiende;

            //    if (atiende == "No")
            //    {
            //        fila3["Gasto en la rifa"] = "0";
            //        fila3["Ingreso AC"] = acumulador;
            //        ingresoPorHoraCC = (float)(fila3["Ingreso por hora"] = (float)Math.Truncate(acumulador / n * 100) / 100);
            //    }
            //    else
            //    {
            //        fila3["Rnd quien"] = rndQ;
            //        fila3["¿Quién?"] = sexo;
            //        fila3["Rnd compra"] = rndD;
            //        fila3["¿Compra?"] = compra;

            //        if (compra == "No")
            //        {
            //            fila3["Gasto en la rifa"] = "0";
            //            fila3["Ingreso AC"] = acumulador;
            //            ingresoPorHoraCC = (float)(fila3["Ingreso por hora"] = (float)Math.Truncate(acumulador / n * 100) / 100);
            //        }
            //        else
            //        {
            //            fila3["Rnd gasto"] = rndG;
            //            fila3["Gasto en la rifa"] = costo;
            //            fila3["Ingreso AC"] = acumulador;
            //            ingresoPorHoraCC = (float)(fila3["Ingreso por hora"] = (float)Math.Truncate(acumulador / n * 100) / 100);
            //        }

            //    }



            //    tablafinal.Rows.Add(fila3);

            //    dgvCC.DataSource = tablafinal;
            //    dgvCC.Rows[tablafinal.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow;
            //}
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {

            //float porcentaje;
            //if (txtCom.Text == "")
            //{
            //    porcentaje = 1;
            //}
            //else
            //{
            //    porcentaje = (100 - float.Parse(txtCom.Text)) / 100;
            //}


            //float ingresoNeto = (float)ingresoPorHoraCC * porcentaje;

            //if (ingresoNeto > ingresoPorHora)
            //{
            //    MessageBox.Show($"Ingreso por hora sin Callcenter  : {(Math.Truncate(ingresoPorHora * 100)) / 100} $\n" +
            //        $"Ingreso por hora con Callcenter : {(Math.Truncate(ingresoPorHoraCC * 100) / 100)} $\n\n" +
            //        $"Ingreso por hora con Callcenter menos la comisión : {Math.Truncate(ingresoNeto * 100) / 100} $\n\n" +
            //        $"Se recomienda contratar el Callcenter, puesto que sus ingresos son mayores.");
            //}
            //else
            //{
            //    MessageBox.Show($"Ingreso por hora sin Callcenter  : {(Math.Truncate(ingresoPorHora * 100)) / 100} $\n" +
            //        $"Ingreso por hora con Callcenter : {(Math.Truncate(ingresoPorHoraCC * 100) / 100)} $\n\n" +
            //        $"Ingreso por hora con Callcenter menos la comisión : {Math.Truncate(ingresoNeto * 100) / 100} $\n\n" +
            //        $"Se recomienda NO contratar el Callcenter, puesto que sus ingresos son menores.");
            //}
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void dgvFinal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
