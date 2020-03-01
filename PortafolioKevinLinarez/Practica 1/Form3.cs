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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double inv1, inv2, inv3, tot;
            inv1 = Convert.ToDouble(txtinv1.Text);
            inv2 = Convert.ToDouble(txtinv2.Text);
            inv3 = Convert.ToDouble(txtinv3.Text);
            tot = (inv1 + inv2 + inv3);
            txtTotal.Text = String.Format("{0:N2}", tot);
            txtporc1.Text = ((inv1 / tot) * 100.0).ToString("N2") + "%";
            txtporc2.Text = ((inv2 / tot) * 100.0).ToString("N2") + "%";
            txtporc3.Text = ((inv3 / tot) * 100.0).ToString("N2") + "%";
        }

        private void btnLimp_Click(object sender, EventArgs e)
        {
            txtinv1.Clear();
            txtinv2.Clear();
            txtinv3.Clear();
            txtporc1.Clear();
            txtporc2.Clear();
            txtporc3.Clear();
            txtTotal.Clear();
        }

        private void btnSal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
