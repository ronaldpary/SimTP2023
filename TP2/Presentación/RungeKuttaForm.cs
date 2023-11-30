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
    public partial class RungeKuttaForm : Form
    {
        public RungeKuttaForm(double h, double t0, double Y0, ITipoRK tipoRk)
        {
            InitializeComponent();

            //ITipoRK inicioInterr = new InicioInterrupcion(); // Acá pueden crear una instancia según el RK requerido:
            // 1) InicioInterrupcion, 2) FinInterrupcionCliente, 3) FinInterrupcionVentanilla

            // El RND "Beta" se modifica desde la clase "Global"

            RungeKutta rk = new RungeKutta(h, t0, Y0, tipoRk, this); //double h, double to, double Yo, ITipoRK inicioInterr

            rk.calcularRK();
        }

        public void mostrarFila(double[] fila)
        {
            dgvRK.Rows.Add(fila[0], fila[1], fila[2], fila[3], fila[4], fila[5], fila[6], fila[7]);
        }

        private void RungeKuttaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
