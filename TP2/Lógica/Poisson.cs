using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
