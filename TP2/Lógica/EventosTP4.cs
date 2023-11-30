using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SimTP2Q.Lógica.Cliente;
using static SimTP2Q.Lógica.Puerto;

namespace SimTP2Q.Lógica
{
    public class EventosTP4
    {
        #region Atributos
        public GestorSimulacionTP4 gestor;

        private Simulacion simulacion;
        private int numero;

        public double desde;
        public double hasta;
        public double tiempoOcupado;
        #endregion

        #region Constructor
        public EventosTP4(Simulacion Simulacion, GestorSimulacionTP4 Gestor)
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
            if (rnd_prob_revision < 0.70)
            {

                if (rnd_cantidad_cont < 0.10)
                {
                    tren = new Cliente((double)TipoCliente.A, (double)CantidadCont.A);
                }
                else
                {
                    if (rnd_cantidad_cont > 0.09 && rnd_cantidad_cont < 0.30)
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
                    if (rnd_cantidad_cont > 0.09 && rnd_cantidad_cont < 0.30)
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

                            simulacion.cont_trenes_fragiles_8 = simulacion.cont_trenes_fragiles_8 + 1;
                            gestor.trenesCon8(simulacion.cont_trenes_fragiles_8);

                        }
                    }
                }

                consultarColaAlmacen(tren);
            }


            return tren;
        }

        private void consultarColaAlmacen(Cliente tren)
        {
            if (gestor.servidorAlmacen.Puerto.estado == (double)EstadoPuerto.Ocupado)
            {
                gestor.servidorAlmacen.Cola.Enqueue(tren);
                tren.estado = (double)Estado.esperando_revision;
            }
            else if (gestor.servidorAlmacen.Puerto.estado == (double)EstadoPuerto.Libre)
            {

                gestor.servidorAlmacen.Puerto.estado = (double)EstadoPuerto.Ocupado;
                enRevision(tren);
                //tren.estado = (double)Estado.siendo_revisado;

            }
        }

        public void consultarColaBarco(Cliente tren)
        {
            if (gestor.servidorBarco.Puerto.estado == (double)EstadoPuerto.Ocupado || gestor.servidorBarco.Puerto.estado == (double)EstadoPuerto.Lleno)
            {
                gestor.servidorBarco.Cola.Enqueue(tren);
                tren.estado = (double)Estado.esperando_atencion;
            }
            else if (gestor.servidorBarco.Puerto.estado == (double)EstadoPuerto.Libre)
            {

                gestor.servidorBarco.Puerto.estado = (double)EstadoPuerto.Ocupado;
                enDescarga(tren);
                //tren.estado = (double)Estado.siendo_atendido;

            }
        }


        public void enRevision(Cliente tren)
        {

            desde = simulacion.Reloj;

            gestor.servidorAlmacen.Puerto.cliente = tren;

            gestor.generarTiempoRevision(gestor.servidorAlmacen.Puerto.cliente.cantidad_contenedores);

            tren.estado = (double)Estado.siendo_revisado;

            tren.hora_revision = simulacion.Reloj;

            tren.tiempo_revision = simulacion.tiempo_revision;


        }

        public void enDescarga(Cliente tren)
        {
            desde = simulacion.Reloj;

            gestor.servidorBarco.Puerto.cliente = tren;

            //Prueba
            //gestor.generarTiempoDescarga(gestor.servidorBarco.Puerto.cliente.cantidad_contenedores);

            //tren.estado = (double)Estado.siendo_atendido;

            //tren.hora_descarga = simulacion.Reloj;

            //tren.tiempo_descarga = simulacion.tiempo_descarga;


            if (simulacion.contenedores_cargados + gestor.servidorBarco.Puerto.cliente.cantidad_contenedores > 50)
            {
                double sobrante = simulacion.contenedores_cargados + gestor.servidorBarco.Puerto.cliente.cantidad_contenedores - 50;

                gestor.generarTiempoDescargaSinSobrantes(gestor.servidorBarco.Puerto.cliente.cantidad_contenedores, sobrante);

                tren.estado = (double)Estado.esperando_descarga;

                tren.hora_descarga = simulacion.Reloj;

                tren.tiempo_descarga = simulacion.tiempo_descarga;

            }
            else
            {
                gestor.generarTiempoDescarga(gestor.servidorBarco.Puerto.cliente.cantidad_contenedores);
                tren.estado = (double)Estado.siendo_atendido;

                tren.hora_descarga = simulacion.Reloj;

                tren.tiempo_descarga = simulacion.tiempo_descarga;
            }


        }



        public void finRevisionTren(Cliente tren1)
        {

            // Acumulador tiempo revision
            double tiempo_revision = simulacion.Reloj - tren1.hora_revision;
            simulacion.acumulador_revision = simulacion.acumulador_revision + tiempo_revision;

            gestor.acumuladorTiempoRevision(simulacion.acumulador_revision);

            simulacion.limpiarEventoFinRevision();

            consultarColaBarco(tren1);

            if (gestor.servidorAlmacen.Cola.Count > 0)
            {
                Cliente siguienteTren = gestor.servidorAlmacen.Cola.Dequeue();

                gestor.servidorAlmacen.Puerto.estado = (double)EstadoPuerto.Ocupado;

                enRevision(siguienteTren);

            }
            else
            {
                gestor.servidorAlmacen.Puerto.estado = (double)EstadoPuerto.Libre;
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

            //Prueba
            //if (simulacion.contenedores_cargados >= 50)
            //{
            //    borrarTren(trenDescargado);
            //    enPreparacion();

            //    //simulacion.limpiarFinDescargaTren();
            //    gestor.servidorBarco.Puerto.estado = (double)EstadoPuerto.Lleno;


            //    if (gestor.servidorBarco.Cola.Count > 0)
            //    {

            //        Cliente tren = gestor.servidorBarco.Cola.Dequeue();

            //        gestor.servidorBarco.Puerto.estado = (double)EstadoPuerto.Ocupado;

            //        enDescarga(tren);
            //        //enDescargaConPreparacion(tren);

            //    }
            //    else
            //    {
            //        gestor.servidorBarco.Puerto.estado = (double)EstadoPuerto.Libre;
            //    }
            //}
            //else
            //{
            //    borrarTren(trenDescargado);

            //    simulacion.limpiarFinDescargaTren();

            //    simulacion.limpiarRemanente();

            //    if (gestor.servidorBarco.Cola.Count > 0)
            //    {

            //        Cliente tren = gestor.servidorBarco.Cola.Dequeue();

            //        gestor.servidorBarco.Puerto.estado = (double)EstadoPuerto.Ocupado;

            //        enDescarga(tren);

            //    }
            //    else
            //    {
            //        gestor.servidorBarco.Puerto.estado = (double)EstadoPuerto.Libre;
            //    }
            //}

            simulacion.limpiarFinDescargaTren();

            if (trenDescargado.estado == (double)Estado.esperando_descarga)
            {
                gestor.servidorBarco.Puerto.estado = (double)EstadoPuerto.Lleno;
                enPreparacion();

                enDescargaSobrantes(trenDescargado);
                trenDescargado.estado = (double)Estado.siendo_atendido;
            }
            else
            {
                borrarTren(trenDescargado);
                //simulacion.limpiarFinDescargaTren();

                simulacion.limpiarRemanente();

                if (gestor.servidorBarco.Cola.Count > 0)
                {

                    Cliente tren = gestor.servidorBarco.Cola.Dequeue();

                    gestor.servidorBarco.Puerto.estado = (double)EstadoPuerto.Ocupado;

                    enDescarga(tren);

                }
                else
                {
                    gestor.servidorBarco.Puerto.estado = (double)EstadoPuerto.Libre;
                }
            }


        }

        private void enDescargaConPreparacion(Cliente tren)
        {
            desde = simulacion.Reloj;

            gestor.servidorBarco.Puerto.cliente = tren;

            //Prueba
            gestor.generarTiempoDescargaConPreparacion(gestor.servidorBarco.Puerto.cliente.cantidad_contenedores);

            tren.estado = (double)Estado.siendo_atendido;

            tren.hora_descarga = simulacion.Reloj;

            tren.tiempo_descarga = simulacion.tiempo_descarga + simulacion.tiempo_preparacion;


        }



        public void enDescargaSobrantes(Cliente trenDescargado)
        {
            desde = simulacion.Reloj;

            gestor.servidorBarco.Puerto.cliente = trenDescargado;

            simulacion.rnd_descarga = 0;
            simulacion.tiempo_descarga = simulacion.tiempo_remanente;
            simulacion.fin_descarga = simulacion.Reloj + simulacion.tiempo_descarga + simulacion.tiempo_preparacion;

            trenDescargado.hora_descarga = simulacion.Reloj;
            trenDescargado.tiempo_descarga = simulacion.tiempo_descarga + simulacion.tiempo_preparacion;
            trenDescargado.cantidad_contenedores = simulacion.contenedores_remanentes;
        }



        public void enPreparacion()
        {
            desde = simulacion.Reloj;
            simulacion.contenedores_cargados = 50;
            gestor.generarTiempoPreparacion();

        }


        public void borrarTren(Cliente tren)
        {

            tren.estado = (double)Estado.destruido;
            tren.Dispose();


        }


        public void finPreparacion()
        {

            simulacion.limpiarEventoFinPreparacion();

            gestor.contarBarcosZarpados();

            simulacion.contenedores_cargados = 0;

            simulacion.contador_barcos = simulacion.contador_barcos + 1;

            gestor.numeroBarco = gestor.numeroBarco + 1;

            // gestor.servidorBarco.Puerto.estado = (double)EstadoPuerto.Libre;


        }

        #endregion
    }
}
