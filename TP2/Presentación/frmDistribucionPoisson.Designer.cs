namespace SimTP2Q.Presentación
{
    partial class frmDistribucionPoisson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDistribucionPoisson));
            this.txtN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMediaLambda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dgvVariables = new System.Windows.Forms.DataGridView();
            this.Nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewPoisson = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.graficoP = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvTablaP = new System.Windows.Forms.DataGridView();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVariables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPoisson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaP)).BeginInit();
            this.SuspendLayout();
            // 
            // txtN
            // 
            this.txtN.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN.Location = new System.Drawing.Point(222, 82);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 30);
            this.txtN.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "n (máximo 50000):";
            // 
            // txtMediaLambda
            // 
            this.txtMediaLambda.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMediaLambda.Location = new System.Drawing.Point(222, 37);
            this.txtMediaLambda.Name = "txtMediaLambda";
            this.txtMediaLambda.Size = new System.Drawing.Size(100, 30);
            this.txtMediaLambda.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Media/Lambda:";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(62, 155);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(114, 37);
            this.btnGenerar.TabIndex = 17;
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
            this.dgvVariables.Location = new System.Drawing.Point(62, 196);
            this.dgvVariables.Name = "dgvVariables";
            this.dgvVariables.ReadOnly = true;
            this.dgvVariables.Size = new System.Drawing.Size(169, 218);
            this.dgvVariables.TabIndex = 16;
            // 
            // Nro
            // 
            this.Nro.HeaderText = "Números";
            this.Nro.Name = "Nro";
            this.Nro.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(306, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 66);
            this.button1.TabIndex = 18;
            this.button1.Text = "Realizar Prueba";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewPoisson
            // 
            this.dataGridViewPoisson.AllowUserToAddRows = false;
            this.dataGridViewPoisson.AllowUserToDeleteRows = false;
            this.dataGridViewPoisson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPoisson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.fo,
            this.fe,
            this.c,
            this.ca});
            this.dataGridViewPoisson.Location = new System.Drawing.Point(445, 241);
            this.dataGridViewPoisson.Name = "dataGridViewPoisson";
            this.dataGridViewPoisson.ReadOnly = true;
            this.dataGridViewPoisson.Size = new System.Drawing.Size(565, 119);
            this.dataGridViewPoisson.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Desde";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
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
            // c
            // 
            this.c.HeaderText = "C";
            this.c.Name = "c";
            this.c.ReadOnly = true;
            // 
            // ca
            // 
            this.ca.HeaderText = "C(ac)";
            this.ca.Name = "ca";
            this.ca.ReadOnly = true;
            // 
            // graficoP
            // 
            chartArea1.Name = "ChartArea1";
            this.graficoP.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.graficoP.Legends.Add(legend1);
            this.graficoP.Location = new System.Drawing.Point(433, 375);
            this.graficoP.Name = "graficoP";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.graficoP.Series.Add(series1);
            this.graficoP.Size = new System.Drawing.Size(667, 262);
            this.graficoP.TabIndex = 27;
            this.graficoP.Text = "chart1";
            // 
            // dgvTablaP
            // 
            this.dgvTablaP.AllowUserToAddRows = false;
            this.dgvTablaP.AllowUserToDeleteRows = false;
            this.dgvTablaP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.valor,
            this.fot,
            this.prob,
            this.fee});
            this.dgvTablaP.Location = new System.Drawing.Point(445, 89);
            this.dgvTablaP.Name = "dgvTablaP";
            this.dgvTablaP.ReadOnly = true;
            this.dgvTablaP.Size = new System.Drawing.Size(468, 133);
            this.dgvTablaP.TabIndex = 28;
            // 
            // valor
            // 
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            // 
            // fot
            // 
            this.fot.HeaderText = "Fo";
            this.fot.Name = "fot";
            this.fot.ReadOnly = true;
            // 
            // prob
            // 
            this.prob.HeaderText = "P()";
            this.prob.Name = "prob";
            this.prob.ReadOnly = true;
            // 
            // fee
            // 
            this.fee.HeaderText = "Fe";
            this.fee.Name = "fee";
            this.fee.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(272, 559);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 36);
            this.button2.TabIndex = 29;
            this.button2.Text = "Conclusión";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmDistribucionPoisson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1094, 683);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvTablaP);
            this.Controls.Add(this.graficoP);
            this.Controls.Add(this.dataGridViewPoisson);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.dgvVariables);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMediaLambda);
            this.Controls.Add(this.label2);
            this.Name = "frmDistribucionPoisson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Distribución Poisson";
            this.Load += new System.EventHandler(this.frmDistribucionPoisson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVariables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPoisson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMediaLambda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataGridView dgvVariables;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewPoisson;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fe;
        private System.Windows.Forms.DataGridViewTextBoxColumn c;
        private System.Windows.Forms.DataGridViewTextBoxColumn ca;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoP;
        private System.Windows.Forms.DataGridView dgvTablaP;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn fot;
        private System.Windows.Forms.DataGridViewTextBoxColumn prob;
        private System.Windows.Forms.DataGridViewTextBoxColumn fee;
        private System.Windows.Forms.Button button2;
    }
}