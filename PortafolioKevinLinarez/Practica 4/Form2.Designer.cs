namespace Practica_4
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
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.lstlista = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(205, 11);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 0;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(205, 284);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 1;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(21, 22);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 2;
            this.lblNumero.Text = "Número";
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Location = new System.Drawing.Point(202, 220);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(88, 13);
            this.lblbuscar.TabIndex = 3;
            this.lblbuscar.Text = "Número a buscar";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(77, 14);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(100, 20);
            this.txtnumero.TabIndex = 4;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(205, 246);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(100, 20);
            this.txtbuscar.TabIndex = 5;
            // 
            // lstlista
            // 
            this.lstlista.FormattingEnabled = true;
            this.lstlista.Location = new System.Drawing.Point(24, 52);
            this.lstlista.Name = "lstlista";
            this.lstlista.Size = new System.Drawing.Size(153, 251);
            this.lstlista.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 329);
            this.Controls.Add(this.lstlista);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.lblbuscar);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btnagregar);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.ListBox lstlista;
    }
}