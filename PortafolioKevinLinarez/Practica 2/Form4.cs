using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Practica_2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
           
              bool validado = true;
              error1.Clear();
              if (txtcorreo.TextLength<0)
              {
                 error1.SetError(txtcorreo, "Ingrese un correo electronico");
                 validado = false;
              }
              else
              {
               string patroncorreo = @"^([A-Z|a-z|0-9]{2,}[@]{1}[a-z]{2,}[.]{1,})";
               if (!Regex.IsMatch(txtcorreo.Text, patroncorreo))
               {
                 error1.SetError(txtcorreo, "Ingrese un correo valido (Debe ingresar: \n @, una letra mayúscula, una minúscula y un número es obligatorio)");
                 validado = false;
               }
              }
               string patroncontraseña = @"^([A-Z]{1,}[a-z]{1,}[0-9]{1,})$";
               if (!Regex.IsMatch(txtcontraseña.Text, patroncontraseña))
               {
                error1.SetError(txtcontraseña, "Debe contener al menos: \n Una letra mayúscula, una minúscula, un número");
                validado = false;
               }
              if (txtconfirmacion.Text!=txtcontraseña.Text)
              {
                error1.SetError(txtconfirmacion, "Ingrese la misma contraseña");
              }

            
           
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
