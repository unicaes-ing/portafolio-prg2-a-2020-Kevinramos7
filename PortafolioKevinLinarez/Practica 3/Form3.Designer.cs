namespace Practica_3
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
            this.lstnumeros = new System.Windows.Forms.ListBox();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstnumeros
            // 
            this.lstnumeros.FormattingEnabled = true;
            this.lstnumeros.Location = new System.Drawing.Point(35, 12);
            this.lstnumeros.Name = "lstnumeros";
            this.lstnumeros.Size = new System.Drawing.Size(120, 264);
            this.lstnumeros.TabIndex = 0;
            // 
            // btnmostrar
            // 
            this.btnmostrar.Location = new System.Drawing.Point(52, 282);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(75, 23);
            this.btnmostrar.TabIndex = 1;
            this.btnmostrar.Text = "Mostrar";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 342);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.lstnumeros);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstnumeros;
        private System.Windows.Forms.Button btnmostrar;
    }
}