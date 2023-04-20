using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimTP2Q.Lógica
{
    public class Poisson
    {
        NumerosAleatorios oNA = new NumerosAleatorios();
        public List<float> GenerarNumerosDP(int lambda, int n)
        {
            List<float> list = oNA.GenerarNumeros(n);

            List<float> listDP = new List<float>();

            float A = (float)Math.Exp(-lambda);

            for (int i = 0; i < n; i++)
            {
                double P = 1;
                int X = -1;

                do
                {
                    double U = list[i];
                    P *= U;
                    X += 1;
                } while (P >= A);

                listDP.Add(X);
            }

            return listDP;
        }

        public (float, List<float>) PruebaChiP(List<float> listaSinR, List<float> list, float lambda, int n, DataGridView dataGridViewPoisson)
        {

            float acumulador = 0;

            for (int i = 0; i < listaSinR.Count; i++)
            {


                dataGridViewPoisson.Rows.Add(1);
                int desde = ((int)(dataGridViewPoisson.Rows[i].Cells[0].Value = (int)listaSinR[i]));

                int fo = (int)(dataGridViewPoisson.Rows[i].Cells[1].Value = frecuenciaObservada(list, desde));

                double fe = (double)(dataGridViewPoisson.Rows[i].Cells[2].Value = frecuenciaEsperada(lambda, desde, n));

                float c = ((float)(dataGridViewPoisson.Rows[i].Cells[3].Value = (float)(Math.Pow((fo - fe), 2) / fe)));
                acumulador += c;
                float ca = ((float)(dataGridViewPoisson.Rows[i].Cells[4].Value = acumulador));

               
            }

            return (acumulador, listaSinR);
        }

        

        public (List<int>, List<float>) TablaP(int n, float lamb, List<float> listaSinR, DataGridView dgvP, List<float> list)
        {

            int tamañoN = n;
            float min = listaSinR.Min();
            float max = listaSinR.Max();

            float lambda = listaSinR.Sum() / n;

            List<int> grafico = new List<int>();
            List<float> intervalos = new List<float>();

            for (int i = 0; i < listaSinR.Count; i++)
            {
                dgvP.Rows.Add(1);
                int valor = ((int)(dgvP.Rows[i].Cells[0].Value = (int)listaSinR[i]));
                int fo = (int)(dgvP.Rows[i].Cells[1].Value = frecuenciaObservada(list, valor));
                float p = (float)(dgvP.Rows[i].Cells[2].Value = ((float)Math.Pow(lambda, valor) * ((float)Math.Exp(-lambda)) / (float)Factorial(valor)));
                float fe = (float)(dgvP.Rows[i].Cells[3].Value = p * tamañoN);
                grafico.Add(fo);
                intervalos.Add(valor);
            }

            return (grafico, intervalos);
        }

        public int frecuenciaObservada(List<float> lista, int desde)
        {
            int fo = 0;

            for (int i = 0; i < lista.Count; i++)
            {
                if (desde == lista[i])
                {

                    fo += 1;
                }

            }

            return fo;
        }

        public double frecuenciaEsperada(float lambda, int desde, int n)
        {
            double pe = (double)(((Math.Pow(lambda, desde)) * (Math.Exp(-lambda))) / (Factorial(desde)));

            double fe = pe * n;
            return Math.Round(fe);

        }

        public static double Factorial(int numero)
        {
            double factorial = 1;
            for (int i = 1; i <= numero; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
