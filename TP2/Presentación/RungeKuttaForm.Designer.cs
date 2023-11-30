namespace SimTP2Q.Presentación
{
    partial class RungeKuttaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvRK = new System.Windows.Forms.DataGridView();
            this.col_t = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_k1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_k2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_k3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_k4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t_siguiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y_siguiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRK)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRK
            // 
            this.dgvRK.AllowUserToAddRows = false;
            this.dgvRK.AllowUserToDeleteRows = false;
            this.dgvRK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRK.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_t,
            this.col_y,
            this.col_k1,
            this.col_k2,
            this.col_k3,
            this.col_k4,
            this.t_siguiente,
            this.y_siguiente});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRK.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRK.Location = new System.Drawing.Point(0, 0);
            this.dgvRK.Name = "dgvRK";
            this.dgvRK.ReadOnly = true;
            this.dgvRK.RowHeadersWidth = 62;
            this.dgvRK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRK.Size = new System.Drawing.Size(780, 417);
            this.dgvRK.TabIndex = 4;
            // 
            // col_t
            // 
            this.col_t.HeaderText = "t";
            this.col_t.MinimumWidth = 8;
            this.col_t.Name = "col_t";
            this.col_t.ReadOnly = true;
            // 
            // col_y
            // 
            this.col_y.HeaderText = "Y";
            this.col_y.MinimumWidth = 8;
            this.col_y.Name = "col_y";
            this.col_y.ReadOnly = true;
            // 
            // col_k1
            // 
            this.col_k1.HeaderText = "K1";
            this.col_k1.MinimumWidth = 8;
            this.col_k1.Name = "col_k1";
            this.col_k1.ReadOnly = true;
            // 
            // col_k2
            // 
            this.col_k2.HeaderText = "K2";
            this.col_k2.MinimumWidth = 8;
            this.col_k2.Name = "col_k2";
            this.col_k2.ReadOnly = true;
            // 
            // col_k3
            // 
            this.col_k3.HeaderText = "K3";
            this.col_k3.MinimumWidth = 8;
            this.col_k3.Name = "col_k3";
            this.col_k3.ReadOnly = true;
            // 
            // col_k4
            // 
            this.col_k4.HeaderText = "K4";
            this.col_k4.MinimumWidth = 8;
            this.col_k4.Name = "col_k4";
            this.col_k4.ReadOnly = true;
            // 
            // t_siguiente
            // 
            this.t_siguiente.HeaderText = "t(i+1)";
            this.t_siguiente.MinimumWidth = 8;
            this.t_siguiente.Name = "t_siguiente";
            this.t_siguiente.ReadOnly = true;
            // 
            // y_siguiente
            // 
            this.y_siguiente.HeaderText = "Y(i+1)";
            this.y_siguiente.MinimumWidth = 8;
            this.y_siguiente.Name = "y_siguiente";
            this.y_siguiente.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgvRK);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 417);
            this.panel1.TabIndex = 5;
            // 
            // RungeKuttaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 441);
            this.Controls.Add(this.panel1);
            this.Name = "RungeKuttaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RungeKutta";
            this.Load += new System.EventHandler(this.RungeKuttaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRK)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRK;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_t;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_y;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_k1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_k2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_k3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_k4;
        private System.Windows.Forms.DataGridViewTextBoxColumn t_siguiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn y_siguiente;
        private System.Windows.Forms.Panel panel1;
    }
}