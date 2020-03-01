namespace Practica_1
{
    partial class Form4
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
            this.btnnew = new System.Windows.Forms.Button();
            this.btncalcular = new System.Windows.Forms.Button();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtimpuesto = new System.Windows.Forms.TextBox();
            this.txtsub = new System.Windows.Forms.TextBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.cboLibros = new System.Windows.Forms.ComboBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblimpuesto = new System.Windows.Forms.Label();
            this.lblsub = new System.Windows.Forms.Label();
            this.lblcant = new System.Windows.Forms.Label();
            this.lblprecio = new System.Windows.Forms.Label();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(222, 286);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 29;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(130, 286);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(75, 23);
            this.btnnew.TabIndex = 28;
            this.btnnew.Text = "Nueva";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(26, 286);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 27;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(145, 236);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(100, 20);
            this.txttotal.TabIndex = 26;
            // 
            // txtimpuesto
            // 
            this.txtimpuesto.Location = new System.Drawing.Point(145, 200);
            this.txtimpuesto.Name = "txtimpuesto";
            this.txtimpuesto.ReadOnly = true;
            this.txtimpuesto.Size = new System.Drawing.Size(100, 20);
            this.txtimpuesto.TabIndex = 25;
            // 
            // txtsub
            // 
            this.txtsub.Location = new System.Drawing.Point(145, 169);
            this.txtsub.Name = "txtsub";
            this.txtsub.ReadOnly = true;
            this.txtsub.Size = new System.Drawing.Size(100, 20);
            this.txtsub.TabIndex = 24;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(105, 78);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(100, 20);
            this.txtcantidad.TabIndex = 23;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(105, 49);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(100, 20);
            this.txtprecio.TabIndex = 22;
            // 
            // cboLibros
            // 
            this.cboLibros.FormattingEnabled = true;
            this.cboLibros.Items.AddRange(new object[] {
            "Buscando a Alaska",
            "Besos de Murcielago",
            "Ciudades de Papel",
            "It (Eso)",
            "Brillaras"});
            this.cboLibros.Location = new System.Drawing.Point(105, 17);
            this.cboLibros.Name = "cboLibros";
            this.cboLibros.Size = new System.Drawing.Size(341, 21);
            this.cboLibros.TabIndex = 21;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(23, 243);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(70, 13);
            this.lbltotal.TabIndex = 20;
            this.lbltotal.Text = "Total a pagar";
            // 
            // lblimpuesto
            // 
            this.lblimpuesto.AutoSize = true;
            this.lblimpuesto.Location = new System.Drawing.Point(23, 207);
            this.lblimpuesto.Name = "lblimpuesto";
            this.lblimpuesto.Size = new System.Drawing.Size(79, 13);
            this.lblimpuesto.TabIndex = 19;
            this.lblimpuesto.Text = "Impuesto (13%)";
            // 
            // lblsub
            // 
            this.lblsub.AutoSize = true;
            this.lblsub.Location = new System.Drawing.Point(23, 176);
            this.lblsub.Name = "lblsub";
            this.lblsub.Size = new System.Drawing.Size(46, 13);
            this.lblsub.TabIndex = 18;
            this.lblsub.Text = "Subtotal";
            // 
            // lblcant
            // 
            this.lblcant.AutoSize = true;
            this.lblcant.Location = new System.Drawing.Point(23, 85);
            this.lblcant.Name = "lblcant";
            this.lblcant.Size = new System.Drawing.Size(49, 13);
            this.lblcant.TabIndex = 17;
            this.lblcant.Text = "Cantidad";
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Location = new System.Drawing.Point(23, 56);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(37, 13);
            this.lblprecio.TabIndex = 16;
            this.lblprecio.Text = "Precio";
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Location = new System.Drawing.Point(23, 20);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(75, 13);
            this.lbltitulo.TabIndex = 15;
            this.lbltitulo.Text = "Titulo del libro:";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 345);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtimpuesto);
            this.Controls.Add(this.txtsub);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.cboLibros);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lblimpuesto);
            this.Controls.Add(this.lblsub);
            this.Controls.Add(this.lblcant);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.lbltitulo);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtimpuesto;
        private System.Windows.Forms.TextBox txtsub;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.ComboBox cboLibros;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblimpuesto;
        private System.Windows.Forms.Label lblsub;
        private System.Windows.Forms.Label lblcant;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.Label lbltitulo;
    }
}