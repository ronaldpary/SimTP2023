using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        
    }
}
