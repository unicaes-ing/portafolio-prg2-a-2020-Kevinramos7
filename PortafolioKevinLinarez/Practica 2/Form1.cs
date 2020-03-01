using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnconv_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(txtnum.Text);
                string romano = "";
                if (num >= 1 && num <= 10)
                {
                    if (num == 1)
                    {
                        romano = "I";
                    }
                    else if (num == 2)
                    {
                        romano = "II";
                    }
                    else if (num == 3)
                    {
                        romano = "III";
                    }
                    else if (num == 4)
                    {
                        romano = "IV";
                    }
                    else if (num == 5)
                    {
                        romano = "V";
                    }
                    else if (num == 6)
                    {
                        romano = "VI";
                    }
                    else if (num == 7)
                    {
                        romano = "VII";
                    }
                    else if (num == 8)
                    {
                        romano = "VIII";
                    }
                    else if (num == 9)
                    {
                        romano = "IX";
                    }
                    else if (num == 10)
                    {
                        romano = "X";
                    }
                    lblromano.Text = "Equivale a " + romano + " en romano";
                }
                else
                {
                    txtnum.Focus();
                    txtnum.SelectAll();
                    lblromano.Text = "Ingrese un numero entre 1 y 10";
                }
            }
            catch (Exception ex)
            {
                txtnum.Focus();
                txtnum.SelectAll();
                MessageBox.Show("INGRESE SOLO NUMEROS");
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
