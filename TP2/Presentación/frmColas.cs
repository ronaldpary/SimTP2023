using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimTP2Q.Lógica;

namespace SimTP2Q.Presentación
{
    public partial class frmColas : Form
    {
        Parametros parametros = new Parametros();
        //Parametros parametros;
        public frmColas()
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

        private void frmColas_Load(object sender, EventArgs e)
        {

        }

        

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        //private void btnComenzar_Click(object sender, EventArgs e)
        //{
        //    GestorSimulacion gestor = new GestorSimulacion(this);
        //    if (txtSimulaciones.Text != "" && txtDesde.Text != "" && txtHasta.Text != "")
        //    {
        //        int n = Convert.ToInt32(txtSimulaciones.Text);
        //        int desde = Convert.ToInt32(txtDesde.Text);
        //        int hasta = Convert.ToInt32(txtHasta.Text);
        //        dgvEventos.Rows.Clear();
        //        ValidarDatos(parametros);
        //        gestor.iniciarSimulacion(n, this.parametros, desde, hasta);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Complete todos los datos");
        //    }
        //}

        private void ValidarDatos(Parametros parametros)
        {
            if (txtLlegada.Text != "") { parametros.media_llegada = Convert.ToDouble(txtLlegada.Text); }   
            if (txtDescarga.Text != "") { parametros.fin_descarga = Convert.ToDouble(txtDescarga.Text); }
            if (txtRevision.Text != "") { parametros.fin_revision = Convert.ToDouble(txtRevision.Text); }
            if (txtPreparacion.Text != "") { parametros.preparacion_barco = Convert.ToDouble(txtPreparacion.Text); }
        }

        internal void mostrarFila(Simulacion simulacion, List<Cliente> enElSistema, string nombreEvento, List<Cliente> enViaje)
        {
            throw new NotImplementedException();
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {

        }
    }
}
