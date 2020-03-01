namespace Practica_2
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
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnconv = new System.Windows.Forms.Button();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.lblromano = new System.Windows.Forms.Label();
            this.lblnum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(185, 60);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 9;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnconv
            // 
            this.btnconv.Location = new System.Drawing.Point(185, 12);
            this.btnconv.Name = "btnconv";
            this.btnconv.Size = new System.Drawing.Size(75, 23);
            this.btnconv.TabIndex = 8;
            this.btnconv.Text = "Convertir";
            this.btnconv.UseVisualStyleBackColor = true;
            this.btnconv.Click += new System.EventHandler(this.btnconv_Click);
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(74, 12);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(100, 20);
            this.txtnum.TabIndex = 7;
            // 
            // lblromano
            // 
            this.lblromano.AutoSize = true;
            this.lblromano.Location = new System.Drawing.Point(24, 70);
            this.lblromano.Name = "lblromano";
            this.lblromano.Size = new System.Drawing.Size(0, 13);
            this.lblromano.TabIndex = 6;
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Location = new System.Drawing.Point(24, 15);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(44, 13);
            this.lblnum.TabIndex = 5;
            this.lblnum.Text = "Numero";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 108);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnconv);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.lblromano);
            this.Controls.Add(this.lblnum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnconv;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Label lblromano;
        private System.Windows.Forms.Label lblnum;
    }
}

