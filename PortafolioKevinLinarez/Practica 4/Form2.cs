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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = Convert.ToInt32(txtnumero.Text);
                lstlista.Items.Add(numero);
                txtnumero.Clear();
                txtnumero.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese un número");
                txtnumero.SelectAll();
                txtnumero.Focus();
            }
        }
        public static int Buscar(int numbuscar, ListBox lista)
        {
            int cont = 0;
            foreach (int n in lista.Items)
            {
                if (n == numbuscar) cont++;
            }
            return cont;
        }
        private void btnbuscar_Click(object sender, EventArgs e)
        {

            try
            {
                int num = Convert.ToInt32(txtbuscar.Text);
                int cant = Buscar(num, lstlista);
                MessageBox.Show("Se encuentra " + cant + " veces ");
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese un número");
                txtbuscar.SelectAll();
                txtbuscar.Focus();
            }
        }
    }
}
