using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimTP2Q.Lógica
{
    public class NumerosAleatorios
    {
        
        public List<float> GenerarNumeros(int n)
        {
            List<float> list = new List<float>();
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                float nroi = (float)rnd.NextDouble();
                list.Add(nroi);
            }

            return list;
        }

        public List<float> DesordenarNumeros(List<float> lista)
        {
            Random rnd = new Random();
            for (int i = lista.Count - 1; i > 0; i--)
            {
                int j = rnd.Next(i + 1);
                float temp = lista[i];
                lista[i] = lista[j];
                lista[j] = temp;
            }
            return lista;
        }

        public double generarRdnExponencial(double media, double rnd)
        {
            double exp = -media * Math.Log(1 - rnd);
            return exp;
        }
    }
}
