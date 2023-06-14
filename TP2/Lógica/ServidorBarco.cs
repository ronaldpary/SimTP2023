using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimTP2Q.Lógica
{
    public class ServidorBarco
    {
        #region Atributos
        public double estado { get; set; }
        public Queue<Cliente> cola { get; set; }
        public Cliente cliente { get; set; }
        public double tiempo_preparacion { get; set; }
        //public double hora_prepara


        #endregion

        #region Contructor
        public ServidorBarco()
        {
            this.cola = new Queue<Cliente>();
        }

        public enum EstadoBarco
        {
            Libre = 0, Cargando = 1, Lleno = 2
        }
        #endregion

        #region Metodos

        #endregion
    }
}
