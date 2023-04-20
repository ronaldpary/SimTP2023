using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimTP2Q.Lógica
{
    public class Exponencial
    {
        NumerosAleatorios oNA = new NumerosAleatorios();
        public List<float> GenerarNumerosDEN(float lambda, int n)
        {
            List<float> list = oNA.GenerarNumeros(n);

            List<float> listDEN = new List<float>();

            for (int i = 0; i < n; i++)
            {
                float x = (float)((-1/lambda) * Math.Log(1 - list[i]));
                listDEN.Add(x);
            }

            return listDEN;
        }

        public (List<int>, List<float>) TablaExp(int n, int cantInt, DataGridView dgvTabla, List<float> list, int lambda)
        {

            float precision = (float)1 / 100;
            int tamañoN = n;
            float min = list.Min();
            float max = list.Max();

            float diferencia = max - min;

            float interv = (float)Math.Sqrt(tamañoN);
            int intervRedondeado = (int)Math.Truncate(interv);

            float ancho = (diferencia / (float)intervRedondeado) + precision;

            float media = list.Sum() / tamañoN;
            //float lambda = 

            List<int> grafico = new List<int>();
            List<float> intervalos = new List<float>();

            for (int i = 0; i < intervRedondeado; i++)
            {
                dgvTabla.Rows.Add(1);
                float desde = ((float)(dgvTabla.Rows[i].Cells[0].Value = min + (i * (ancho))));
                float hasta = ((float)(dgvTabla.Rows[i].Cells[1].Value = desde + (ancho - (precision/10) )));
                float marca = ((float)(dgvTabla.Rows[i].Cells[2].Value = (hasta - desde ) / 2));
                int fo = ((int)(dgvTabla.Rows[i].Cells[3].Value = frecuenciaObservada(list, desde, hasta)));
                float pcmc = ((float)(dgvTabla.Rows[i].Cells[4].Value = lambda * (float)Math.Exp(-lambda*marca) * hasta-desde));
                float pcpac = ((float)(dgvTabla.Rows[i].Cells[5].Value = (1- (float)Math.Exp(-lambda*hasta) - (1-(float)Math.Exp(-lambda*desde)) )));
                float fe = ((float)(dgvTabla.Rows[i].Cells[6].Value = pcpac * tamañoN));

                grafico.Add(fo);
                intervalos.Add(hasta);
            }

            return (grafico, intervalos);
        }

        public float PruebaChiCuadradoEx(int n, int cantInt, DataGridView dataGridView1, List<float> list, int lambda)
        {
            float calculado = 0;

            float min = list.Min();
            float max = list.Max();

            

            float interv = (float)Math.Sqrt(n);
            int intervRedondeado = (int)Math.Truncate(interv);

            float diferencia = max - min;
            float ancho = diferencia / (float)intervRedondeado;

            float acumulador = 0;

            int contFo = 0;

            for (int i = 0; i < list.Count; i++)
            {

                dataGridView1.Rows.Add(1);
                float desde = ((float)(dataGridView1.Rows[i].Cells[0].Value = min + (i * (ancho))));
                float hasta = ((float)(dataGridView1.Rows[i].Cells[1].Value = desde + ancho));
                int fo = ((int)(dataGridView1.Rows[i].Cells[2].Value = frecuenciaObservada(list, desde, hasta)));
                if (fo >= 5)
                {
                    //float pcpac = (1 - (float)Math.Exp(-lambda * hasta) - (1 - (float)Math.Exp(-lambda * desde)))));

                    //float fe = ((float)(dataGridView1.Rows[i].Cells[6].Value = pcpac * tamañoN));

                    ////float fe = ((float)(dataGridView1.Rows[i].Cells[3].Value = (float)n / intervRedondeado));
                    //float c = ((float)(dataGridView1.Rows[i].Cells[4].Value = (float)(Math.Pow((fe - (float)fo), 2) / fe)));
                    //acumulador += c;
                    //float ca = ((float)(dataGridView1.Rows[i].Cells[5].Value = acumulador));
                    //calculado = ca;
                }
                else
                {
                    contFo += fo;
                }
                
                
            }

            return calculado;
        }

        public float PruebaKS_Ex(int n, int cantInt, DataGridView dgvKS, List<float> list, int lambda)
        {
            float precision = (float)1 / 100;
            int tamañoN = n;
            float min = list.Min();
            float max = list.Max();

            float diferencia = max - min;

            float interv = (float)Math.Sqrt(tamañoN);
            int intervRedondeado = (int)Math.Truncate(interv);

            float ancho = (diferencia / (float)intervRedondeado) + precision;

            float media = list.Sum() / tamañoN;
            //float lambda = 

            float calculado = 0;
            float acuPo = 0;
            float acuPe = 0;
            //float buscarMax = 0;
            List<float> maximos = new List<float>();

            for (int i = 0; i < intervRedondeado; i++)
            {
                dgvKS.Rows.Add(1);
                float desde = ((float)(dgvKS.Rows[i].Cells[0].Value = min + (i * (ancho))));
                float hasta = ((float)(dgvKS.Rows[i].Cells[1].Value = desde + (ancho - (precision / 10))));
                //float marca = ((float)(dgvKS.Rows[i].Cells[2].Value = (hasta - desde) / 2));
                int fo = ((int)(dgvKS.Rows[i].Cells[2].Value = frecuenciaObservada(list, desde, hasta)));

                float pcpac = (1 - (float)Math.Exp(-lambda * hasta) - (1 - (float)Math.Exp(-lambda * desde)));

                float fe = ((float)(dgvKS.Rows[i].Cells[3].Value = pcpac * tamañoN));
                float po = ((float)(dgvKS.Rows[i].Cells[4].Value = fo / (float)tamañoN));
                float pe = ((float)(dgvKS.Rows[i].Cells[5].Value = (1 - (float)Math.Exp(-lambda * hasta) - (1 - (float)Math.Exp(-lambda * desde)))));
                float poac = ((float)(dgvKS.Rows[i].Cells[6].Value = acuPo += po));
                float peac = ((float)(dgvKS.Rows[i].Cells[7].Value = acuPe += pe));
                float poMenospe = ((float)(dgvKS.Rows[i].Cells[8].Value = Math.Abs(poac - peac)));

                maximos.Add(poMenospe);

                float maximo = ((float)(dgvKS.Rows[i].Cells[9].Value = maximos.Max()));
                maximos.Add(maximo);
                maximos.Remove(poMenospe);

                //if (buscarMax > poMenospe)
                //{
                //    maximo = buscarMax;
                //}
            //float pcmc = ((float)(dgvKS.Rows[i].Cells[4].Value = lambda * (float)Math.Exp(-lambda * marca) * hasta - desde));

        }

            return calculado;
        }

        public int frecuenciaObservada(List<float> list, float desde, float hasta)
        {
            int fo = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] >= desde & list[i] <= hasta)
                    fo += 1;
            }
            return fo;
        }
    }

    
}
