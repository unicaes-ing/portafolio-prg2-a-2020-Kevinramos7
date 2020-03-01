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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            dgvnumero.Size = new Size(210, 220);
            dgvnumero.AllowUserToAddRows = false;
            dgvnumero.ScrollBars = ScrollBars.None;
            dgvnumero.ColumnCount = 10;
            dgvnumero.ColumnHeadersVisible = false;
            dgvnumero.RowHeadersVisible = false;
            dgvnumero.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Random r = new Random();
            for (int f = 0; f < 10; f++)
            {
                dgvnumero.Rows.Add();
                for (int c = 0; c < 10; c++)
                {
                    dgvnumero.Rows[f].Cells[c].Value = r.Next(10, 100);
                }
            }
            dgvnumero.ClearSelection();

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
