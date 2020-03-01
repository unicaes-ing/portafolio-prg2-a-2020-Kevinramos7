namespace Practica_4
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
            this.lblnum1 = new System.Windows.Forms.Label();
            this.lblnum2 = new System.Windows.Forms.Label();
            this.lblnum3 = new System.Windows.Forms.Label();
            this.lblnum4 = new System.Windows.Forms.Label();
            this.lblSuma = new System.Windows.Forms.Label();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.txtnum3 = new System.Windows.Forms.TextBox();
            this.txtnum4 = new System.Windows.Forms.TextBox();
            this.btnsuma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnum1
            // 
            this.lblnum1.AutoSize = true;
            this.lblnum1.Location = new System.Drawing.Point(24, 9);
            this.lblnum1.Name = "lblnum1";
            this.lblnum1.Size = new System.Drawing.Size(53, 13);
            this.lblnum1.TabIndex = 0;
            this.lblnum1.Text = "Número 1";
            // 
            // lblnum2
            // 
            this.lblnum2.AutoSize = true;
            this.lblnum2.Location = new System.Drawing.Point(24, 47);
            this.lblnum2.Name = "lblnum2";
            this.lblnum2.Size = new System.Drawing.Size(53, 13);
            this.lblnum2.TabIndex = 1;
            this.lblnum2.Text = "Número 2";
            // 
            // lblnum3
            // 
            this.lblnum3.AutoSize = true;
            this.lblnum3.Location = new System.Drawing.Point(24, 85);
            this.lblnum3.Name = "lblnum3";
            this.lblnum3.Size = new System.Drawing.Size(53, 13);
            this.lblnum3.TabIndex = 2;
            this.lblnum3.Text = "Número 3";
            // 
            // lblnum4
            // 
            this.lblnum4.AutoSize = true;
            this.lblnum4.Location = new System.Drawing.Point(24, 131);
            this.lblnum4.Name = "lblnum4";
            this.lblnum4.Size = new System.Drawing.Size(53, 13);
            this.lblnum4.TabIndex = 3;
            this.lblnum4.Text = "Número 4";
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Location = new System.Drawing.Point(24, 212);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(0, 13);
            this.lblSuma.TabIndex = 4;
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(92, 6);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(100, 20);
            this.txtnum1.TabIndex = 5;
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(92, 40);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(100, 20);
            this.txtnum2.TabIndex = 6;
            // 
            // txtnum3
            // 
            this.txtnum3.Location = new System.Drawing.Point(92, 78);
            this.txtnum3.Name = "txtnum3";
            this.txtnum3.Size = new System.Drawing.Size(100, 20);
            this.txtnum3.TabIndex = 7;
            this.txtnum3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtnum4
            // 
            this.txtnum4.Location = new System.Drawing.Point(92, 124);
            this.txtnum4.Name = "txtnum4";
            this.txtnum4.Size = new System.Drawing.Size(100, 20);
            this.txtnum4.TabIndex = 8;
            // 
            // btnsuma
            // 
            this.btnsuma.Location = new System.Drawing.Point(92, 165);
            this.btnsuma.Name = "btnsuma";
            this.btnsuma.Size = new System.Drawing.Size(75, 23);
            this.btnsuma.TabIndex = 9;
            this.btnsuma.Text = "Sumar";
            this.btnsuma.UseVisualStyleBackColor = true;
            this.btnsuma.Click += new System.EventHandler(this.btnsuma_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 238);
            this.Controls.Add(this.btnsuma);
            this.Controls.Add(this.txtnum4);
            this.Controls.Add(this.txtnum3);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.lblnum4);
            this.Controls.Add(this.lblnum3);
            this.Controls.Add(this.lblnum2);
            this.Controls.Add(this.lblnum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnum1;
        private System.Windows.Forms.Label lblnum2;
        private System.Windows.Forms.Label lblnum3;
        private System.Windows.Forms.Label lblnum4;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.TextBox txtnum3;
        private System.Windows.Forms.TextBox txtnum4;
        private System.Windows.Forms.Button btnsuma;
    }
}

