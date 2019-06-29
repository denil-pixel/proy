using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemploValidaciones
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Button1_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox1, "");
            errorProvider1.SetError(textBox2, "");
            errorProvider1.SetError(textBox3, "");
            errorProvider1.SetError(groupBox1, "");
            errorProvider1.SetError(comboBox1, "");
            if (!ValidarDatos.isLetras(textBox1.Text)) 
                errorProvider1.SetError(textBox1,"Solo letras");
            if (!ValidarDatos.isEntero(textBox2.Text))
            {
                errorProvider1.SetError(textBox2, "Solo numeros");
            }
            if (!ValidarDatos.isEmail(textBox3.Text))
            {
                errorProvider1.SetError(textBox3, "Un correo valido");
            }
            ////verificando checkbox
            int i = 0;
            bool seleccionado = false;
            while (i < groupBox1.Controls.Count && !seleccionado )
            {
                if (groupBox1.Controls[i] is CheckBox  && ((CheckBox)groupBox1.Controls[i]).Checked)
                    seleccionado = true;
                i++;
            }
            if (!seleccionado)
                errorProvider1.SetError(groupBox1,"Debe seleccionar un elemento por lo menos");
            //para combobox
            string select=comboBox1.SelectedItem as string;
            if (select == null || select == string.Empty) {
                //select==""
                errorProvider1.SetError(comboBox1,"Debe seleccionar un item");
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox1, "");
            if (!ValidarDatos.isLetras(textBox1.Text))
                errorProvider1.SetError(textBox1, "Solo letras");
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox2, "");
            if (!ValidarDatos.isEntero(textBox2.Text))
            {
                errorProvider1.SetError(textBox2, "Solo numeros");
            }
        }

        private void TextBox2_Leave(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox2, "");
            if (!ValidarDatos.isEntero(textBox2.Text))
            {
                errorProvider1.SetError(textBox2, "Solo numeros");
            }
        }
    }
}
