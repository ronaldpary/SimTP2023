using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimTP2Q.Lógica
{
    public class Puerto
    {
        public Puerto()
        {

        }


        public double estado { get; set; }

        public Cliente cliente { get; set; }

        public double TiempoRemanente { get; set; }

        public enum EstadoPuerto
        {
            Libre = 0, Ocupado = 1, Lleno = 2, Interrumpido = 3
        }
    }
}
