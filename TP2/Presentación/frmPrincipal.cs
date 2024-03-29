﻿using System;
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
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
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
            // prueba1.reiniciar();
        }

        private void prueba1_Load(object sender, EventArgs e)
        {
            //var bounds = Screen.FromControl(this).Bounds;
            //this.Width = bounds.Width - 100;
            //this.Height = bounds.Height - 100;
            //this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //bool var = false;

        int m, mx, my;
        private void guna2Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            //var = true;
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void prueba1_Load_1(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_MouseMove(object sender, MouseEventArgs e)
        {
            //if (var == true)
            //{
            //    this.Location = Cursor.Position;
            //}

            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }

        }

        private void guna2Panel2_MouseUp(object sender, MouseEventArgs e)
        {
            //var = false;

            m = 0;
        }
    }
}
