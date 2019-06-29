using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Text.RegularExpressions;

namespace Formulario_Validado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnvalidar_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtnombre, "");
            errorProvider1.SetError(txtedad, "");
            //.SetError(GroupBox2,"");
            errorProvider1.SetError(groupBox1, "");
            errorProvider1.SetError(comboBox1, "");
            if (!Validacion.isLetras(txtnombre.Text))
            {
               // MessageBox.Show("error");
                errorProvider1.SetError(txtnombre, "solo nombre");
            }
            if (!Validacion.isEntero(txtedad.Text))
            {
                errorProvider1.SetError(txtedad, "solo numeros");
                //MessageBox.Show("error2");

            }
            if (!Validacion.isEmail(txtcorreo.Text))
            {
                //MessageBox.Show("error3");
                errorProvider1.SetError(txtcorreo, "esscribir correo");
            }
            int i = 0;
            bool seleccionado = false;

            while (i < groupBox1.Controls.Count && !seleccionado)
            {
                if (groupBox1.Controls[i] is CheckBox && ((CheckBox)groupBox1.Controls[i]) is CheckBox && ((CheckBox)groupBox1.Controls[i]).Checked)
                {
                    seleccionado = true;
                    i++;
                }
                if (!seleccionado)
                {
                    errorProvider1.SetError(groupBox1, "debe seleccionar almenos algun elemnto");
                    string select = comboBox1.SelectedItem as string;
                    if (select == null || select == string.Empty)
                    {
                        errorProvider1.SetError(comboBox1, "debe seleccionar item");
                    }






                }






                //private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
                //{
                //if(char.IsLetter(e.KeyChar))
                //{
                //  e.Handled = false;
                //}
                //else if(char.IsSeparator(e.KeyChar)){
                //  e.Handled = false;
                //}
                //else
                //{
                //e.Handled = true;
                //MessageBox.Show("solo letrar");
                //  txtnombre.CharacterCasing = CharacterCasing.Upper;
                //    txtnombre.CharacterCasing = CharacterCasing.Lower;
                //  }
                //}

                //private void txtedad_KeyPress(object sender, KeyPressEventArgs e)
                //{
                //if(char.IsDigit(e.KeyChar))
                //{
                //  e.Handled = false;
                //}
                //else if(char.IsControl(e.KeyChar))
                //{

                //  e.Handled = false;
                //}
                //else{
                //  e.Handled = true;
                //    MessageBox.Show("solo numeros");
                //  }
                //}
                //public static bool validar(string email)
                //{
                //string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
                //if (Regex.IsMatch(email, expresion))
                // {
                //if (Regex.Replace(email, expresion, string.Empty).Length == 0)
                //{
                //  return true;
                //}
                //else
                //{
                //    return false;
                //  }
                //}
                //else
                //{
                //  return false;
                //  }
                //}


                // private void txtnombre_Leave(object sender, EventArgs e)
                //{

                //if(validar(txtcorreo.Text))
                //{
                //
                //}
                //else
                //{
                //  MessageBox.Show("direccion no valida");
                //txtcorreo.SelectAll();
                //txtcorreo.Focus();
                // btnvalidar.Focus();

                // }
                //}


            }
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtnombre, "");
            if (!Validacion.isLetras(txtnombre.Text))
            {
                errorProvider1.SetError(txtnombre, "solo letras");
            }
        }

        private void txtedad_Leave(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtedad, "");
            if (!Validacion.isLetras(txtedad.Text))
            {
                errorProvider1.SetError(txtedad, "solo numeros");
            }

        }

    }
}
        

