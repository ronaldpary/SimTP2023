using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimTP2Q.Lógica
{
    public class Cliente : IDisposable
    {
        #region Atributos
        public int numero;
        
        public double estado { get; set; }
        public double tipo_cliente { get; set; }
        public double cantidad_contenedores { get; set; }
        public double hora_descarga { get; set; }
        public double hora_revision { get; set; }
        public double tiempo_descarga { get; set; }
        public double tiempo_revision { get; set; }

        #endregion

        #region Constructor
        public Cliente(double tipo, double cantidad)
        {
            this.tipo_cliente = tipo;
            this.cantidad_contenedores = cantidad;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        public enum CantidadCont
        {
            A = 5, B = 8, C = 12, D = 15
        }
        public enum TipoCliente
        {
            A = 1, B = 2
        }
        public enum Estado 
        { esperando_atencion = 1, siendo_atendido = 2, 
            esperando_revision = 3, siendo_revisado = 4, 
            destruido = 5, revisado = 6
        }

        #endregion

        #region Metodos
        public string estadoCliente(double estado)
        {
            string estadoActual = "";
            switch (estado)
            {
                case 1:
                    estadoActual = "E_Atencion";
                    break;
                case 2:
                    estadoActual = "S_Atendido";
                    break;
                case 3:
                    estadoActual = "E_Revision";
                    break;
                case 4:
                    estadoActual = "S_Revisado";
                    break;
                case 5:
                    estadoActual = "Descargado";
                    break;
                case 6:
                    estadoActual = "Revisado";
                    break;

            }
            return estadoActual;
        }
        #endregion
    }
}
