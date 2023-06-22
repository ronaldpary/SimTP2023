using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimTP2Q.Presentación;
using static SimTP2Q.Lógica.Cliente;

namespace SimTP2Q.Lógica
{
    public class GestorSimulacion
    {
        #region Atributos


        public Puerto barco = new Puerto();
        public Puerto almacen = new Puerto();
        public Puerto barcoFragiles = new Puerto();

        public Servidor servidorBarco;
        public Servidor servidorAlmacen;
        public Servidor servidorBarcoFragiles;


        //public ServidorBarco servidor_barco= new ServidorBarco();
        //public ServidorAlmacen servidor_almacen = new ServidorAlmacen();


        private Prueba interfaz;
        private Eventos eventos;

        private NumerosAleatorios numerosAleatorios;

        public Random llegada = new Random();
        public Random cantidad = new Random();
        public Random probabilidad = new Random();
        public Random revision = new Random();
        public Random descarga = new Random();
        public Random preparacion = new Random();

        public double mediaLlegada = 15;
        public double mediaFinDescarga = 1;
        public double mediaFinRevision = 2;
        public double mediaPreparacion = 6;

        public Simulacion simulacion;
        public List<Cliente> enViaje;
        public List<Cliente> enElSistema;
        public int cant_filas_mostrar;

        public int cont_cant_llegadas;

        private double acumulador_descargas;
        private int contador_barcos;
        private int contador_8;
        private int contador_fragiles;
        private double acumulador_revision;

        public int numeroBarco;
        
        #endregion

        #region Constructor
        public GestorSimulacion(Prueba interfaz)
        {
            this.interfaz = interfaz;
            this.simulacion = new Simulacion();
            this.enViaje = new List<Cliente>();
            this.enElSistema = new List<Cliente>();

            //this.servidor_barco = new ServidorBarco();
            //this.servidor_almacen = new ServidorAlmacen();

            this.servidorBarco = new Servidor(barco);
            this.servidorAlmacen = new Servidor(almacen);
            this.servidorBarcoFragiles = new Servidor(barcoFragiles);


            numerosAleatorios = new NumerosAleatorios();
        }

        public void generarTiempoProximaLLegada()
        {
            simulacion.rnd_llegada = llegada.NextDouble();
            simulacion.tiempo_entre_llegada = numerosAleatorios.generarRdnExponencial(mediaLlegada, simulacion.rnd_llegada);
            simulacion.proxima_llegada = simulacion.Reloj + simulacion.tiempo_entre_llegada;

        }


        #endregion

        #region Metodos
        public void iniciarSimulacion(int n, Parametros parametros, int desde, int hasta)
        {
            eventos = new Eventos(simulacion, this);
            this.mediaLlegada = parametros.media_llegada;
            this.mediaFinRevision = parametros.fin_revision;
            this.mediaFinDescarga = parametros.fin_descarga;
            this.mediaPreparacion = parametros.preparacion_barco;

            comenzarSimulacion(n, desde, hasta);
        }

        public void comenzarSimulacion(int n, int desde, int hasta)
        {
            generarTiempoProximaLLegada();
            actualizarEstados();
            actualizarColas();

            string nombreEvento = "Inicio";
            double numeroSimulacion = 0;
            interfaz.mostrarFila(numeroSimulacion, simulacion, enElSistema, nombreEvento, enViaje);

            Stopwatch sw = new Stopwatch();

            for (int i = 0; i < n; i++)
            {
                double siguienteTiempo = definirSiguienteTiempo(simulacion);
                simulacion.Reloj = siguienteTiempo;
                numeroSimulacion = i+1;

                if (siguienteTiempo == simulacion.proxima_llegada)
                {
                    cont_cant_llegadas += 1;
                    Cliente trenCreado = eventos.proximaLLegada();
                    nombreEvento = "Llegada de tren " + "(" + trenCreado.numero.ToString() + ")";
                    
                }
                else if (siguienteTiempo == simulacion.revision_lista)
                {
                    simulacion.limpiarContenedores();
                    for (int j = 0; j < enElSistema.Count; j++)
                    {
                        if (Math.Truncate((enElSistema[j].hora_revision + enElSistema[j].tiempo_revision) * 10000) / 10000 == Math.Truncate(siguienteTiempo * 10000) / 10000)
                        {

                            nombreEvento = "Fin revision " + "(" + enElSistema[j].numero.ToString() + ")";

                            eventos.finRevisionTren(enElSistema[j]);

                            break;
                        }

                    }
                }
                else if (siguienteTiempo == simulacion.barco_listo)
                {
                    simulacion.limpiarContenedores();
                    eventos.finPreparacion();

                    nombreEvento = "Fin preparacion " + "(" + numeroBarco + ")";
                }
                else
                {
                    simulacion.limpiarContenedores();
                    for (int j = 0; j < enElSistema.Count; j++)
                    {


                        if (Math.Truncate((enElSistema[j].hora_descarga + enElSistema[j].tiempo_descarga)*10000) / 10000 == Math.Truncate(siguienteTiempo * 10000)/10000)
                        {

                            nombreEvento = "Fin descarga " + "(" + enElSistema[j].numero.ToString() + ")";

                            eventos.finDescargaTren(enElSistema[j]);

                            break;
                        }

                    }
                }

                actualizarColas();
                actualizarEstados();

                
                sw.Start();

                if (i+1 >= desde && i+1 <= hasta)
                {
                    interfaz.mostrarFila(numeroSimulacion, simulacion, enElSistema, nombreEvento, enViaje);
                    cant_filas_mostrar++;

                }

                sw.Stop();

                eliminarTrenesDescargados();
                //eliminarTrenesRevisados();

            }

            interfaz.mostrarFila(numeroSimulacion, simulacion, enElSistema, nombreEvento, enViaje);
            interfaz.mostrarPuntos(acumulador_descargas, contador_barcos, contador_8, contador_fragiles, acumulador_revision);

            
            //MessageBox.Show("Time", sw.Elapsed.ToString("hh\\:mm\\:ss\\.fff"));



        }

        public void eliminarTrenesRevisados()
        {
            enElSistema.RemoveAll(trenRevisado);
        }

        public bool trenRevisado(Cliente obj)
        {
            return obj.estado == (double)Estado.esperando_descarga;
        }

        public void eliminarTrenesDescargados()
        {
            enElSistema.RemoveAll(trenDescargado);
        }

        public bool trenDescargado(Cliente obj)
        {
            return obj.estado == (double)Estado.destruido;

        }

        public double definirSiguienteTiempo(Simulacion simulacion)
        {
            List<double> listaEventos = new double[] {simulacion.proxima_llegada, simulacion.fin_descarga, simulacion.revision_lista, simulacion.barco_listo}.ToList();

            listaEventos.RemoveAll(x => x == -1);
            double minimo = listaEventos.Min();
            return minimo;

        }

        public void actualizarColas()
        {
            simulacion.cola_barco = servidorBarco.Cola.Count;
            simulacion.cola_almacen = servidorAlmacen.Cola.Count;
        }

        public void actualizarEstados()
        {
            simulacion.estado_barco = barco.estado;
            simulacion.estado_almacen = almacen.estado;
        }

        public void generarTiempoDescarga(double cantidad_contenedores)
        {
            simulacion.rnd_descarga = descarga.NextDouble();
            simulacion.tiempo_descarga = cantidad_contenedores * numerosAleatorios.generarRdnExponencial(mediaFinDescarga, simulacion.rnd_descarga);
            simulacion.fin_descarga = simulacion.Reloj + simulacion.tiempo_descarga;
            
            
        }

        public void generarTiempoRevision(double cantidad_contenedores)
        {
            simulacion.rnd_revision = revision.NextDouble();
            simulacion.tiempo_revision = cantidad_contenedores * numerosAleatorios.generarRdnExponencial(mediaFinRevision, simulacion.rnd_revision);
            simulacion.revision_lista = simulacion.Reloj + simulacion.tiempo_revision;
        }
        public void generarTiempoPreparacion()
        {
            simulacion.rnd_preparacion = preparacion.NextDouble();
            simulacion.tiempo_preparacion = numerosAleatorios.generarRdnExponencial(mediaPreparacion, simulacion.rnd_preparacion);
            simulacion.barco_listo = simulacion.Reloj + simulacion.tiempo_preparacion;
        }

        public void acumuladorTiempoDescarga(double punto)
        {
            acumulador_descargas = punto; 
        }

        public void trenesFragiles(double metrica1)
        {
            contador_fragiles = (int)metrica1;
        }

        public void contarBarcosZarpados()
        {
            contador_barcos = contador_barcos + 1;
        }

        public void acumuladorTiempoRevision(double puntoRevision)
        {
            acumulador_revision = puntoRevision;
        }

        public void trenesCon8(double metrica2)
        {
            contador_8 = (int)metrica2;
        }


        public void generarTiempoDescargaSinSobrantes(double cantidad_contenedores, double sobrante)
        {
            simulacion.rnd_descarga = descarga.NextDouble();
            double tiempo_descarga_total = cantidad_contenedores * numerosAleatorios.generarRdnExponencial(mediaFinDescarga, simulacion.rnd_descarga);

            simulacion.tiempo_descarga = (tiempo_descarga_total / cantidad_contenedores) * (cantidad_contenedores-sobrante);

            simulacion.fin_descarga = simulacion.Reloj + simulacion.tiempo_descarga;

            simulacion.contenedores_remanentes = sobrante;
            simulacion.tiempo_remanente = (tiempo_descarga_total / cantidad_contenedores) * (sobrante);
        }

        public void generarTiempoDescargaConPreparacion(double cantidad_contenedores)
        {
            simulacion.rnd_descarga = descarga.NextDouble();
            simulacion.tiempo_descarga = cantidad_contenedores * numerosAleatorios.generarRdnExponencial(mediaFinDescarga, simulacion.rnd_descarga);
            simulacion.fin_descarga = simulacion.Reloj + simulacion.tiempo_descarga + simulacion.tiempo_preparacion;
        }
        #endregion
    }
}
