namespace SimTP2Q
{
    partial class frmVariablesAleatorias
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUf = new System.Windows.Forms.Button();
            this.btExp = new System.Windows.Forms.Button();
            this.btnPs = new System.Windows.Forms.Button();
            this.btNl = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUf
            // 
            this.btnUf.Location = new System.Drawing.Point(218, 160);
            this.btnUf.Name = "btnUf";
            this.btnUf.Size = new System.Drawing.Size(235, 35);
            this.btnUf.TabIndex = 0;
            this.btnUf.Text = "Uniforme";
            this.btnUf.UseVisualStyleBackColor = true;
            this.btnUf.Click += new System.EventHandler(this.btnUf_Click);
            // 
            // btExp
            // 
            this.btExp.Location = new System.Drawing.Point(218, 210);
            this.btExp.Name = "btExp";
            this.btExp.Size = new System.Drawing.Size(235, 35);
            this.btExp.TabIndex = 1;
            this.btExp.Text = "Exponencial";
            this.btExp.UseVisualStyleBackColor = true;
            this.btExp.Click += new System.EventHandler(this.btExp_Click);
            // 
            // btnPs
            // 
            this.btnPs.Location = new System.Drawing.Point(218, 261);
            this.btnPs.Name = "btnPs";
            this.btnPs.Size = new System.Drawing.Size(235, 35);
            this.btnPs.TabIndex = 2;
            this.btnPs.Text = "Poisson";
            this.btnPs.UseVisualStyleBackColor = true;
            this.btnPs.Click += new System.EventHandler(this.btnPs_Click);
            // 
            // btNl
            // 
            this.btNl.Location = new System.Drawing.Point(218, 317);
            this.btNl.Name = "btNl";
            this.btNl.Size = new System.Drawing.Size(235, 35);
            this.btNl.TabIndex = 3;
            this.btNl.Text = "Normal";
            this.btNl.UseVisualStyleBackColor = true;
            this.btNl.Click += new System.EventHandler(this.btNl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Generador de variables aleatorias";
            // 
            // frmVariablesAleatorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btNl);
            this.Controls.Add(this.btnPs);
            this.Controls.Add(this.btExp);
            this.Controls.Add(this.btnUf);
            this.Name = "frmVariablesAleatorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Variables Aleatorias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUf;
        private System.Windows.Forms.Button btExp;
        private System.Windows.Forms.Button btnPs;
        private System.Windows.Forms.Button btNl;
        private System.Windows.Forms.Label label1;
    }
}

