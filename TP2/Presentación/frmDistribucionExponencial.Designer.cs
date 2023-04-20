namespace SimTP2Q.Presentación
{
    partial class frmDistribucionExponencial
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDistribucionExponencial));
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dgvVariables = new System.Windows.Forms.DataGridView();
            this.Nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLambda = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.graficoEX = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvKSEx = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.po = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pomenospe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.max = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pcmc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PcPac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FeE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVariables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoEX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKSEx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(67, 178);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(114, 38);
            this.btnGenerar.TabIndex = 11;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // dgvVariables
            // 
            this.dgvVariables.AllowUserToAddRows = false;
            this.dgvVariables.AllowUserToDeleteRows = false;
            this.dgvVariables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVariables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nro});
            this.dgvVariables.Location = new System.Drawing.Point(67, 222);
            this.dgvVariables.Name = "dgvVariables";
            this.dgvVariables.ReadOnly = true;
            this.dgvVariables.Size = new System.Drawing.Size(169, 233);
            this.dgvVariables.TabIndex = 10;
            // 
            // Nro
            // 
            this.Nro.HeaderText = "Números";
            this.Nro.Name = "Nro";
            this.Nro.ReadOnly = true;
            // 
            // txtN
            // 
            this.txtN.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN.Location = new System.Drawing.Point(222, 89);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 30);
            this.txtN.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "n (máximo 50000):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Lambda:";
            // 
            // txtLambda
            // 
            this.txtLambda.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLambda.Location = new System.Drawing.Point(222, 43);
            this.txtLambda.Name = "txtLambda";
            this.txtLambda.Size = new System.Drawing.Size(100, 30);
            this.txtLambda.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(315, 671);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 36);
            this.button2.TabIndex = 20;
            this.button2.Text = "Conclusión";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // graficoEX
            // 
            chartArea1.Name = "ChartArea1";
            this.graficoEX.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.graficoEX.Legends.Add(legend1);
            this.graficoEX.Location = new System.Drawing.Point(467, 498);
            this.graficoEX.Name = "graficoEX";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.graficoEX.Series.Add(series1);
            this.graficoEX.Size = new System.Drawing.Size(667, 262);
            this.graficoEX.TabIndex = 19;
            this.graficoEX.Text = "chart1";
            // 
            // dgvKSEx
            // 
            this.dgvKSEx.AllowUserToAddRows = false;
            this.dgvKSEx.AllowUserToDeleteRows = false;
            this.dgvKSEx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKSEx.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Hasta,
            this.fo,
            this.fe,
            this.po,
            this.pe,
            this.poac,
            this.peac,
            this.Pomenospe,
            this.max});
            this.dgvKSEx.Location = new System.Drawing.Point(467, 346);
            this.dgvKSEx.Name = "dgvKSEx";
            this.dgvKSEx.ReadOnly = true;
            this.dgvKSEx.Size = new System.Drawing.Size(667, 133);
            this.dgvKSEx.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Desde";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Hasta
            // 
            this.Hasta.HeaderText = "Hasta";
            this.Hasta.Name = "Hasta";
            this.Hasta.ReadOnly = true;
            // 
            // fo
            // 
            this.fo.HeaderText = "Fo";
            this.fo.Name = "fo";
            this.fo.ReadOnly = true;
            // 
            // fe
            // 
            this.fe.HeaderText = "Fe";
            this.fe.Name = "fe";
            this.fe.ReadOnly = true;
            // 
            // po
            // 
            this.po.HeaderText = "Po ()";
            this.po.Name = "po";
            this.po.ReadOnly = true;
            // 
            // pe
            // 
            this.pe.HeaderText = "Pe ()";
            this.pe.Name = "pe";
            this.pe.ReadOnly = true;
            // 
            // poac
            // 
            this.poac.HeaderText = "Po() AC";
            this.poac.Name = "poac";
            this.poac.ReadOnly = true;
            // 
            // peac
            // 
            this.peac.HeaderText = "Pe() AC";
            this.peac.Name = "peac";
            this.peac.ReadOnly = true;
            // 
            // Pomenospe
            // 
            this.Pomenospe.HeaderText = "|Po(AC)-Pe(AC)|";
            this.Pomenospe.Name = "Pomenospe";
            this.Pomenospe.ReadOnly = true;
            // 
            // max
            // 
            this.max.HeaderText = "Max";
            this.max.Name = "max";
            this.max.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(530, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "Cantidad de intervalos: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "5",
            "8",
            "10",
            "12",
            "15"});
            this.comboBox1.Location = new System.Drawing.Point(756, 139);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(350, 414);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 65);
            this.button3.TabIndex = 15;
            this.button3.Text = "Realizar Prueba";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgvTabla
            // 
            this.dgvTabla.AllowUserToAddRows = false;
            this.dgvTabla.AllowUserToDeleteRows = false;
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Marca,
            this.FoE,
            this.Pcmc,
            this.PcPac,
            this.FeE});
            this.dgvTabla.Location = new System.Drawing.Point(467, 178);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.ReadOnly = true;
            this.dgvTabla.Size = new System.Drawing.Size(667, 133);
            this.dgvTabla.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Desde";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Hasta";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // FoE
            // 
            this.FoE.HeaderText = "Fo";
            this.FoE.Name = "FoE";
            this.FoE.ReadOnly = true;
            // 
            // Pcmc
            // 
            this.Pcmc.HeaderText = "P () c/mc";
            this.Pcmc.Name = "Pcmc";
            this.Pcmc.ReadOnly = true;
            // 
            // PcPac
            // 
            this.PcPac.HeaderText = "P () c/Pac";
            this.PcPac.Name = "PcPac";
            this.PcPac.ReadOnly = true;
            // 
            // FeE
            // 
            this.FeE.HeaderText = "Fe";
            this.FeE.Name = "FeE";
            this.FeE.ReadOnly = true;
            // 
            // frmDistribucionExponencial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1165, 766);
            this.Controls.Add(this.dgvTabla);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.graficoEX);
            this.Controls.Add(this.dgvKSEx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLambda);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.dgvVariables);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label3);
            this.Name = "frmDistribucionExponencial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Distribución Exponencial";
            this.Load += new System.EventHandler(this.frmDistribucionExponencial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVariables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoEX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKSEx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataGridView dgvVariables;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLambda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoEX;
        private System.Windows.Forms.DataGridView dgvKSEx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pcmc;
        private System.Windows.Forms.DataGridViewTextBoxColumn PcPac;
        private System.Windows.Forms.DataGridViewTextBoxColumn FeE;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn fo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fe;
        private System.Windows.Forms.DataGridViewTextBoxColumn po;
        private System.Windows.Forms.DataGridViewTextBoxColumn pe;
        private System.Windows.Forms.DataGridViewTextBoxColumn poac;
        private System.Windows.Forms.DataGridViewTextBoxColumn peac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pomenospe;
        private System.Windows.Forms.DataGridViewTextBoxColumn max;
    }
}