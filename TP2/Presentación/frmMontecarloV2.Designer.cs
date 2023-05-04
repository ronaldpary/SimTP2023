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
            this.ingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDE = new System.Windows.Forms.TextBox();
            this.txtME = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelDesde = new System.Windows.Forms.Label();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.btnComparar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMontecarlo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(605, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cantidad de horas:";
            // 
            // btnSimular
            // 
            this.btnSimular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimular.Location = new System.Drawing.Point(870, 59);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(75, 23);
            this.btnSimular.TabIndex = 6;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // txtN
            // 
            this.txtN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN.Location = new System.Drawing.Point(749, 61);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 22);
            this.txtN.TabIndex = 5;
            // 
            // dgvMontecarlo
            // 
            this.dgvMontecarlo.AllowUserToAddRows = false;
            this.dgvMontecarlo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMontecarlo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Horas,
            this.rndllamadas,
            this.cantidadllamadas});
            this.dgvMontecarlo.Location = new System.Drawing.Point(38, 105);
            this.dgvMontecarlo.Name = "dgvMontecarlo";
            this.dgvMontecarlo.Size = new System.Drawing.Size(305, 258);
            this.dgvMontecarlo.TabIndex = 4;
            // 
            // Horas
            // 
            this.Horas.HeaderText = "Hora";
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
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rndatiende,
            this.atiende,
            this.rndquien,
            this.quien,
            this.rnddemanda,
            this.compra,
            this.rndgasto,
            this.gasto,
            this.acugasto,
            this.ingreso});
            this.dataGridView1.Location = new System.Drawing.Point(416, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.Size = new System.Drawing.Size(1003, 146);
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
            this.atiende.Width = 75;
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
            this.compra.Width = 75;
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
            this.gasto.Width = 75;
            // 
            // acugasto
            // 
            this.acugasto.HeaderText = "Ingreso AC";
            this.acugasto.Name = "acugasto";
            // 
            // ingreso
            // 
            this.ingreso.HeaderText = "Ingreso por hora";
            this.ingreso.Name = "ingreso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Desviación:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(183, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Media:";
            // 
            // txtDE
            // 
            this.txtDE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDE.Location = new System.Drawing.Point(243, 60);
            this.txtDE.Name = "txtDE";
            this.txtDE.Size = new System.Drawing.Size(100, 22);
            this.txtDE.TabIndex = 10;
            // 
            // txtME
            // 
            this.txtME.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtME.Location = new System.Drawing.Point(243, 26);
            this.txtME.Name = "txtME";
            this.txtME.Size = new System.Drawing.Size(100, 22);
            this.txtME.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(414, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Hasta:";
            // 
            // labelDesde
            // 
            this.labelDesde.AutoSize = true;
            this.labelDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesde.Location = new System.Drawing.Point(414, 29);
            this.labelDesde.Name = "labelDesde";
            this.labelDesde.Size = new System.Drawing.Size(57, 16);
            this.labelDesde.TabIndex = 16;
            this.labelDesde.Text = "Desde:";
            // 
            // txtHasta
            // 
            this.txtHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHasta.Location = new System.Drawing.Point(477, 60);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(100, 22);
            this.txtHasta.TabIndex = 15;
            // 
            // txtDesde
            // 
            this.txtDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesde.Location = new System.Drawing.Point(477, 26);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(100, 22);
            this.txtDesde.TabIndex = 14;
            // 
            // btnComparar
            // 
            this.btnComparar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComparar.Location = new System.Drawing.Point(417, 304);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(111, 59);
            this.btnComparar.TabIndex = 18;
            this.btnComparar.Text = "Analizar rendimiento Callcenter";
            this.btnComparar.UseVisualStyleBackColor = true;
            this.btnComparar.Click += new System.EventHandler(this.btnComparar_Click);
            // 
            // frmMontecarloV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SimTP2Q.Properties.Resources.FONDO_SIM;
            this.ClientSize = new System.Drawing.Size(1431, 430);
            this.Controls.Add(this.btnComparar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelDesde);
            this.Controls.Add(this.txtHasta);
            this.Controls.Add(this.txtDesde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDE);
            this.Controls.Add(this.txtME);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSimular);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.dgvMontecarlo);
            this.Name = "frmMontecarloV2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso por la venta de Rifas";
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDE;
        private System.Windows.Forms.TextBox txtME;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelDesde;
        private System.Windows.Forms.TextBox txtHasta;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndatiende;
        private System.Windows.Forms.DataGridViewTextBoxColumn atiende;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndquien;
        private System.Windows.Forms.DataGridViewTextBoxColumn quien;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnddemanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndgasto;
        private System.Windows.Forms.DataGridViewTextBoxColumn gasto;
        private System.Windows.Forms.DataGridViewTextBoxColumn acugasto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horas;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndllamadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadllamadas;
        private System.Windows.Forms.Button btnComparar;
    }
}