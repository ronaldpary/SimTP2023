using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimTP2Q.Lógica
{
    public class Normal
    {
        //NumerosAleatorios oNA = new NumerosAleatorios();
        public List<float> GenerarNumerosDEN(int desviacion, int media, int n)
        {

            List<float> listDN = new List<float>();
            Random generador = new Random();

            for (int i = 0; i < n; i++)
            {
                //List<float> list = oNA.GenerarNumeros(2);
                float rnd1 = (float)generador.NextDouble();
                float rnd2 = (float)generador.NextDouble();
                float x1 = ((float)Math.Sqrt(-2 * Math.Log(rnd1)) * (float)Math.Cos(2 * Math.PI * rnd2)) * desviacion + media;
                float x2 = ((float)Math.Sqrt(-2 * Math.Log(rnd1)) * (float)Math.Sin(2 * Math.PI * rnd2)) * desviacion + media;
                listDN.Add(x1);
                listDN.Add(x2);
            }

            return listDN;
        }

        public (List<int>, List<float>) TablaN(int n, float desviac, float med, DataGridView dgvTabla, List<float> list, int cantI)
        {

            float precision = (float)1 / 100;
            int tamañoN = n;
            float min = list.Min();
            float max = list.Max();

            float diferencia = max - min;

            float ancho = (diferencia / (float)cantI) + precision;

            float media = list.Sum() / tamañoN;
            float varianza = list.Sum() / (tamañoN - 1);
            float desviacion = (float)Math.Sqrt(varianza);

            List<int> grafico = new List<int>();
            List<float> intervalos = new List<float>();

            for (int i = 0; i < cantI; i++)
            {
                dgvTabla.Rows.Add(1);
                float desde = ((float)(dgvTabla.Rows[i].Cells[0].Value = min + (i * (ancho))));
                float hasta = ((float)(dgvTabla.Rows[i].Cells[1].Value = desde + (ancho - (precision / 10))));
                float marca = ((float)(dgvTabla.Rows[i].Cells[2].Value = (hasta + desde) / 2));
                int fo = ((int)(dgvTabla.Rows[i].Cells[3].Value = frecuenciaObservada(list, desde, hasta)));
                float p = ((float)(dgvTabla.Rows[i].Cells[4].Value = ((float)Math.Exp((float)(-1 / 2) * ((float)Math.Pow((marca - media) / desviacion, 2))) / (desviacion * ((float)Math.Sqrt(2 * ((float)Math.PI))) * (hasta - desde)))));
                float fe = ((float)(dgvTabla.Rows[i].Cells[5].Value = p * tamañoN));

                grafico.Add(fo);
                intervalos.Add(marca);
            }

            return (grafico, intervalos);

        }

        public float PruebaKS_N(int n, int cantInt, DataGridView dgvKS, List<float> list, float med, float desv)
        {
            float precision = (float)1 / 100;
            int tamañoN = n;
            float min = list.Min();
            float max = list.Max();

            float diferencia = max - min;

            //float interv = (float)Math.Sqrt(tamañoN);
            //int intervRedondeado = (int)Math.Truncate(interv);

            float ancho = (diferencia / (float)cantInt) + precision;

            float media = list.Sum() / tamañoN;
            float varianza = list.Sum() / (tamañoN - 1);
            float desviacion = (float)Math.Sqrt(varianza);

            float calculado = 0;
            float acuPo = 0;
            float acuPe = 0;
            //float buscarMax = 0;
            List<float> maximos = new List<float>();

            for (int i = 0; i < cantInt; i++)
            {
                dgvKS.Rows.Add(1);
                float desde = ((float)(dgvKS.Rows[i].Cells[0].Value = min + (i * (ancho))));
                float hasta = ((float)(dgvKS.Rows[i].Cells[1].Value = desde + (ancho - (precision / 10))));

                float marca = (hasta - desde) / 2;

                int fo = ((int)(dgvKS.Rows[i].Cells[2].Value = frecuenciaObservada(list, desde, hasta)));

                float p = ((float)Math.Exp((float)(-1 / 2) * ((float)Math.Pow((marca - media) / desviacion, 2))) / (desviacion * ((float)Math.Sqrt(2 * ((float)Math.PI))) * (hasta - desde)));

                float fe = ((float)(dgvKS.Rows[i].Cells[3].Value = p * tamañoN));
                float po = ((float)(dgvKS.Rows[i].Cells[4].Value = fo / (float)tamañoN));
                float pe = ((float)(dgvKS.Rows[i].Cells[5].Value = p));
                float poac = ((float)(dgvKS.Rows[i].Cells[6].Value = acuPo += po));
                float peac = ((float)(dgvKS.Rows[i].Cells[7].Value = acuPe += pe));
                float poMenospe = ((float)(dgvKS.Rows[i].Cells[8].Value = Math.Abs(poac - peac)));

                maximos.Add(poMenospe);

                float maximo = ((float)(dgvKS.Rows[i].Cells[9].Value = maximos.Max()));
                maximos.Add(maximo);
                maximos.Remove(poMenospe);
                calculado = maximos.Max();

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
