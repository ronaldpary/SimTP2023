using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SimTP2Q.Lógica.Cliente;
using static SimTP2Q.Lógica.ServidorAlmacen;
using static SimTP2Q.Lógica.ServidorBarco;

namespace SimTP2Q.Lógica
{
    public class Eventos
    {
        #region Atributos
        public GestorSimulacion gestor;
        private Simulacion simulacion;
        private int numero;
        public double desde;
        public double hasta;
        public double tiempoOcupado;
        #endregion

        #region Constructor
        public Eventos(Simulacion Simulacion, GestorSimulacion Gestor)
        {
            this.simulacion = Simulacion;
            this.numero = 0;
            this.gestor = Gestor;
        }
        #endregion

        #region Metodos
        public Cliente proximaLLegada()
        {
            numero++;
            gestor.generarTiempoProximaLLegada();

            simulacion.rnd_prob_revision = gestor.probabilidad.NextDouble();

            simulacion.rnd_cantidad_cont = gestor.cantidad.NextDouble();

            Cliente cliente = primerTren(simulacion.rnd_prob_revision, simulacion.rnd_cantidad_cont);
            simulacion.se_revisa = cliente.tipo_cliente;
            cliente.numero = numero;
            simulacion.cantidad_contenedores = cliente.cantidad_contenedores;

            gestor.enElSistema.Add(cliente);

            return cliente;
        }


        public Cliente primerTren(double rnd_prob_revision, double rnd_cantidad_cont)
        {
            Cliente tren;
            if (rnd_prob_revision < 0.50)
            {

                if (rnd_cantidad_cont < 0.10)
                {
                    tren = new Cliente((double)TipoCliente.A, (double)CantidadCont.A);
                }
                else
                {
                    if (rnd_cantidad_cont > 0.9 && rnd_cantidad_cont < 0.30)
                    {
                        tren = new Cliente((double)TipoCliente.A, (double)CantidadCont.B);
                    }
                    else
                    {
                        if (rnd_cantidad_cont > 0.29 && rnd_cantidad_cont < 0.80)
                        {
                            tren = new Cliente((double)TipoCliente.A, (double)CantidadCont.C);
                        }
                        else
                        {
                            tren = new Cliente((double)TipoCliente.A, (double)CantidadCont.D);
                        }
                    }
                }

                consultarColaBarco(tren);


            }
            else
            {

                simulacion.contador_trenes_fragiles = simulacion.contador_trenes_fragiles + 1;

                gestor.trenesFragiles(simulacion.contador_trenes_fragiles);

                if (rnd_cantidad_cont < 0.10)
                {
                    tren = new Cliente((double)TipoCliente.B, (double)CantidadCont.A);
                    

                }
                else
                {
                    if (rnd_cantidad_cont > 0.9 && rnd_cantidad_cont < 0.30)
                    {
                        tren = new Cliente((double)TipoCliente.B, (double)CantidadCont.B);
                    }
                    else
                    {
                        if (rnd_cantidad_cont > 0.29 && rnd_cantidad_cont < 0.80)
                        {
                            tren = new Cliente((double)TipoCliente.B, (double)CantidadCont.C);
                        }
                        else
                        {
                            tren = new Cliente((double)TipoCliente.B, (double)CantidadCont.D);
                        }
                    }
                }

                consultarColaBarco(tren);
            }
            

            return tren;
        }

        private void consultarColaAlmacen(Cliente tren)
        {
            if(gestor.servidor_almacen.estado == (double)EstadoAlmacen.Revisando)
            {
                gestor.servidor_almacen.cola.Enqueue(tren);
                tren.estado = (double)Estado.esperando_revision;
            }
            else
            {
                tren.estado = (double)Estado.siendo_revisado;
                gestor.servidor_almacen.estado = (double)EstadoAlmacen.Revisando;
                enRevision(tren);
            }
        }

        public void consultarColaBarco(Cliente tren)
        {
            if (gestor.servidor_barco.estado == (double)EstadoBarco.Cargando || gestor.servidor_barco.estado == (double)EstadoBarco.Lleno)
            {
                gestor.servidor_barco.cola.Enqueue(tren);
                tren.estado = (double)Estado.esperando_atencion;
            }
            else
            {
                tren.estado = (double)Estado.siendo_atendido;
                gestor.servidor_barco.estado = (double)EstadoBarco.Cargando;
                enDescarga(tren);
            }
        }

        public void enRevision(Cliente tren)
        {

            desde = simulacion.Reloj;

            gestor.servidor_almacen.cliente = tren;

            gestor.generarTiempoRevision(gestor.servidor_almacen.cliente.cantidad_contenedores);

            tren.hora_revision = simulacion.Reloj;

            tren.tiempo_revision = simulacion.tiempo_revision;

            
        }

        public void enDescarga(Cliente tren)
        {
            desde = simulacion.Reloj;

            gestor.servidor_barco.cliente = tren;

            gestor.generarTiempoDescarga(gestor.servidor_barco.cliente.cantidad_contenedores);

            tren.hora_descarga = simulacion.Reloj;

            tren.tiempo_descarga = simulacion.tiempo_descarga;

           
        }

        public void finRevisionTren(Cliente trenRevisado)
        {
            //gestor.servidor_almacen.estado = (double)EstadoAlmacen.Libre;

            simulacion.limpiarEventoFinRevision();

            consultarColaBarco(trenRevisado);

            if (gestor.servidor_almacen.cola.Count > 0)
            {
                Cliente siguienteTren = gestor.servidor_almacen.cola.Dequeue();

                enRevision(siguienteTren);
                
            }
            else
            {
                gestor.servidor_almacen.estado = (double)EstadoAlmacen.Libre;
            }

        }

        public void finDescargaTren(Cliente trenDescargado)
        {
            // Contador de contenedores cargados
            simulacion.contenedores_cargados = simulacion.contenedores_cargados + trenDescargado.cantidad_contenedores;

            // Acumulador tiempo descarga

            double tiempo_descarga = simulacion.Reloj - trenDescargado.hora_descarga;
            simulacion.acumulador_descarga = simulacion.acumulador_descarga + tiempo_descarga;

            gestor.acumuladorTiempoDescarga(simulacion.acumulador_descarga);

            borrarTren(trenDescargado);

            if (simulacion.contenedores_cargados >= 50)
            {
                
                //enPreparacion();
            }
         

            simulacion.limpiarFinDescargaTren();

            if (gestor.servidor_barco.cola.Count > 0)
            {
                Cliente tren = gestor.servidor_barco.cola.Dequeue();

                tren.estado = (double)Estado.siendo_atendido;

                enDescarga(tren);
     
            }
            else
            {
                gestor.servidor_barco.estado = (double)EstadoBarco.Libre;
            }

        }

        private void enPreparacion()
        {
            desde = simulacion.Reloj;
            //simulacion.contenedores_cargados = 0;
            gestor.servidor_barco.estado = (double)EstadoBarco.Lleno;
            gestor.generarTiempoPreparacion();


        }

        public void borrarTren(Cliente tren)
        {
            tren.estado = (double)Estado.destruido;
            tren.Dispose();
        }


        public void finPreparacion()
        {
            gestor.servidor_barco.estado = (double)EstadoBarco.Cargando;
            
            simulacion.limpiarEventoFinPreparacion();

            
        }

        #endregion


    }
}
