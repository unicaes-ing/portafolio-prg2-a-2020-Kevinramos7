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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public static int Fibonacci(int num)
        {
            int a, b, c, tem;
            tem = num;
            a = 0;
            b = 1;
            for (int i = 0; i < tem; i++)
            {
                c = a;
                a = b;
                b = c + a;
            }
            return a;
        }
        private void btncalcular_Click(object sender, EventArgs e)
        {
            int num, fibo;
            num = Convert.ToInt32(txtnumero.Text);
            fibo = Fibonacci(num);
            txtfibo.Text = string.Format("{0}", fibo);
        }
    }
}
