using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimTP2Q.Lógica
{
    public class ServidorAlmacen
    {
        #region Atributos
        public double estado { get; set; }
        public Queue<Cliente> cola { get; set; }
        public Cliente cliente { get; set; }
        #endregion

        #region Contructor
        public ServidorAlmacen()
        {
            this.cola = new Queue<Cliente>();
        }
        public ServidorAlmacen servidor1;
        public enum EstadoAlmacen
        {
            Libre = 0, Revisando = 1
        }
        #endregion

        #region Metodos

        public string estadoAlmacen(double estado)
        {
            string estadoActual = "";
            switch (estado)
            {
                case 1:
                    estadoActual = "Libre";
                    break;
                case 2:
                    estadoActual = "Revisando";
                    break;

            }
            return estadoActual;
        }

        #endregion
    }
}
