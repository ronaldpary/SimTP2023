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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDE = new System.Windows.Forms.TextBox();
            this.txtME = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelDesde = new System.Windows.Forms.Label();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.btnComparar = new System.Windows.Forms.Button();
            this.dgvFinal = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMontecarlo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(645, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cantidad de horas:";
            // 
            // btnSimular
            // 
            this.btnSimular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimular.Location = new System.Drawing.Point(708, 205);
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
            this.txtN.Location = new System.Drawing.Point(789, 140);
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
            this.dgvMontecarlo.Size = new System.Drawing.Size(305, 146);
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
            this.label4.Location = new System.Drawing.Point(454, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Hasta:";
            // 
            // labelDesde
            // 
            this.labelDesde.AutoSize = true;
            this.labelDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesde.Location = new System.Drawing.Point(454, 108);
            this.labelDesde.Name = "labelDesde";
            this.labelDesde.Size = new System.Drawing.Size(57, 16);
            this.labelDesde.TabIndex = 16;
            this.labelDesde.Text = "Desde:";
            // 
            // txtHasta
            // 
            this.txtHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHasta.Location = new System.Drawing.Point(517, 139);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(100, 22);
            this.txtHasta.TabIndex = 15;
            // 
            // txtDesde
            // 
            this.txtDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesde.Location = new System.Drawing.Point(517, 105);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(100, 22);
            this.txtDesde.TabIndex = 14;
            // 
            // btnComparar
            // 
            this.btnComparar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComparar.Location = new System.Drawing.Point(1022, 205);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(111, 59);
            this.btnComparar.TabIndex = 18;
            this.btnComparar.Text = "Analizar rendimiento Callcenter";
            this.btnComparar.UseVisualStyleBackColor = true;
            this.btnComparar.Click += new System.EventHandler(this.btnComparar_Click);
            // 
            // dgvFinal
            // 
            this.dgvFinal.AllowUserToAddRows = false;
            this.dgvFinal.ColumnHeadersHeight = 40;
            this.dgvFinal.Location = new System.Drawing.Point(38, 279);
            this.dgvFinal.Name = "dgvFinal";
            this.dgvFinal.RowHeadersWidth = 50;
            this.dgvFinal.Size = new System.Drawing.Size(1095, 146);
            this.dgvFinal.TabIndex = 27;
            // 
            // frmMontecarloV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SimTP2Q.Properties.Resources.FONDO_SIM;
            this.ClientSize = new System.Drawing.Size(1169, 499);
            this.Controls.Add(this.dgvFinal);
            this.Controls.Add(this.btnComparar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelDesde);
            this.Controls.Add(this.txtHasta);
            this.Controls.Add(this.txtDesde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDE);
            this.Controls.Add(this.txtME);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSimular);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.dgvMontecarlo);
            this.Name = "frmMontecarloV2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso por la venta de Rifas";
            this.Load += new System.EventHandler(this.frmMontecarloV2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMontecarlo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.DataGridView dgvMontecarlo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDE;
        private System.Windows.Forms.TextBox txtME;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelDesde;
        private System.Windows.Forms.TextBox txtHasta;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horas;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndllamadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadllamadas;
        private System.Windows.Forms.Button btnComparar;
        private System.Windows.Forms.DataGridView dgvFinal;
    }
}