namespace Practica_3
{
    partial class Form5
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
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblhoras = new System.Windows.Forms.Label();
            this.lblvalordehoras = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.txtvalordehoras = new System.Windows.Forms.TextBox();
            this.grpplanilla = new System.Windows.Forms.GroupBox();
            this.lblsubtotal = new System.Windows.Forms.Label();
            this.lblimpuesto = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.dgvplanilla = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valordehora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.impuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.grpplanilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvplanilla)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(12, 24);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(44, 13);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Text = "Nombre";
            // 
            // lblhoras
            // 
            this.lblhoras.AutoSize = true;
            this.lblhoras.Location = new System.Drawing.Point(12, 59);
            this.lblhoras.Name = "lblhoras";
            this.lblhoras.Size = new System.Drawing.Size(87, 13);
            this.lblhoras.TabIndex = 1;
            this.lblhoras.Text = "Horas trabajadas";
            // 
            // lblvalordehoras
            // 
            this.lblvalordehoras.AutoSize = true;
            this.lblvalordehoras.Location = new System.Drawing.Point(12, 104);
            this.lblvalordehoras.Name = "lblvalordehoras";
            this.lblvalordehoras.Size = new System.Drawing.Size(75, 13);
            this.lblvalordehoras.TabIndex = 2;
            this.lblvalordehoras.Text = "Valor de horas";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(107, 12);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(259, 20);
            this.txtnombre.TabIndex = 3;
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(107, 52);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(100, 20);
            this.txtvalor.TabIndex = 4;
            // 
            // txtvalordehoras
            // 
            this.txtvalordehoras.Location = new System.Drawing.Point(107, 97);
            this.txtvalordehoras.Name = "txtvalordehoras";
            this.txtvalordehoras.Size = new System.Drawing.Size(100, 20);
            this.txtvalordehoras.TabIndex = 5;
            // 
            // grpplanilla
            // 
            this.grpplanilla.Controls.Add(this.lbltotal);
            this.grpplanilla.Controls.Add(this.lblimpuesto);
            this.grpplanilla.Controls.Add(this.lblsubtotal);
            this.grpplanilla.Location = new System.Drawing.Point(395, 326);
            this.grpplanilla.Name = "grpplanilla";
            this.grpplanilla.Size = new System.Drawing.Size(200, 100);
            this.grpplanilla.TabIndex = 6;
            this.grpplanilla.TabStop = false;
            this.grpplanilla.Text = "Total planilla:";
            // 
            // lblsubtotal
            // 
            this.lblsubtotal.AutoSize = true;
            this.lblsubtotal.Location = new System.Drawing.Point(11, 16);
            this.lblsubtotal.Name = "lblsubtotal";
            this.lblsubtotal.Size = new System.Drawing.Size(0, 13);
            this.lblsubtotal.TabIndex = 0;
            // 
            // lblimpuesto
            // 
            this.lblimpuesto.AutoSize = true;
            this.lblimpuesto.Location = new System.Drawing.Point(11, 45);
            this.lblimpuesto.Name = "lblimpuesto";
            this.lblimpuesto.Size = new System.Drawing.Size(0, 13);
            this.lblimpuesto.TabIndex = 1;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(11, 73);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(0, 13);
            this.lbltotal.TabIndex = 2;
            // 
            // dgvplanilla
            // 
            this.dgvplanilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvplanilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.horas,
            this.valordehora,
            this.subtotal,
            this.impuesto,
            this.total});
            this.dgvplanilla.Location = new System.Drawing.Point(15, 158);
            this.dgvplanilla.Name = "dgvplanilla";
            this.dgvplanilla.Size = new System.Drawing.Size(636, 150);
            this.dgvplanilla.TabIndex = 3;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // horas
            // 
            this.horas.HeaderText = "Horas trabajadas";
            this.horas.Name = "horas";
            this.horas.ReadOnly = true;
            // 
            // valordehora
            // 
            this.valordehora.HeaderText = "Valor de horas";
            this.valordehora.Name = "valordehora";
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.Name = "subtotal";
            // 
            // impuesto
            // 
            this.impuesto.HeaderText = "Impuesto";
            this.impuesto.Name = "impuesto";
            this.impuesto.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(328, 97);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(100, 48);
            this.btnagregar.TabIndex = 7;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(51, 326);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 44);
            this.btnlimpiar.TabIndex = 8;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 443);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.dgvplanilla);
            this.Controls.Add(this.grpplanilla);
            this.Controls.Add(this.txtvalordehoras);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lblvalordehoras);
            this.Controls.Add(this.lblhoras);
            this.Controls.Add(this.lblnombre);
            this.Name = "Form5";
            this.Text = "Form5";
            this.grpplanilla.ResumeLayout(false);
            this.grpplanilla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvplanilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblhoras;
        private System.Windows.Forms.Label lblvalordehoras;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.TextBox txtvalordehoras;
        private System.Windows.Forms.GroupBox grpplanilla;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblimpuesto;
        private System.Windows.Forms.Label lblsubtotal;
        private System.Windows.Forms.DataGridView dgvplanilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn horas;
        private System.Windows.Forms.DataGridViewTextBoxColumn valordehora;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn impuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnlimpiar;
    }
}