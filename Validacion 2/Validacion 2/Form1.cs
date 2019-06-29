using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Validacion_2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtci, "");
            errorProvider1.SetError(txtip, "");
            //errorProvider1.SetError(GroupBox2,"");
            errorProvider1.SetError(radioButton1, "");
            errorProvider1.SetError(radioButton2, "");
            if (!Validar.isEntero(txtci.Text))
            {
                errorProvider1.SetError(txtci, "so");
            }
            if (!Validar.isEntero(txtip.Text))
            {
                errorProvider1.SetError(txtip, "so");

            }
          //  if (!Validar.isEntero(radioButton1.Text))
            //{
              //  errorProvider1.SetError(radioButton1, "so");
            //}
            //if (!Validar.isEntero(radioButton1.Text))
            //{
              //  errorProvider1.SetError(radioButton2, "so");
            //}

             int i = 0;
            bool seleccionado = false;
            
            while (i < radioButton1.Controls.Count && !seleccionado)
            {
                if ( radioButton1.Controls[i] is CheckBox && ((CheckBox)radioButton1.Controls[i]) is CheckBox && ((CheckBox)radioButton1.Controls[i]).Checked)
                {
                    seleccionado = true;
                    i++;
                }
                if (!seleccionado)
                {
                    errorProvider1.SetError(radioButton1, "debe seleccionar almenos algun elemnto");
                    //string select = comboBox1.SelectedItem as string;
                    //if (select == null || select == string.Empty)
                    //{
                      //  errorProvider1.SetError(comboBox1, "debe seleccionar item");
                    }
                }
            }

        private void conbociudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> datos = new List<string>();
            datos.Add("Potosi");
            datos.Add("SUcre");
            datos.Add("La paz");


            conbociudad.DataSource = datos;
            //con .DataSource = datos;
        }





                }




        }
    

