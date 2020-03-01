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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double precio = 0, cant = 0, sub, imp, total;
            try
            {
                precio = Convert.ToDouble(txtprecio.Text);
                cant = Convert.ToDouble(txtcantidad.Text);
                sub = precio * cant;
                imp = sub * 0.13;
                total = sub + imp;
                txtsub.Text = string.Format("{0:C2}", sub);
                txtimpuesto.Text = string.Format("{0:C2}", imp);
                txttotal.Text = string.Format("{0:C2}", total);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Llene todos los datos");
            }
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            txtprecio.Clear();
            txtcantidad.Clear();
            txtimpuesto.Clear();
            txtsub.Clear();
            txttotal.Clear();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
