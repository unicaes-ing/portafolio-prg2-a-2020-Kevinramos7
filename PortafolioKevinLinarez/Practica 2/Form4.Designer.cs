namespace Practica_2
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
            this.txtconfirmacion = new System.Windows.Forms.TextBox();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.txtconfirmar = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.lblcontraseña = new System.Windows.Forms.Label();
            this.lblcorreo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtconfirmacion
            // 
            this.txtconfirmacion.Location = new System.Drawing.Point(128, 92);
            this.txtconfirmacion.Name = "txtconfirmacion";
            this.txtconfirmacion.Size = new System.Drawing.Size(100, 20);
            this.txtconfirmacion.TabIndex = 18;
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Location = new System.Drawing.Point(128, 57);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(100, 20);
            this.txtcontraseña.TabIndex = 17;
            // 
            // txtconfirmar
            // 
            this.txtconfirmar.AutoSize = true;
            this.txtconfirmar.Location = new System.Drawing.Point(15, 99);
            this.txtconfirmar.Name = "txtconfirmar";
            this.txtconfirmar.Size = new System.Drawing.Size(107, 13);
            this.txtconfirmar.TabIndex = 16;
            this.txtconfirmar.Text = "Confirmar contraseña";
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(208, 153);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 15;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(89, 153);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 23);
            this.btnaceptar.TabIndex = 14;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(128, 25);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(301, 20);
            this.txtcorreo.TabIndex = 13;
            // 
            // lblcontraseña
            // 
            this.lblcontraseña.AutoSize = true;
            this.lblcontraseña.Location = new System.Drawing.Point(15, 64);
            this.lblcontraseña.Name = "lblcontraseña";
            this.lblcontraseña.Size = new System.Drawing.Size(61, 13);
            this.lblcontraseña.TabIndex = 12;
            this.lblcontraseña.Text = "Contraseña";
            // 
            // lblcorreo
            // 
            this.lblcorreo.AutoSize = true;
            this.lblcorreo.Location = new System.Drawing.Point(15, 32);
            this.lblcorreo.Name = "lblcorreo";
            this.lblcorreo.Size = new System.Drawing.Size(93, 13);
            this.lblcorreo.TabIndex = 11;
            this.lblcorreo.Text = "Correo electrónico";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 207);
            this.Controls.Add(this.txtconfirmacion);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.txtconfirmar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.lblcontraseña);
            this.Controls.Add(this.lblcorreo);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtconfirmacion;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.Label txtconfirmar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.Label lblcontraseña;
        private System.Windows.Forms.Label lblcorreo;
    }
}