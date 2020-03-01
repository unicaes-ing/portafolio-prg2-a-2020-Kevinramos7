namespace Practica_1
{
    partial class Form1
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimp = new System.Windows.Forms.Button();
            this.btncalc = new System.Windows.Forms.Button();
            this.txtprom = new System.Windows.Forms.TextBox();
            this.lblProm = new System.Windows.Forms.Label();
            this.txtexa3 = new System.Windows.Forms.TextBox();
            this.txtexa2 = new System.Windows.Forms.TextBox();
            this.txtexa1 = new System.Windows.Forms.TextBox();
            this.lblexa3 = new System.Windows.Forms.Label();
            this.lblexa2 = new System.Windows.Forms.Label();
            this.lblExa1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(261, 179);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 21;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimp
            // 
            this.btnLimp.Location = new System.Drawing.Point(147, 179);
            this.btnLimp.Name = "btnLimp";
            this.btnLimp.Size = new System.Drawing.Size(75, 23);
            this.btnLimp.TabIndex = 20;
            this.btnLimp.Text = "Limpiar";
            this.btnLimp.UseVisualStyleBackColor = true;
            this.btnLimp.Click += new System.EventHandler(this.btnLimp_Click);
            // 
            // btncalc
            // 
            this.btncalc.Location = new System.Drawing.Point(40, 179);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(75, 23);
            this.btncalc.TabIndex = 19;
            this.btncalc.Text = "Calcular";
            this.btncalc.UseVisualStyleBackColor = true;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // txtprom
            // 
            this.txtprom.Location = new System.Drawing.Point(103, 118);
            this.txtprom.Name = "txtprom";
            this.txtprom.ReadOnly = true;
            this.txtprom.Size = new System.Drawing.Size(100, 20);
            this.txtprom.TabIndex = 18;
            // 
            // lblProm
            // 
            this.lblProm.AutoSize = true;
            this.lblProm.Location = new System.Drawing.Point(37, 125);
            this.lblProm.Name = "lblProm";
            this.lblProm.Size = new System.Drawing.Size(51, 13);
            this.lblProm.TabIndex = 17;
            this.lblProm.Text = "Promedio";
            // 
            // txtexa3
            // 
            this.txtexa3.Location = new System.Drawing.Point(103, 70);
            this.txtexa3.Name = "txtexa3";
            this.txtexa3.Size = new System.Drawing.Size(100, 20);
            this.txtexa3.TabIndex = 16;
            // 
            // txtexa2
            // 
            this.txtexa2.Location = new System.Drawing.Point(103, 43);
            this.txtexa2.Name = "txtexa2";
            this.txtexa2.Size = new System.Drawing.Size(100, 20);
            this.txtexa2.TabIndex = 15;
            // 
            // txtexa1
            // 
            this.txtexa1.Location = new System.Drawing.Point(103, 18);
            this.txtexa1.Name = "txtexa1";
            this.txtexa1.Size = new System.Drawing.Size(100, 20);
            this.txtexa1.TabIndex = 14;
            // 
            // lblexa3
            // 
            this.lblexa3.AutoSize = true;
            this.lblexa3.Location = new System.Drawing.Point(37, 70);
            this.lblexa3.Name = "lblexa3";
            this.lblexa3.Size = new System.Drawing.Size(54, 13);
            this.lblexa3.TabIndex = 13;
            this.lblexa3.Text = "Examen 3";
            // 
            // lblexa2
            // 
            this.lblexa2.AutoSize = true;
            this.lblexa2.Location = new System.Drawing.Point(37, 43);
            this.lblexa2.Name = "lblexa2";
            this.lblexa2.Size = new System.Drawing.Size(54, 13);
            this.lblexa2.TabIndex = 12;
            this.lblexa2.Text = "Examen 2";
            // 
            // lblExa1
            // 
            this.lblExa1.AutoSize = true;
            this.lblExa1.Location = new System.Drawing.Point(37, 18);
            this.lblExa1.Name = "lblExa1";
            this.lblExa1.Size = new System.Drawing.Size(54, 13);
            this.lblExa1.TabIndex = 11;
            this.lblExa1.Text = "Examen 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 244);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimp);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.txtprom);
            this.Controls.Add(this.lblProm);
            this.Controls.Add(this.txtexa3);
            this.Controls.Add(this.txtexa2);
            this.Controls.Add(this.txtexa1);
            this.Controls.Add(this.lblexa3);
            this.Controls.Add(this.lblexa2);
            this.Controls.Add(this.lblExa1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimp;
        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.TextBox txtprom;
        private System.Windows.Forms.Label lblProm;
        private System.Windows.Forms.TextBox txtexa3;
        private System.Windows.Forms.TextBox txtexa2;
        private System.Windows.Forms.TextBox txtexa1;
        private System.Windows.Forms.Label lblexa3;
        private System.Windows.Forms.Label lblexa2;
        private System.Windows.Forms.Label lblExa1;
    }
}

