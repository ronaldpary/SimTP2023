using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimTP2Q.Lógica
{
    public class PuertoGeneral
    {
        public PuertoGeneral()
        {
            this.Cola = new Queue<Cliente>();
        }
        public Queue<Cliente> Cola { get; set; }
        public EstadoPuertoGeneral estadoPuerto { get; set; }

        public enum EstadoPuertoGeneral
        {
            SinInterrupcion = 1, Interrumpido = 2
        }
    }
}
