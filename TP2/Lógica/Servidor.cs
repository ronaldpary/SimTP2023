using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimTP2Q.Lógica
{
    public class Servidor
    {
        public Servidor(Puerto puerto)
        {
            this.Puerto = puerto;
            this.Cola = new Queue<Cliente>();

        }

        public Queue<Cliente> Cola { get; set; }

        public Puerto Puerto;
        public Puerto Puerto2;
    }
}
