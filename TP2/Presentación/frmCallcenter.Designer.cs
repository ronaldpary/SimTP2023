namespace SimTP2Q.Presentación
{
    partial class frmCallcenter
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDE = new System.Windows.Forms.TextBox();
            this.txtME = new System.Windows.Forms.TextBox();
            this.dgvMontecarlo = new System.Windows.Forms.DataGridView();
            this.Horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndllamadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadllamadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSimular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConclusion = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvMontecarlo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(153, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Desviación:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(188, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Media:";
            // 
            // txtDE
            // 
            this.txtDE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDE.Location = new System.Drawing.Point(248, 75);
            this.txtDE.Name = "txtDE";
            this.txtDE.Size = new System.Drawing.Size(100, 22);
            this.txtDE.TabIndex = 15;
            // 
            // txtME
            // 
            this.txtME.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtME.Location = new System.Drawing.Point(248, 41);
            this.txtME.Name = "txtME";
            this.txtME.Size = new System.Drawing.Size(100, 22);
            this.txtME.TabIndex = 14;
            // 
            // dgvMontecarlo
            // 
            this.dgvMontecarlo.AllowUserToAddRows = false;
            this.dgvMontecarlo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMontecarlo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Horas,
            this.rndllamadas,
            this.cantidadllamadas});
            this.dgvMontecarlo.Location = new System.Drawing.Point(43, 120);
            this.dgvMontecarlo.Name = "dgvMontecarlo";
            this.dgvMontecarlo.Size = new System.Drawing.Size(305, 258);
            this.dgvMontecarlo.TabIndex = 13;
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
            this.dataGridView1.Location = new System.Drawing.Point(389, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.Size = new System.Drawing.Size(981, 69);
            this.dataGridView1.TabIndex = 21;
            // 
            // btnSimular
            // 
            this.btnSimular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimular.Location = new System.Drawing.Point(778, 73);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(75, 23);
            this.btnSimular.TabIndex = 19;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(573, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Comisión:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtN
            // 
            this.txtN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN.Location = new System.Drawing.Point(654, 74);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(49, 22);
            this.txtN.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(709, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 22);
            this.label4.TabIndex = 22;
            this.label4.Text = "%";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnConclusion
            // 
            this.btnConclusion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConclusion.Location = new System.Drawing.Point(778, 228);
            this.btnConclusion.Name = "btnConclusion";
            this.btnConclusion.Size = new System.Drawing.Size(153, 28);
            this.btnConclusion.TabIndex = 23;
            this.btnConclusion.Text = "Recomendación";
            this.btnConclusion.UseVisualStyleBackColor = true;
            this.btnConclusion.Click += new System.EventHandler(this.btnConclusion_Click);
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
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.ingreso.DefaultCellStyle = dataGridViewCellStyle1;
            this.ingreso.HeaderText = "Ingreso por hora";
            this.ingreso.Name = "ingreso";
            // 
            // frmCallcenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 452);
            this.Controls.Add(this.btnConclusion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSimular);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDE);
            this.Controls.Add(this.txtME);
            this.Controls.Add(this.dgvMontecarlo);
            this.Name = "frmCallcenter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Callcenter";
            this.Load += new System.EventHandler(this.frmCallcenter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMontecarlo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDE;
        private System.Windows.Forms.TextBox txtME;
        private System.Windows.Forms.DataGridView dgvMontecarlo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horas;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndllamadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadllamadas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConclusion;
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
    }
}