using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimTP2Q.Presentación
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            prueba1.BringToFront();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frmVariablesAleatorias fu = new frmVariablesAleatorias();
            fu.ShowDialog();
            fu.Dispose();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            frmMontecarloV2 fu = new frmMontecarloV2();
            fu.ShowDialog();
            fu.Dispose();
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            Application.Restart();
            //prueba1.reiniciar();
        }

        private void prueba1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
