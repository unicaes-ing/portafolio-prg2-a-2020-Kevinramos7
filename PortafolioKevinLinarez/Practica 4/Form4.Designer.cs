namespace Practica_4
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
            this.btnMayor = new System.Windows.Forms.Button();
            this.lblnum1 = new System.Windows.Forms.Label();
            this.lblnum2 = new System.Windows.Forms.Label();
            this.lblnum3 = new System.Windows.Forms.Label();
            this.lblmayor = new System.Windows.Forms.Label();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.txtnum3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMayor
            // 
            this.btnMayor.Location = new System.Drawing.Point(124, 126);
            this.btnMayor.Name = "btnMayor";
            this.btnMayor.Size = new System.Drawing.Size(75, 23);
            this.btnMayor.TabIndex = 0;
            this.btnMayor.Text = "Mayor";
            this.btnMayor.UseVisualStyleBackColor = true;
            this.btnMayor.Click += new System.EventHandler(this.btnMayor_Click);
            // 
            // lblnum1
            // 
            this.lblnum1.AutoSize = true;
            this.lblnum1.Location = new System.Drawing.Point(17, 20);
            this.lblnum1.Name = "lblnum1";
            this.lblnum1.Size = new System.Drawing.Size(53, 13);
            this.lblnum1.TabIndex = 1;
            this.lblnum1.Text = "Número 1";
            // 
            // lblnum2
            // 
            this.lblnum2.AutoSize = true;
            this.lblnum2.Location = new System.Drawing.Point(17, 58);
            this.lblnum2.Name = "lblnum2";
            this.lblnum2.Size = new System.Drawing.Size(53, 13);
            this.lblnum2.TabIndex = 2;
            this.lblnum2.Text = "Número 2";
            // 
            // lblnum3
            // 
            this.lblnum3.AutoSize = true;
            this.lblnum3.Location = new System.Drawing.Point(17, 95);
            this.lblnum3.Name = "lblnum3";
            this.lblnum3.Size = new System.Drawing.Size(53, 13);
            this.lblnum3.TabIndex = 3;
            this.lblnum3.Text = "Número 3";
            // 
            // lblmayor
            // 
            this.lblmayor.AutoSize = true;
            this.lblmayor.Location = new System.Drawing.Point(17, 161);
            this.lblmayor.Name = "lblmayor";
            this.lblmayor.Size = new System.Drawing.Size(39, 13);
            this.lblmayor.TabIndex = 5;
            this.lblmayor.Text = "Mayor:";
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(99, 13);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(100, 20);
            this.txtnum1.TabIndex = 6;
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(99, 51);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(100, 20);
            this.txtnum2.TabIndex = 7;
            // 
            // txtnum3
            // 
            this.txtnum3.Location = new System.Drawing.Point(99, 88);
            this.txtnum3.Name = "txtnum3";
            this.txtnum3.Size = new System.Drawing.Size(100, 20);
            this.txtnum3.TabIndex = 8;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 203);
            this.Controls.Add(this.txtnum3);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.lblmayor);
            this.Controls.Add(this.lblnum3);
            this.Controls.Add(this.lblnum2);
            this.Controls.Add(this.lblnum1);
            this.Controls.Add(this.btnMayor);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMayor;
        private System.Windows.Forms.Label lblnum1;
        private System.Windows.Forms.Label lblnum2;
        private System.Windows.Forms.Label lblnum3;
        private System.Windows.Forms.Label lblmayor;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.TextBox txtnum3;
    }
}