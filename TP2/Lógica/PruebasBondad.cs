using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimTP2Q.Lógica
{
    public class PruebasBondad
    {
        double[] arrayChiCuadrado = new double[] { 0, 3.84, 5.99, 7.81, 9.49, 11.1, 12.6, 14.1, 15.5, 16.9, 18.3, 19.7, 21.0, 22.4, 23.7, 25.0, 26.3, 27.6, 28.9, 30.1, 31.4, 32.7, 33.9, 35.2, 36.4, 37.7, 38.9, 40.1, 41.3, 42.6, 43.8, 55.8, 67.5, 79.1, 90.5, 101.9, 113.1, 124.3 };
        
        double[] arrayKs = new double[] { 0.0, 0.97500, 0.70760, 0.84189, 0.62394, 0.56328, 0.51926, 0.48342, 0.45427, 0.43001, 0.40925, 0.39122, 0.37543,
                                          0.36143, 0.34890, 0.33750, 0.32733, 0.31796, 0.30936, 0.30143, 0.29408, 0.28724, 0.28087, 0.2749, 0.26931,
                                          0.26404, 0.25908, 0.25438, 0.24993, 0.24571, 0.24170, 0.23788, 0.23424, 0.23076, 0.22743, 0.22425};

        public double AceptaRechazaKS(int n)
        {
            double tabulado;
            if (n>35)
            {
                tabulado = 1.36 / Math.Sqrt(n);
            }
            else
            {
                tabulado = arrayKs[n];
            }

            return tabulado;
        }

        public double AceptaRechazaCC(int interv, string distribucion)
        {
            double tabuladoC;


            if (distribucion == "Uniforme")
            {
                int m = 0;
                int v = interv - 1 - m;
                tabuladoC = arrayChiCuadrado[v];
            } 
            else
            {
                if (distribucion == "Exponencial")
                {
                    int m = 1;
                    int v = interv - 1 - m;
                    tabuladoC = arrayChiCuadrado[v];
                }
                else
                {
                    if (distribucion == "Poisson")
                    {
                        int m = 1;
                        int v = interv - 1 - m;
                        tabuladoC = arrayChiCuadrado[v];
                    }
                    else
                    {
                        int m = 2;
                        int v = interv - 1 - m;
                        tabuladoC = arrayChiCuadrado[v];
                    }
                }
            }

            //if (distribucion == "Exponencial")
            //{
            //    int m = 1;
            //    int v = interv - 1 - m;
            //    tabuladoC = arrayChiCuadrado[v];
            //}

            //if (distribucion == "Poisson")
            //{
            //    int m = 1;
            //    int v = interv - 1 - m;
            //    tabuladoC = arrayChiCuadrado[v];
            //}
            //else
            //{
            //    int m = 2;
            //    int v = interv - 1 - m;
            //    tabuladoC = arrayChiCuadrado[v];
            //}

            return tabuladoC;
        }
    }
}
