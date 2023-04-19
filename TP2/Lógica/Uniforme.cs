using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SimTP2Q.Lógica
{
    public class Uniforme
    {

        NumerosAleatorios oNA = new NumerosAleatorios();
        public List<float> GenerarNumerosDU(int A, int B, int n)
        {
            List<float> list = oNA.GenerarNumeros(n);

            List<float> listDU = new List<float>();

            for (int i = 0; i < n; i++)
            {
                float x = A + (list[i]*(B-A));
                listDU.Add(x);
            }

            return listDU;
        }

        public (float, List<int>, List<float>) PruebaChiCuadrado(int n, int cantInt, DataGridView dataGridView1, List<float> list)
        {
            float calculado = 0;

            float min = list.Min();
            float max = list.Max();

            float diferencia = max - min;
            float ancho = diferencia / (float)cantInt;

            float acumulador = 0;

            List<int> grafico = new List<int>();
            List<float> intervalos = new List<float>();

            for (int i = 0; i < cantInt; i++)
            {  
                
                dataGridView1.Rows.Add(1);
                float desde = ((float)(dataGridView1.Rows[i].Cells[0].Value = min + (i * (ancho))));
                float hasta = ((float)(dataGridView1.Rows[i].Cells[1].Value = desde + ancho));
                int fo = ((int)(dataGridView1.Rows[i].Cells[2].Value = frecuenciaObservada(list, desde, hasta)));
                float fe = ((float)(dataGridView1.Rows[i].Cells[3].Value = (float)n / cantInt));
                float c = ((float)(dataGridView1.Rows[i].Cells[4].Value = (float)(Math.Pow((fe - (float)fo), 2) / fe)));
                acumulador += c;
                float ca = ((float)(dataGridView1.Rows[i].Cells[5].Value = acumulador));
                calculado = ca;

                grafico.Add(fo);
                intervalos.Add(hasta);
             
            }

            return (calculado, grafico, intervalos);
  
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


    }
}
