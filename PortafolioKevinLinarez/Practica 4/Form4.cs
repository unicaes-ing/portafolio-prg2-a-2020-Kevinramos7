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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public static double Mayor(double numero1, double numero2, double numero3)
        {
            double num1, num2, num3;
            num1 = numero1;
            num2 = numero2;
            num3 = numero3;
            if (num1 > num2 && num1 > num3)
            {
                return num1;
            }
             else if (num2 > num1 && num2 > num3)
            {
                return num2;
            }
            else
            {
                return num3;
            }
        }
        private void btnMayor_Click(object sender, EventArgs e)
        {
            try
            {
              double numero1, numero2, numero3, mayor;
              numero1 = Convert.ToDouble(txtnum1.Text);
              numero2 = Convert.ToDouble(txtnum2.Text);
              numero3 = Convert.ToDouble(txtnum3.Text);
              mayor = Mayor(numero1, numero2, numero3);
            lblmayor.Text = string.Format("{0}", mayor);
            }
            catch (Exception)
            {

                MessageBox.Show("Ingrese todos los números");
            }
           
        }
    }
}
