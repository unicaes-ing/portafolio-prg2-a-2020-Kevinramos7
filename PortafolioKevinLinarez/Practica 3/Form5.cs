using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_3
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void grpplanilla_Enter(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
              string nombre = txtnombre.Text;
              int horas;
              double valordehora, subtotal, impuesto, total;
              horas = Convert.ToInt32(txtvalor.Text);
              valordehora = Convert.ToDouble(txtvalordehoras.Text);
              subtotal = horas * valordehora;
              impuesto = subtotal * 0.13;
              total = subtotal - impuesto;
              dgvplanilla.Rows.Add(nombre, horas, valordehora, subtotal, impuesto, total);
              dgvplanilla.ClearSelection();
              lblsubtotal.Text = "Subtotal = $" + subtotal.ToString("N2");
              lblimpuesto.Text = "Impuesto = $" + impuesto.ToString("N2");
              lbltotal.Text = "Total = $" + total.ToString("N2");
            }
            catch (Exception)
            {
                MessageBox.Show("INGRESE LOS DATOS, TODOS LOS CAMPOS SON OBLIGATORIOS");
            }
         
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtnombre.Clear();
            txtvalor.Clear();
            txtvalordehoras.Clear();
        }
    }
}
