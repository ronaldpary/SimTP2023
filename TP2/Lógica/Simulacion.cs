using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimTP2Q.Lógica
{
    public class Simulacion
    {

        #region Atributos

        public double Reloj { get; set; }

        //Llegada del tren
        public double rnd_llegada { get; set; } = -1;
        public double tiempo_entre_llegada { get; set;} = -1;
        public double rnd_cantidad_cont { get; set;} = -1;
        public double cantidad_contenedores { get; set; } = -1;
        public double proxima_llegada { get; set; } = -1;

        //Fin de revision del tren
        public double rnd_prob_revision { get;  set; } = -1;
        public double se_revisa { get; set; } = -1;
        public double rnd_revision { get; set; } = -1;
        public double tiempo_revision { get; set; } = -1;
        public double revision_lista { get; set; } = -1;

        //Servidor almacen
        public double estado_almacen { get; set; } = -1;
        public double cola_almacen { get; set; } = -1;

        //Fin de descarga del tren
        public double rnd_descarga { get; set; } = -1;
        public double tiempo_descarga { get;  set; } = -1;
        public double fin_descarga { get; set; } = -1;

        //Preparacion del barco
        public double rnd_preparacion { get; set; } = -1;
        public double tiempo_preparacion { get; set; } = -1;
        public double barco_listo { get; set; } = -1;

        //Servidor barco
        public double estado_barco { get; set; } = -1;
        public double cola_barco { get; set; } = -1;

        public double contenedores_cargados { get; set; } = 0;

        //
        //public ServidorBarco servidor_barco = new ServidorBarco();
        //public ServidorAlmacen servidor_almacen = new ServidorAlmacen();

        #endregion

        #region Metodos
        public void limpiarEventoLlegada()
        {
            this.rnd_llegada = -1;
            this.tiempo_entre_llegada = -1;
            this.rnd_cantidad_cont = -1;
            this.cantidad_contenedores = -1;
            //this.proxima_llegada = -1;
        }

        public void limpiarEventoFinRevision()
        {
            this.rnd_prob_revision = -1;
            this.se_revisa = -1;
            this.rnd_revision = -1;
            this.tiempo_revision = -1;
            this.revision_lista = -1;
        }

        public void limpiarFinDescargaTren()
        {
            this.rnd_descarga = -1;
            this.tiempo_descarga = -1;
            this.fin_descarga = -1;
        }

        public void preparacionBarco()
        {
            this.rnd_preparacion = -1;
            this.tiempo_preparacion = -1;
            this.barco_listo = -1;
        }

        public void limpiarEventoFinPreparacion()
        {
            throw new NotImplementedException();
        }

        public void limpiarContenedores()
        {
            this.rnd_llegada = -1;
            this.tiempo_entre_llegada = -1;
            this.rnd_cantidad_cont = -1;
            this.cantidad_contenedores = -1;

            //this.rnd_cantidad_cont = -1;
            //this.cantidad_contenedores = -1;
        }

        public void limpiarHoraRevisionYHoraDescarga()
        {
            throw new NotImplementedException();
        }

        public void limpiarColumnasRevision()
        {
            this.rnd_prob_revision = -1;
            this.se_revisa = -1;
            this.rnd_revision = -1;
            this.tiempo_revision = -1;
            //this.revision_lista = -1;
        }

        public void ColumnasFinDescarga()
        {
            this.rnd_descarga = -1;
            this.tiempo_descarga = -1;
        }

        public void sumarContenedoresCargados(Cliente tren)
        {
            this.contenedores_cargados = this.contenedores_cargados + tren.cantidad_contenedores; 
        }



        #endregion


    }
}
