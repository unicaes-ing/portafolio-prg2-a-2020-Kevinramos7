namespace Practica_2
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
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnlimp = new System.Windows.Forms.Button();
            this.btncalc = new System.Windows.Forms.Button();
            this.grpDesc = new System.Windows.Forms.GroupBox();
            this.rdodesc5 = new System.Windows.Forms.RadioButton();
            this.rdodesc4 = new System.Windows.Forms.RadioButton();
            this.rdodesc3 = new System.Windows.Forms.RadioButton();
            this.rdodesc2 = new System.Windows.Forms.RadioButton();
            this.rdodesc1 = new System.Windows.Forms.RadioButton();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtcant = new System.Windows.Forms.TextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lbldesc = new System.Windows.Forms.Label();
            this.lblprecio = new System.Windows.Forms.Label();
            this.lblcant = new System.Windows.Forms.Label();
            this.grpDesc.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(211, 259);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 23;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnlimp
            // 
            this.btnlimp.Location = new System.Drawing.Point(103, 259);
            this.btnlimp.Name = "btnlimp";
            this.btnlimp.Size = new System.Drawing.Size(75, 23);
            this.btnlimp.TabIndex = 22;
            this.btnlimp.Text = "Limpiar";
            this.btnlimp.UseVisualStyleBackColor = true;
            this.btnlimp.Click += new System.EventHandler(this.btnlimp_Click);
            // 
            // btncalc
            // 
            this.btncalc.Location = new System.Drawing.Point(103, 106);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(75, 23);
            this.btncalc.TabIndex = 21;
            this.btncalc.Text = "Calcular";
            this.btncalc.UseVisualStyleBackColor = true;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // grpDesc
            // 
            this.grpDesc.Controls.Add(this.rdodesc5);
            this.grpDesc.Controls.Add(this.rdodesc4);
            this.grpDesc.Controls.Add(this.rdodesc3);
            this.grpDesc.Controls.Add(this.rdodesc2);
            this.grpDesc.Controls.Add(this.rdodesc1);
            this.grpDesc.Location = new System.Drawing.Point(257, 18);
            this.grpDesc.Name = "grpDesc";
            this.grpDesc.Size = new System.Drawing.Size(100, 147);
            this.grpDesc.TabIndex = 13;
            this.grpDesc.TabStop = false;
            this.grpDesc.Text = "Descuentos";
            // 
            // rdodesc5
            // 
            this.rdodesc5.AutoSize = true;
            this.rdodesc5.Location = new System.Drawing.Point(6, 117);
            this.rdodesc5.Name = "rdodesc5";
            this.rdodesc5.Size = new System.Drawing.Size(45, 17);
            this.rdodesc5.TabIndex = 4;
            this.rdodesc5.TabStop = true;
            this.rdodesc5.Text = "20%";
            this.rdodesc5.UseVisualStyleBackColor = true;
            // 
            // rdodesc4
            // 
            this.rdodesc4.AutoSize = true;
            this.rdodesc4.Location = new System.Drawing.Point(6, 94);
            this.rdodesc4.Name = "rdodesc4";
            this.rdodesc4.Size = new System.Drawing.Size(45, 17);
            this.rdodesc4.TabIndex = 3;
            this.rdodesc4.TabStop = true;
            this.rdodesc4.Text = "15%";
            this.rdodesc4.UseVisualStyleBackColor = true;
            // 
            // rdodesc3
            // 
            this.rdodesc3.AutoSize = true;
            this.rdodesc3.Location = new System.Drawing.Point(6, 71);
            this.rdodesc3.Name = "rdodesc3";
            this.rdodesc3.Size = new System.Drawing.Size(45, 17);
            this.rdodesc3.TabIndex = 2;
            this.rdodesc3.TabStop = true;
            this.rdodesc3.Text = "10%";
            this.rdodesc3.UseVisualStyleBackColor = true;
            // 
            // rdodesc2
            // 
            this.rdodesc2.AutoSize = true;
            this.rdodesc2.Location = new System.Drawing.Point(6, 48);
            this.rdodesc2.Name = "rdodesc2";
            this.rdodesc2.Size = new System.Drawing.Size(39, 17);
            this.rdodesc2.TabIndex = 1;
            this.rdodesc2.TabStop = true;
            this.rdodesc2.Text = "5%";
            this.rdodesc2.UseVisualStyleBackColor = true;
            // 
            // rdodesc1
            // 
            this.rdodesc1.AutoSize = true;
            this.rdodesc1.Location = new System.Drawing.Point(6, 25);
            this.rdodesc1.Name = "rdodesc1";
            this.rdodesc1.Size = new System.Drawing.Size(39, 17);
            this.rdodesc1.TabIndex = 0;
            this.rdodesc1.TabStop = true;
            this.rdodesc1.Text = "0%";
            this.rdodesc1.UseVisualStyleBackColor = true;
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(103, 215);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(100, 20);
            this.txttotal.TabIndex = 20;
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(103, 168);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.ReadOnly = true;
            this.txtdesc.Size = new System.Drawing.Size(100, 20);
            this.txtdesc.TabIndex = 19;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(103, 60);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(100, 20);
            this.txtprecio.TabIndex = 18;
            // 
            // txtcant
            // 
            this.txtcant.Location = new System.Drawing.Point(103, 11);
            this.txtcant.Name = "txtcant";
            this.txtcant.Size = new System.Drawing.Size(100, 20);
            this.txtcant.TabIndex = 17;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(28, 222);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(31, 13);
            this.lbltotal.TabIndex = 16;
            this.lbltotal.Text = "Total";
            // 
            // lbldesc
            // 
            this.lbldesc.AutoSize = true;
            this.lbldesc.Location = new System.Drawing.Point(28, 175);
            this.lbldesc.Name = "lbldesc";
            this.lbldesc.Size = new System.Drawing.Size(59, 13);
            this.lbldesc.TabIndex = 15;
            this.lbldesc.Text = "Descuento";
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Location = new System.Drawing.Point(28, 67);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(37, 13);
            this.lblprecio.TabIndex = 14;
            this.lblprecio.Text = "Precio";
            // 
            // lblcant
            // 
            this.lblcant.AutoSize = true;
            this.lblcant.Location = new System.Drawing.Point(28, 18);
            this.lblcant.Name = "lblcant";
            this.lblcant.Size = new System.Drawing.Size(49, 13);
            this.lblcant.TabIndex = 12;
            this.lblcant.Text = "Cantidad";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 297);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnlimp);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.grpDesc);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtdesc);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtcant);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lbldesc);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.lblcant);
            this.Name = "Form2";
            this.Text = "Form2";
            this.grpDesc.ResumeLayout(false);
            this.grpDesc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnlimp;
        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.GroupBox grpDesc;
        private System.Windows.Forms.RadioButton rdodesc5;
        private System.Windows.Forms.RadioButton rdodesc4;
        private System.Windows.Forms.RadioButton rdodesc3;
        private System.Windows.Forms.RadioButton rdodesc2;
        private System.Windows.Forms.RadioButton rdodesc1;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtcant;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lbldesc;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.Label lblcant;
    }
}