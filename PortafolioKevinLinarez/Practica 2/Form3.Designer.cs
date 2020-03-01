namespace Practica_2
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
            this.grpA = new System.Windows.Forms.GroupBox();
            this.rdoPulgadas2 = new System.Windows.Forms.RadioButton();
            this.rdoPies2 = new System.Windows.Forms.RadioButton();
            this.rdoYardas2 = new System.Windows.Forms.RadioButton();
            this.grpDe = new System.Windows.Forms.GroupBox();
            this.rdoYardas = new System.Windows.Forms.RadioButton();
            this.rdoPies = new System.Windows.Forms.RadioButton();
            this.rdoPulgadas = new System.Windows.Forms.RadioButton();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnconvertir = new System.Windows.Forms.Button();
            this.txtConversion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtlongitud = new System.Windows.Forms.TextBox();
            this.lbllongitudconvertir = new System.Windows.Forms.Label();
            this.grpA.SuspendLayout();
            this.grpDe.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpA
            // 
            this.grpA.Controls.Add(this.rdoPulgadas2);
            this.grpA.Controls.Add(this.rdoPies2);
            this.grpA.Controls.Add(this.rdoYardas2);
            this.grpA.Location = new System.Drawing.Point(216, 58);
            this.grpA.Name = "grpA";
            this.grpA.Size = new System.Drawing.Size(150, 134);
            this.grpA.TabIndex = 26;
            this.grpA.TabStop = false;
            this.grpA.Text = "A";
            // 
            // rdoPulgadas2
            // 
            this.rdoPulgadas2.AutoSize = true;
            this.rdoPulgadas2.Location = new System.Drawing.Point(15, 93);
            this.rdoPulgadas2.Name = "rdoPulgadas2";
            this.rdoPulgadas2.Size = new System.Drawing.Size(69, 17);
            this.rdoPulgadas2.TabIndex = 2;
            this.rdoPulgadas2.TabStop = true;
            this.rdoPulgadas2.Text = "Pulgadas";
            this.rdoPulgadas2.UseVisualStyleBackColor = true;
            // 
            // rdoPies2
            // 
            this.rdoPies2.AutoSize = true;
            this.rdoPies2.Location = new System.Drawing.Point(15, 54);
            this.rdoPies2.Name = "rdoPies2";
            this.rdoPies2.Size = new System.Drawing.Size(45, 17);
            this.rdoPies2.TabIndex = 1;
            this.rdoPies2.TabStop = true;
            this.rdoPies2.Text = "Pies";
            this.rdoPies2.UseVisualStyleBackColor = true;
            // 
            // rdoYardas2
            // 
            this.rdoYardas2.AutoSize = true;
            this.rdoYardas2.Location = new System.Drawing.Point(15, 19);
            this.rdoYardas2.Name = "rdoYardas2";
            this.rdoYardas2.Size = new System.Drawing.Size(58, 17);
            this.rdoYardas2.TabIndex = 0;
            this.rdoYardas2.TabStop = true;
            this.rdoYardas2.Text = "Yardas";
            this.rdoYardas2.UseVisualStyleBackColor = true;
            // 
            // grpDe
            // 
            this.grpDe.Controls.Add(this.rdoYardas);
            this.grpDe.Controls.Add(this.rdoPies);
            this.grpDe.Controls.Add(this.rdoPulgadas);
            this.grpDe.Location = new System.Drawing.Point(43, 58);
            this.grpDe.Name = "grpDe";
            this.grpDe.Size = new System.Drawing.Size(149, 134);
            this.grpDe.TabIndex = 25;
            this.grpDe.TabStop = false;
            this.grpDe.Text = "De";
            // 
            // rdoYardas
            // 
            this.rdoYardas.AutoSize = true;
            this.rdoYardas.Location = new System.Drawing.Point(16, 19);
            this.rdoYardas.Name = "rdoYardas";
            this.rdoYardas.Size = new System.Drawing.Size(58, 17);
            this.rdoYardas.TabIndex = 0;
            this.rdoYardas.TabStop = true;
            this.rdoYardas.Text = "Yardas";
            this.rdoYardas.UseVisualStyleBackColor = true;
            // 
            // rdoPies
            // 
            this.rdoPies.AutoSize = true;
            this.rdoPies.Location = new System.Drawing.Point(16, 54);
            this.rdoPies.Name = "rdoPies";
            this.rdoPies.Size = new System.Drawing.Size(45, 17);
            this.rdoPies.TabIndex = 1;
            this.rdoPies.TabStop = true;
            this.rdoPies.Text = "Pies";
            this.rdoPies.UseVisualStyleBackColor = true;
            // 
            // rdoPulgadas
            // 
            this.rdoPulgadas.AutoSize = true;
            this.rdoPulgadas.Location = new System.Drawing.Point(16, 93);
            this.rdoPulgadas.Name = "rdoPulgadas";
            this.rdoPulgadas.Size = new System.Drawing.Size(69, 17);
            this.rdoPulgadas.TabIndex = 2;
            this.rdoPulgadas.TabStop = true;
            this.rdoPulgadas.Text = "Pulgadas";
            this.rdoPulgadas.UseVisualStyleBackColor = true;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(216, 289);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 24;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnconvertir
            // 
            this.btnconvertir.Location = new System.Drawing.Point(103, 289);
            this.btnconvertir.Name = "btnconvertir";
            this.btnconvertir.Size = new System.Drawing.Size(75, 23);
            this.btnconvertir.TabIndex = 23;
            this.btnconvertir.Text = "Convertir";
            this.btnconvertir.UseVisualStyleBackColor = true;
            this.btnconvertir.Click += new System.EventHandler(this.btnconvertir_Click);
            // 
            // txtConversion
            // 
            this.txtConversion.Location = new System.Drawing.Point(216, 234);
            this.txtConversion.Name = "txtConversion";
            this.txtConversion.ReadOnly = true;
            this.txtConversion.Size = new System.Drawing.Size(100, 20);
            this.txtConversion.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Longitud convertida:";
            // 
            // txtlongitud
            // 
            this.txtlongitud.Location = new System.Drawing.Point(216, 12);
            this.txtlongitud.Name = "txtlongitud";
            this.txtlongitud.Size = new System.Drawing.Size(100, 20);
            this.txtlongitud.TabIndex = 20;
            // 
            // lbllongitudconvertir
            // 
            this.lbllongitudconvertir.AutoSize = true;
            this.lbllongitudconvertir.Location = new System.Drawing.Point(40, 19);
            this.lbllongitudconvertir.Name = "lbllongitudconvertir";
            this.lbllongitudconvertir.Size = new System.Drawing.Size(164, 13);
            this.lbllongitudconvertir.TabIndex = 19;
            this.lbllongitudconvertir.Text = "Introduzca la longitud a convertir:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 318);
            this.Controls.Add(this.grpA);
            this.Controls.Add(this.grpDe);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnconvertir);
            this.Controls.Add(this.txtConversion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtlongitud);
            this.Controls.Add(this.lbllongitudconvertir);
            this.Name = "Form3";
            this.Text = "Form3";
            this.grpA.ResumeLayout(false);
            this.grpA.PerformLayout();
            this.grpDe.ResumeLayout(false);
            this.grpDe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpA;
        private System.Windows.Forms.RadioButton rdoPulgadas2;
        private System.Windows.Forms.RadioButton rdoPies2;
        private System.Windows.Forms.RadioButton rdoYardas2;
        private System.Windows.Forms.GroupBox grpDe;
        private System.Windows.Forms.RadioButton rdoYardas;
        private System.Windows.Forms.RadioButton rdoPies;
        private System.Windows.Forms.RadioButton rdoPulgadas;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnconvertir;
        private System.Windows.Forms.TextBox txtConversion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtlongitud;
        private System.Windows.Forms.Label lbllongitudconvertir;
    }
}