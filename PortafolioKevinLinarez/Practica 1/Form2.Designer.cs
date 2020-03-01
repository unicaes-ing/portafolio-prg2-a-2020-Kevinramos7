namespace Practica_1
{
    partial class Form2
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
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnLimp = new System.Windows.Forms.Button();
            this.btnSal = new System.Windows.Forms.Button();
            this.txtDec = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBin = new System.Windows.Forms.TextBox();
            this.txtOct = new System.Windows.Forms.TextBox();
            this.txtHex = new System.Windows.Forms.TextBox();
            this.lblHex = new System.Windows.Forms.Label();
            this.lblBin = new System.Windows.Forms.Label();
            this.lblOct = new System.Windows.Forms.Label();
            this.lblDec = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(29, 259);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 16;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnLimp
            // 
            this.btnLimp.Location = new System.Drawing.Point(126, 259);
            this.btnLimp.Name = "btnLimp";
            this.btnLimp.Size = new System.Drawing.Size(75, 23);
            this.btnLimp.TabIndex = 17;
            this.btnLimp.Text = "Limpiar";
            this.btnLimp.UseVisualStyleBackColor = true;
            this.btnLimp.Click += new System.EventHandler(this.btnLimp_Click);
            // 
            // btnSal
            // 
            this.btnSal.Location = new System.Drawing.Point(224, 259);
            this.btnSal.Name = "btnSal";
            this.btnSal.Size = new System.Drawing.Size(75, 23);
            this.btnSal.TabIndex = 18;
            this.btnSal.Text = "Salir";
            this.btnSal.UseVisualStyleBackColor = true;
            this.btnSal.Click += new System.EventHandler(this.btnSal_Click);
            // 
            // txtDec
            // 
            this.txtDec.Location = new System.Drawing.Point(101, 15);
            this.txtDec.Name = "txtDec";
            this.txtDec.Size = new System.Drawing.Size(100, 20);
            this.txtDec.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBin);
            this.groupBox1.Controls.Add(this.txtOct);
            this.groupBox1.Controls.Add(this.txtHex);
            this.groupBox1.Controls.Add(this.lblHex);
            this.groupBox1.Controls.Add(this.lblBin);
            this.groupBox1.Controls.Add(this.lblOct);
            this.groupBox1.Location = new System.Drawing.Point(29, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 153);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Equivale a:";
            // 
            // txtBin
            // 
            this.txtBin.Location = new System.Drawing.Point(72, 30);
            this.txtBin.Name = "txtBin";
            this.txtBin.ReadOnly = true;
            this.txtBin.Size = new System.Drawing.Size(100, 20);
            this.txtBin.TabIndex = 7;
            // 
            // txtOct
            // 
            this.txtOct.Location = new System.Drawing.Point(72, 65);
            this.txtOct.Name = "txtOct";
            this.txtOct.ReadOnly = true;
            this.txtOct.Size = new System.Drawing.Size(100, 20);
            this.txtOct.TabIndex = 8;
            // 
            // txtHex
            // 
            this.txtHex.Location = new System.Drawing.Point(72, 101);
            this.txtHex.Name = "txtHex";
            this.txtHex.ReadOnly = true;
            this.txtHex.Size = new System.Drawing.Size(100, 20);
            this.txtHex.TabIndex = 9;
            // 
            // lblHex
            // 
            this.lblHex.AutoSize = true;
            this.lblHex.Location = new System.Drawing.Point(6, 101);
            this.lblHex.Name = "lblHex";
            this.lblHex.Size = new System.Drawing.Size(71, 13);
            this.lblHex.TabIndex = 4;
            this.lblHex.Text = "Hexadecimal:";
            // 
            // lblBin
            // 
            this.lblBin.AutoSize = true;
            this.lblBin.Location = new System.Drawing.Point(6, 37);
            this.lblBin.Name = "lblBin";
            this.lblBin.Size = new System.Drawing.Size(42, 13);
            this.lblBin.TabIndex = 2;
            this.lblBin.Text = "Binario:";
            // 
            // lblOct
            // 
            this.lblOct.AutoSize = true;
            this.lblOct.Location = new System.Drawing.Point(6, 72);
            this.lblOct.Name = "lblOct";
            this.lblOct.Size = new System.Drawing.Size(35, 13);
            this.lblOct.TabIndex = 3;
            this.lblOct.Text = "Octal:";
            // 
            // lblDec
            // 
            this.lblDec.AutoSize = true;
            this.lblDec.Location = new System.Drawing.Point(35, 22);
            this.lblDec.Name = "lblDec";
            this.lblDec.Size = new System.Drawing.Size(45, 13);
            this.lblDec.TabIndex = 13;
            this.lblDec.Text = "Decimal";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 306);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnLimp);
            this.Controls.Add(this.btnSal);
            this.Controls.Add(this.txtDec);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDec);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnLimp;
        private System.Windows.Forms.Button btnSal;
        private System.Windows.Forms.TextBox txtDec;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBin;
        private System.Windows.Forms.TextBox txtOct;
        private System.Windows.Forms.TextBox txtHex;
        private System.Windows.Forms.Label lblHex;
        private System.Windows.Forms.Label lblBin;
        private System.Windows.Forms.Label lblOct;
        private System.Windows.Forms.Label lblDec;
    }
}