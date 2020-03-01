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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            txtBin.Text = Convert.ToString(Convert.ToInt32(txtDec.Text), 2);
            txtOct.Text = Convert.ToString(Convert.ToInt32(txtDec.Text), 8);
            txtHex.Text = Convert.ToString(Convert.ToInt32(txtDec.Text), 16);
        }

        private void btnLimp_Click(object sender, EventArgs e)
        {
            txtDec.Clear();
            txtBin.Clear();
            txtOct.Clear();
            txtHex.Clear();
        }

        private void btnSal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
