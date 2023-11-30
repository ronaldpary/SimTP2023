using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimTP2Q.Lógica
{
    class RungeKutta
    {
        double h;
        double Y;
        double t;
        ITipoRK tipoRK;
        Presentación.RungeKuttaForm form;
        double Yo;

        public RungeKutta(double h, double to, double Yo, ITipoRK tipoRk, Presentación.RungeKuttaForm form)
        {
            this.h = h;
            this.t = to;
            this.Yo = Yo;
            this.tipoRK = tipoRk;
            this.form = form;
        }

        public double calcularRK()
        {
            double[] filaInicial = new double[8] { 0, 0, 0, 0, 0, 0, this.t, Yo }; //t: representa el t0 inicial; Y: representa el Yo inicial
            if (form != null)
                mostrarFila(filaInicial);

            double[] filaAux = calcularFilaRK(filaInicial);
            if (form != null)
                mostrarFila(filaAux);


            while (tipoRK.ValidarCondicion(filaAux[1], ValidarParametro(filaInicial)))
            {
                filaInicial = filaAux;
                filaAux = calcularFilaRK(filaAux);
                if (form != null)
                    mostrarFila(filaAux);

            }
            return filaAux[0];

            //while (tipoRK.ValidarCondicion(filaAux[1], ValidarParametro(filaAux))){
            //    filaAux = calcularFilaRK(filaAux);
            //        mostrarFila(filaAux);
            //}

        }

        public double ValidarParametro(double[] filaAnterior)
        {
            if (this.tipoRK.GetType().Name == "FinInterrupcionCliente")
                return filaAnterior[1]; //devuelve el L anterior, es decir el L-1
            if (this.tipoRK.GetType().Name == "InicioInterrupcion" || this.tipoRK.GetType().Name == "FinInterrupcionVentanilla")
                return this.Yo;

            return 0;

        }

        public double[] calcularFilaRK(double[] fila)
        {
            double[] filaAuxiliar = new double[8];
            filaAuxiliar[0] = fila[6]; //t
            filaAuxiliar[1] = fila[7]; //A
            filaAuxiliar[2] = tipoRK.K1(filaAuxiliar[1], filaAuxiliar[0]); //K1
            filaAuxiliar[3] = tipoRK.K2(filaAuxiliar[1], h, filaAuxiliar[2], filaAuxiliar[0]); //K2
            filaAuxiliar[4] = tipoRK.K3(filaAuxiliar[1], h, filaAuxiliar[3], filaAuxiliar[0]); //K3
            filaAuxiliar[5] = tipoRK.K4(filaAuxiliar[1], h, filaAuxiliar[4], filaAuxiliar[0]); //K4
            filaAuxiliar[6] = filaAuxiliar[0] + h; //t(i+1)
            filaAuxiliar[7] = tipoRK.Ysiguiente(filaAuxiliar[1], h, filaAuxiliar[2], filaAuxiliar[3], filaAuxiliar[4], filaAuxiliar[5]); //Y(i+1)

            return filaAuxiliar;
        }
        public void mostrarFila(double[] fila)
        {
            form.mostrarFila(fila);
        }
    }

    public interface ITipoRK
    {

        bool ValidarCondicion(double Y_iteracion, double Ao);
        double K1(double A, double t);
        double K2(double A, double h, double K1, double t);
        double K3(double A, double h, double K2, double t);
        double K4(double A, double h, double K3, double t);
        double Ysiguiente(double A, double h, double K1, double K2, double K3, double K4);

    }
    class FinInterrupcionCliente : ITipoRK
    {
        public bool ValidarCondicion(double L_iteracion, double L_anterior)
        {
            if (Math.Abs((L_anterior - L_iteracion)) < 1)
                return false;
            return true;
        }
        public double K1(double L, double t)
        {
            return (-1 * ((L / 0.8) * (Math.Pow(t, 2)))) - L;

        }

        public double K2(double L, double h, double K1, double t)
        {
            return (-1 * ((L + ((h / 2) * K1)) / 0.8) * Math.Pow((t + (h / 2)), 2) - (L + (h / 2) * K1));
        }

        public double K3(double L, double h, double K2, double t)
        {
            return (-1 * ((L + ((h / 2) * K2)) / 0.8) * Math.Pow((t + (h / 2)), 2) - (L + (h / 2) * K2));
        }

        public double K4(double L, double h, double K3, double t)
        {
            return (-1 * (((L + (h * K3)) / 0.8) * Math.Pow((t + h), 2))) - (L + (h * K3));
        }

        public double Ysiguiente(double L, double h, double K1, double K2, double K3, double K4)
        {
            return L + ((h / 6) * (K1 + (2 * K2) + (2 * K3) + K4));
        }
    }

    class InicioInterrupcion : ITipoRK
    {
        public bool ValidarCondicion(double A_iteracion, double Ao)
        {
            if (A_iteracion > (2 * Ao))
                return false; //si es mayor, corta
            return true; //si es menor, sigue
        }

        public double K1(double A, double t)
        {
            return A * Global.RND;
        }

        public double K2(double A, double h, double K1, double t)
        {
            return Global.RND * (A + ((h / 2) * K1));
        }

        public double K3(double A, double h, double K2, double t)
        {
            return Global.RND * (A + ((h / 2) * K2));
        }

        public double K4(double A, double h, double K3, double t)
        {
            return Global.RND * (A + (h * K3));
        }

        public double Ysiguiente(double A, double h, double K1, double K2, double K3, double K4)
        {
            return A + ((h / 6) * (K1 + (2 * K2) + (2 * K3) + K4));
        }



    }

    class FinInterrupcionVentanilla : ITipoRK
    {
        bool ITipoRK.ValidarCondicion(double S_iteracion, double reloj)
        {
            if (S_iteracion > (1.35 * reloj))
                return false;
            return true;
        }
        public double K1(double S, double t)
        {
            return ((0.2 * S) + 3 - t);
        }

        public double K2(double S, double h, double K1, double t)
        {
            return ((0.2 * (S + ((h / 2) * K1))) + 3 - (t + (h / 2)));
        }

        public double K3(double S, double h, double K2, double t)
        {
            return ((0.2 * (S + ((h / 2) * K2))) + 3 - (t + (h / 2)));
        }

        public double K4(double S, double h, double K3, double t)
        {
            return ((0.2 * (S + (h * K3))) + 3 - (t + h));
        }

        public double Ysiguiente(double S, double h, double K1, double K2, double K3, double K4)
        {
            return (S + ((h / 6) * (K1 + (2 * K2) + (2 * K3) + K4)));
        }
    }


    public static class Global
    {
        public static Random gen = new Random();
        public static double RND;

    }

}
