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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lsttabla.ForeColor = Color.Red;
            lsttabla.Font = new Font("Arial", 20, FontStyle.Bold | FontStyle.Italic);
            lsttabla.Items.Clear();
            for (char letras = 'A'; letras  <= 'Z'; letras ++)
            {
                lsttabla.Items.Add(letras);
            }
            lsttabla.Items.Insert(14, 'Ñ');
        }
    }
}
