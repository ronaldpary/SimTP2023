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

                    //dataGridView1.Rows[501].DefaultCellStyle.BackColor = Color.Yellow;

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
            
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {

            
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void dgvFinal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
