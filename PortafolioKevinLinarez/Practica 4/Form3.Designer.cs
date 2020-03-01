namespace Practica_4
{
    partial class Form3
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
            this.lblnumero = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.txtfibo = new System.Windows.Forms.TextBox();
            this.lblfibonacci = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.Location = new System.Drawing.Point(12, 38);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(44, 13);
            this.lblnumero.TabIndex = 0;
            this.lblnumero.Text = "Número";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(99, 31);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(100, 20);
            this.txtnumero.TabIndex = 1;
            // 
            // txtfibo
            // 
            this.txtfibo.Location = new System.Drawing.Point(99, 107);
            this.txtfibo.Name = "txtfibo";
            this.txtfibo.Size = new System.Drawing.Size(100, 20);
            this.txtfibo.TabIndex = 2;
            // 
            // lblfibonacci
            // 
            this.lblfibonacci.AutoSize = true;
            this.lblfibonacci.Location = new System.Drawing.Point(12, 107);
            this.lblfibonacci.Name = "lblfibonacci";
            this.lblfibonacci.Size = new System.Drawing.Size(53, 13);
            this.lblfibonacci.TabIndex = 3;
            this.lblfibonacci.Text = "Fibonacci";
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(99, 71);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 4;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 172);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.lblfibonacci);
            this.Controls.Add(this.txtfibo);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.lblnumero);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.TextBox txtfibo;
        private System.Windows.Forms.Label lblfibonacci;
        private System.Windows.Forms.Button btncalcular;
    }
}