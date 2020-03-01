using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            double exa1, exa2, exa3;
            exa1 = Convert.ToDouble(txtexa1.Text);
            exa2 = Convert.ToDouble(txtexa2.Text);
            exa3 = Convert.ToDouble(txtexa3.Text);
            txtprom.Text = ((exa1 + exa2 + exa3) / 3.0).ToString("N2");
        }

        private void btnLimp_Click(object sender, EventArgs e)
        {
            txtexa1.Clear();
            txtexa2.Clear();
            txtexa3.Clear();
            txtprom.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
