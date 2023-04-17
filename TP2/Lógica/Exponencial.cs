using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
