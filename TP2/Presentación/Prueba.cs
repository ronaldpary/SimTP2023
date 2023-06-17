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
using SimTP2Q.Lógica;

namespace SimTP2Q.Presentación
{
    public partial class Prueba : UserControl
    {
        Parametros parametros = new Parametros();
        //Parametros parametros;
        public Prueba()
        {
            InitializeComponent();
            cargarValores();
        }
        private void cargarValores()
        {
            txtLlegada.Text = this.parametros.media_llegada.ToString();
            txtRevision.Text = this.parametros.fin_revision.ToString();
            txtDescarga.Text = this.parametros.fin_descarga.ToString();
            txtPreparacion.Text = this.parametros.preparacion_barco.ToString();
        }

        //private void frmColas_Load(object sender, EventArgs e)
        //{

        //}



        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnComenzar_Click_1(object sender, EventArgs e)
        {
            GestorSimulacion gestor = new GestorSimulacion(this);
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
                dgvEventos.Rows[(hasta-desde) + 2].DefaultCellStyle.BackColor = Color.Yellow;
                //dgvEventos.Rows[-1].Cells[0].Style.BackColor = Color.Blue;

            }
            else
            {
                MessageBox.Show("Complete todos los datos");
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
            int index = dgvEventos.Rows.Add();

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
                        if (valor == 2)
                        {
                            string estado = "Lleno";
                            dgvEventos.Rows[index].Cells[nombreAtributo].Value = estado;
                        }
                        else
                        {
                            string estado = valor == 0 ? "Libre" : "Ocupado";
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
                        
                        dgvEventos.Rows[index].Cells["HIR" + i.ToString()].Value = Convert.ToDecimal(enElSistema[i].hora_revision.ToString()).ToString("N");
                        dgvEventos.Rows[index].Cells["Contenedores" + i.ToString()].Value = enElSistema[i].cantidad_contenedores.ToString();
                    }
                    else
                    {
                        int indiceColumna = dgvEventos.Columns.Add("Estado" + i.ToString(), "Estado");
                        dgvEventos.Rows[index].Cells[indiceColumna].Value = (enElSistema[i].estadoCliente(enElSistema[i].estado) + "(" + enElSistema[i].numero + ")").ToString();

                        int indiceColumna2 = dgvEventos.Columns.Add("HID" + i.ToString(), "HID");
                        dgvEventos.Rows[index].Cells[indiceColumna2].Value = Convert.ToDecimal(enElSistema[i].hora_descarga.ToString()).ToString("N");

                        int indiceColumna3 = dgvEventos.Columns.Add("HIR" + i.ToString(), "HIR");
                        dgvEventos.Rows[index].Cells[indiceColumna3].Value = Convert.ToDecimal(enElSistema[i].hora_revision.ToString()).ToString("N");

                        int indiceColumna4 = dgvEventos.Columns.Add("Contenedores" + i.ToString(), "Contenedores");
                        dgvEventos.Rows[index].Cells[indiceColumna4].Value = enElSistema[i].cantidad_contenedores.ToString();
                    }
                }

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
    }
}
