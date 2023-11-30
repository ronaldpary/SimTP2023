using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using SimTP2Q.Lógica;

namespace SimTP2Q.Presentación
{
    public partial class Prueba : UserControl
    {
        Parametros parametros = new Parametros();

        GestorSimulacion gestor;
        // Parametros parametros;
        public Prueba()
        {
            InitializeComponent();
            cargarValores();

            //gbAccion.BringToFront();
            gbAccion.MouseDown += GbAccion_MouseDown; ;
            gbAccion.MouseUp += GbAccion_MouseUp; ;
            gbAccion.MouseMove += GbAccion_MouseMove;


        }

        bool down = false;
        Point inicial;
        private void GbAccion_MouseUp(object sender, MouseEventArgs e) =>down = false;

        private void GbAccion_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                down = true;
                inicial = e.Location;
            }
        }

        private void GbAccion_MouseMove(object sender, MouseEventArgs e)
        {
            Guna2GroupBox ctr = (Guna2GroupBox)sender;
            if (down)
            {
                ctr.Left = e.X + ctr.Left - inicial.X;
                ctr.Top = e.Y + ctr.Top - inicial.Y;
            }
        }

       
        private void cargarValores()
        {
            txtLlegada.Text = this.parametros.media_llegada.ToString();
            txtRevision.Text = this.parametros.fin_revision.ToString();
            txtDescarga.Text = this.parametros.fin_descarga.ToString();
            txtPreparacion.Text = this.parametros.preparacion_barco.ToString();

            //tp5
            txt_prox_interrupcion.Text = this.parametros.hProxInterrupcion.ToString();
            txt_fin_llegadas.Text = this.parametros.hLlegadas.ToString();
            txt_fin_servidor.Text = this.parametros.hServidor.ToString();
        }

        //private void frmColas_Load(object sender, EventArgs e)
        //{

        //}



        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnComenzar_Click_1(object sender, EventArgs e)
        {
            try
            {
                gestor = new GestorSimulacion(this);
                if (txtSimulaciones.Text != "" && txtDesde.Text != "" && txtHasta.Text != "")
                {
                    int n = Convert.ToInt32(txtSimulaciones.Text);
                    int desde = Convert.ToInt32(txtDesde.Text);
                    int hasta = Convert.ToInt32(txtHasta.Text);
                    dgvEventos.Rows.Clear();
                    ValidarDatos(parametros);
                    gestor.iniciarSimulacion(Convert.ToInt32(txtSimulaciones.Text), this.parametros, Convert.ToInt32(txtDesde.Text), Convert.ToInt32(txtHasta.Text));

                    dgvEventos.SelectedRows[0].Selected = false;
                    dgvEventos.Rows[0].DefaultCellStyle.BackColor = Color.Yellow;
                    dgvEventos.Rows[(hasta - desde) + 2].DefaultCellStyle.BackColor = Color.Yellow;
                    //dgvEventos.Rows[-1].Cells[0].Style.BackColor = Color.Blue;

                }
                else
                {
                    MessageBox.Show("Complete todos los datos");
                }
            }
            catch (Exception ex)
            {

                MostrarError(ex.Message);
            }

            

        }

        private void ValidarDatos(Parametros parametros)
        {
            if (txtLlegada.Text != "") { parametros.media_llegada = Convert.ToDouble(txtLlegada.Text); }
            if (txtDescarga.Text != "") { parametros.fin_descarga = Convert.ToDouble(txtDescarga.Text); }
            if (txtRevision.Text != "") { parametros.fin_revision = Convert.ToDouble(txtRevision.Text); }
            if (txtPreparacion.Text != "") { parametros.preparacion_barco = Convert.ToDouble(txtPreparacion.Text); }
        }

        public void mostrarFila(double numero, Simulacion simulacion, List<Cliente> enElSistema, string nombreEvento, List<Cliente> enViaje)
        {
            try
            {
                int index = dgvEventos.Rows.Add();
                //tp5
                dgvEventos.Rows[index].Resizable = DataGridViewTriState.False;


                PropertyInfo[] properties = typeof(Simulacion).GetProperties();

                foreach (PropertyInfo property in properties)
                {
                    string nombreAtributo = property.Name;

                    double valor = (double)property.GetValue(simulacion);
                    dgvEventos.Rows[index].Cells["Evento"].Value = nombreEvento;
                    dgvEventos.Rows[index].Cells["Numero"].Value = numero;

                    if (valor != -1)
                    {
                        if (nombreAtributo == "estado_almacen" || nombreAtributo == "estado_barco")
                        {
                            if (valor == 3)
                            {
                                string estado = "Interrumpido";
                                dgvEventos.Rows[index].Cells[nombreAtributo].Value = estado;
                            }
                            else
                            {
                                string estado = valor == 0 ? "Libre" : valor == 1 ? "Ocupado" : "Lleno";
                                dgvEventos.Rows[index].Cells[nombreAtributo].Value = estado;
                            }

                        }
                        else
                        {
                            dgvEventos.Rows[index].Cells[nombreAtributo].Value = valor;
                        }
                    }
                }

                if (enElSistema.Count != 0)
                {
                    for (int i = 0; i < enElSistema.Count; i++)
                    {
                        if (dgvEventos.Columns["Estado" + i.ToString()] != null)
                        {
                            dgvEventos.Rows[index].Cells["Estado" + i.ToString()].Value = (enElSistema[i].estadoCliente(enElSistema[i].estado) + "(" + enElSistema[i].numero + ")").ToString();
                            dgvEventos.Rows[index].Cells["HID" + i.ToString()].Value = Convert.ToDecimal(enElSistema[i].hora_descarga.ToString()).ToString("N");
                            //dgvEventos.Rows[index].Cells["HID" + i.ToString()].Value = enElSistema[i].hora_descarga.ToString();

                            dgvEventos.Rows[index].Cells["HIR" + i.ToString()].Value = Convert.ToDecimal(enElSistema[i].hora_revision.ToString()).ToString("N");
                            //dgvEventos.Rows[index].Cells["HIR" + i.ToString()].Value = enElSistema[i].hora_revision.ToString();

                            dgvEventos.Rows[index].Cells["Contenedores" + i.ToString()].Value = enElSistema[i].cantidad_contenedores.ToString();
                            //dgvEventos.Rows[index].Cells["Contenedores" + i.ToString()].Value = enElSistema[i].cantidad_contenedores.ToString();
                        }
                        else
                        {
                            int indiceColumna = dgvEventos.Columns.Add("Estado" + i.ToString(), "Estado");
                            dgvEventos.Rows[index].Cells[indiceColumna].Value = (enElSistema[i].estadoCliente(enElSistema[i].estado) + "(" + enElSistema[i].numero + ")").ToString();

                            int indiceColumna2 = dgvEventos.Columns.Add("HID" + i.ToString(), "HID");
                            dgvEventos.Rows[index].Cells[indiceColumna2].Value = Convert.ToDecimal(enElSistema[i].hora_descarga.ToString()).ToString("N");
                            //dgvEventos.Rows[index].Cells[indiceColumna2].Value = enElSistema[i].hora_descarga.ToString();

                            int indiceColumna3 = dgvEventos.Columns.Add("HIR" + i.ToString(), "HIR");
                            dgvEventos.Rows[index].Cells[indiceColumna3].Value = Convert.ToDecimal(enElSistema[i].hora_revision.ToString()).ToString("N");
                            //dgvEventos.Rows[index].Cells[indiceColumna3].Value = enElSistema[i].hora_revision.ToString();

                            int indiceColumna4 = dgvEventos.Columns.Add("Contenedores" + i.ToString(), "Contenedores");
                            dgvEventos.Rows[index].Cells[indiceColumna4].Value = enElSistema[i].cantidad_contenedores.ToString();

                            //dgvEventos.Columns[indiceColumna2]
                        }
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("CERRAR CON EL ADMINISTRADOR DE TAREAS JA");
            }

            

        }

        public void reiniciar()
        {
            txtSimulaciones.Text = "";
            txtDesde.Text = "";
            txtHasta.Text = "";
            cargarValores();
            dgvEventos.Rows.Clear();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Prueba_Load(object sender, EventArgs e)
        {

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
        }

        public void mostrarPuntos(double acumulador_descargas, int contador_barcos, int contador_8, int contador_fragiles, double acumulador_revision)
        {

            label1.Visible = true;
            label1.Text = acumulador_descargas.ToString("N");

            label2.Visible = true;
            label2.Text = contador_barcos.ToString();

            //label2.Caption = Format(label2.Caption, "#######.00")

            label3.Visible = true;
            label3.Text = contador_8.ToString();

            label4.Visible = true;
            label4.Text = contador_fragiles.ToString();

            label5.Visible = true;
            label5.Text = acumulador_revision.ToString("N");
        }

        private void gpDescripcionRespuesta_Click(object sender, EventArgs e)
        {

        }

        private void dgvEventos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //DataGridViewHeaderCell s = new DataGridViewHeaderCell();
            //s.Style.SelectionBackColor = Color.Blue;
        }

        private void gbAccion_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void gbAccion_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void gbAccion_MouseUp(object sender, MouseEventArgs e)
        {

        }


        // para tp5
        public void MostrarAdvertencia(string advertencia)
        {
            MessageBox.Show(advertencia, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void MostrarError(string error)
        {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dgvEventos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexColumn = e.ColumnIndex;
            int index = e.RowIndex;
            string nombrecolumna = dgvEventos.Columns[indexColumn].Name.ToString();
            //string fila = 
            if (nombrecolumna == "ProximaInterrupcion")
            {
                double reloj80 = gestor.A0;
                ITipoRK tipoRk = new InicioInterrupcion();
                Global.RND = (double)dgvEventos.Rows[index].Cells["Beta"].Value;
                RungeKuttaForm form = new RungeKuttaForm(parametros.hProxInterrupcion, 0.00, reloj80, tipoRk);
                form.Show();
            }
            else if (nombrecolumna == "FinInterrupcionLlegadas")
            {
                double reloj = Convert.ToDouble(dgvEventos.Rows[index].Cells["Reloj"].Value.ToString());
                ITipoRK tipoRk = new FinInterrupcionCliente();
                RungeKuttaForm form = new RungeKuttaForm(parametros.hLlegadas, 0.00, reloj, tipoRk);
                form.Show();
            }
            else if (nombrecolumna == "FinInterrupcionServidor")
            {
                double reloj = Convert.ToDouble(dgvEventos.Rows[index].Cells["Reloj"].Value.ToString());
                ITipoRK tipoRk = new FinInterrupcionVentanilla();
                RungeKuttaForm form = new RungeKuttaForm(parametros.hServidor, 0.00, reloj, tipoRk);
                form.Show();
            }
        }
    }
}
