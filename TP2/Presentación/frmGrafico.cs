using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;

namespace SimTP2Q.Presentación
{
    public partial class frmGrafico : Form
    {
        public frmGrafico()
        {
            InitializeComponent();
        }
        public frmGrafico(List<float> list)
        {
            InitializeComponent();
            
            for (int i = 0; i < list.Count -1; i++)
            {
                chart2.Series["F1"].Points.AddXY(list[i]);
            }


        }


        private void frmGrafico_Load(object sender, EventArgs e)
        {
            chart2.Titles.Add("Histograma");
        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {

            
        }
    }
}
