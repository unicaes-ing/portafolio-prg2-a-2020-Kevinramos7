﻿using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int c = 0;
            lstnumeros.Items.Clear();
            for (int i = 1; i < 5000; i++)
            {
                int num = r.Next(1, 7);
                if (num == 6) c++;
            }
            MessageBox.Show("Se obtuvo " + c + " veces el 6");
        }
    }
}
