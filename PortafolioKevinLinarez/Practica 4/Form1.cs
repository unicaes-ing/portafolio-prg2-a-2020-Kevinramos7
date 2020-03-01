using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        public static double Sumar(double n1, double n2, double n3, double n4)
        {
            return n1 + n2 + n3 + n4;
        }
        private void btnsuma_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(txtnum1.Text);
                double num2 = Convert.ToDouble(txtnum2.Text);
                double num3 = Convert.ToDouble(txtnum3.Text);
                double num4 = Convert.ToDouble(txtnum4.Text);
                lblSuma.Text = "Suma = " + Sumar(num1, num2, num3, num4).ToString();
                txtnum1.Clear();
                txtnum2.Clear();
                txtnum3.Clear();
                txtnum4.Clear();
            }
            catch
            {
                MessageBox.Show("Ingrese 4 números");
            }
        }
    }
}
