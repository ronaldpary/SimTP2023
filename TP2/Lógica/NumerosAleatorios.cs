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
    }
}
