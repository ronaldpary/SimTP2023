using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimTP2Q.Lógica
{
    public class Parametros
    {
        #region Atributos
        public double media_llegada = 15;
        public double fin_descarga = 1;
        public double preparacion_barco = 6;
        public double fin_revision = 2;

        // tp5 cambiar depende de tu h
        public double hProxInterrupcion = 0.01;
        public double hLlegadas = 0.1;
        public double hServidor = 0.01;
        #endregion

        #region Contructor
        public Parametros() { }
        #endregion
    }
}
