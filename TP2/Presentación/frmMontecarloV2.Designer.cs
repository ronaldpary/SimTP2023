namespace SimTP2Q.Presentación
{
    partial class frmMontecarloV2
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSimular = new System.Windows.Forms.Button();
            this.txtN = new System.Windows.Forms.TextBox();
            this.dgvMontecarlo = new System.Windows.Forms.DataGridView();
            this.Horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndllamadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadllamadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rndatiende = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atiende = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndquien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnddemanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndgasto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gasto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acugasto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMontecarlo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cantidad de horas:";
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(326, 52);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(75, 23);
            this.btnSimular.TabIndex = 6;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(205, 54);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 20);
            this.txtN.TabIndex = 5;
            // 
            // dgvMontecarlo
            // 
            this.dgvMontecarlo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMontecarlo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Horas,
            this.rndllamadas,
            this.cantidadllamadas});
            this.dgvMontecarlo.Location = new System.Drawing.Point(35, 105);
            this.dgvMontecarlo.Name = "dgvMontecarlo";
            this.dgvMontecarlo.Size = new System.Drawing.Size(308, 258);
            this.dgvMontecarlo.TabIndex = 4;
            // 
            // Horas
            // 
            this.Horas.HeaderText = "Horas";
            this.Horas.Name = "Horas";
            this.Horas.Width = 40;
            // 
            // rndllamadas
            // 
            this.rndllamadas.HeaderText = "Rnd llamadas";
            this.rndllamadas.Name = "rndllamadas";
            // 
            // cantidadllamadas
            // 
            this.cantidadllamadas.HeaderText = "Cantidad de llamadas";
            this.cantidadllamadas.Name = "cantidadllamadas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rndatiende,
            this.atiende,
            this.rndquien,
            this.quien,
            this.rnddemanda,
            this.compra,
            this.rndgasto,
            this.gasto,
            this.acugasto});
            this.dataGridView1.Location = new System.Drawing.Point(416, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(971, 258);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // rndatiende
            // 
            this.rndatiende.HeaderText = "Rnd atencion";
            this.rndatiende.Name = "rndatiende";
            // 
            // atiende
            // 
            this.atiende.HeaderText = "¿Atiende?";
            this.atiende.Name = "atiende";
            // 
            // rndquien
            // 
            this.rndquien.HeaderText = "Rnd quien";
            this.rndquien.Name = "rndquien";
            // 
            // quien
            // 
            this.quien.HeaderText = "¿Quien?";
            this.quien.Name = "quien";
            // 
            // rnddemanda
            // 
            this.rnddemanda.HeaderText = "Rnd compra";
            this.rnddemanda.Name = "rnddemanda";
            // 
            // compra
            // 
            this.compra.HeaderText = "¿Compra?";
            this.compra.Name = "compra";
            // 
            // rndgasto
            // 
            this.rndgasto.HeaderText = "Rnd gasto";
            this.rndgasto.Name = "rndgasto";
            // 
            // gasto
            // 
            this.gasto.HeaderText = "Gasto en la rifa";
            this.gasto.Name = "gasto";
            // 
            // acugasto
            // 
            this.acugasto.HeaderText = "Acumulador Gasto";
            this.acugasto.Name = "acugasto";
            // 
            // frmMontecarloV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1431, 478);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSimular);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.dgvMontecarlo);
            this.Name = "frmMontecarloV2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMontecarloV2";
            this.Load += new System.EventHandler(this.frmMontecarloV2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMontecarlo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.DataGridView dgvMontecarlo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horas;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndllamadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadllamadas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndatiende;
        private System.Windows.Forms.DataGridViewTextBoxColumn atiende;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndquien;
        private System.Windows.Forms.DataGridViewTextBoxColumn quien;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnddemanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndgasto;
        private System.Windows.Forms.DataGridViewTextBoxColumn gasto;
        private System.Windows.Forms.DataGridViewTextBoxColumn acugasto;
    }
}