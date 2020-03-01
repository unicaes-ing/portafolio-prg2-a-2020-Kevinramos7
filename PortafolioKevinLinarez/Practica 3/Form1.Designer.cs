namespace Practica_3
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
            this.lsttabla = new System.Windows.Forms.ListBox();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsttabla
            // 
            this.lsttabla.FormattingEnabled = true;
            this.lsttabla.Location = new System.Drawing.Point(37, 70);
            this.lsttabla.Name = "lsttabla";
            this.lsttabla.Size = new System.Drawing.Size(120, 225);
            this.lsttabla.TabIndex = 0;
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(138, 28);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(100, 20);
            this.txtnumero.TabIndex = 1;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(12, 35);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(95, 13);
            this.lblNumero.TabIndex = 2;
            this.lblNumero.Text = "Nú}mero de tabla: ";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(182, 70);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 3;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 319);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.lsttabla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsttabla;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button btnGenerar;
    }
}

