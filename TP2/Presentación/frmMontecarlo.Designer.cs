namespace SimTP2Q.Presentación
{
    partial class frmMontecarlo
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
            this.dgvMontecarlo = new System.Windows.Forms.DataGridView();
            this.Horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndllamadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadllamadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndatiende = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atiende = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndquien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnddemanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndgasto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acugasto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtN = new System.Windows.Forms.TextBox();
            this.btnSimular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtME = new System.Windows.Forms.TextBox();
            this.txtDE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMontecarlo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMontecarlo
            // 
            this.dgvMontecarlo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMontecarlo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Horas,
            this.rndllamadas,
            this.cantidadllamadas,
            this.rndatiende,
            this.atiende,
            this.rndquien,
            this.rnddemanda,
            this.compra,
            this.rndgasto,
            this.acugasto});
            this.dgvMontecarlo.Location = new System.Drawing.Point(25, 80);
            this.dgvMontecarlo.Name = "dgvMontecarlo";
            this.dgvMontecarlo.Size = new System.Drawing.Size(1004, 258);
            this.dgvMontecarlo.TabIndex = 0;
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
            this.rndgasto.HeaderText = "Gasto en la rifa";
            this.rndgasto.Name = "rndgasto";
            // 
            // acugasto
            // 
            this.acugasto.HeaderText = "Acumulador Gasto";
            this.acugasto.Name = "acugasto";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(388, 46);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 20);
            this.txtN.TabIndex = 1;
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(563, 44);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(75, 23);
            this.btnSimular.TabIndex = 2;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cantidad de horas:";
            // 
            // txtME
            // 
            this.txtME.Location = new System.Drawing.Point(149, 12);
            this.txtME.Name = "txtME";
            this.txtME.Size = new System.Drawing.Size(100, 20);
            this.txtME.TabIndex = 4;
            // 
            // txtDE
            // 
            this.txtDE.Location = new System.Drawing.Point(149, 46);
            this.txtDE.Name = "txtDE";
            this.txtDE.Size = new System.Drawing.Size(100, 20);
            this.txtDE.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Media:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Desviación:";
            // 
            // frmMontecarlo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDE);
            this.Controls.Add(this.txtME);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSimular);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.dgvMontecarlo);
            this.Name = "frmMontecarlo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rifas";
            this.Load += new System.EventHandler(this.frmMontecarlo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMontecarlo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMontecarlo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horas;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndllamadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadllamadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndatiende;
        private System.Windows.Forms.DataGridViewTextBoxColumn atiende;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndquien;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnddemanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndgasto;
        private System.Windows.Forms.DataGridViewTextBoxColumn acugasto;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtME;
        private System.Windows.Forms.TextBox txtDE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}