using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
