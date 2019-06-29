using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Validar_Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            conciu.Items.Clear();
            conciu.Items.Add("Potosi");
            conciu.Items.Add("Sucre");
            conciu.Items.Add("La Paz");
        }

        private void txtci_TextChanged(object sender, EventArgs e)
        {


            errorProvider1.SetError(txtci, "");
            if (!Validar.isCi(txtci.Text))
                errorProvider1.SetError(txtci, "Ingresar formato correcto");

        }

        private void btnvalidar_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtci, "");
            errorProvider1.SetError(txtip, "");
            // errorProvider1.SetError(textBox3, "");

            if (!Validar.isCi(txtci.Text))
            {
                errorProvider1.SetError(txtci, "ing");
            }
           // if (!Validar.isCi(txtip.Text))
            //{
              //  errorProvider1.SetError(txtip, "ing");
            //}
            if (!Validar.isIp(txtip.Text))
            {
                errorProvider1.SetError(txtip, "ing");
            }
            
            //combobox
           if (conciu.SelectedIndex.Equals (-1))
           {
               errorProvider1.SetError(conciu, "no vali");

            }
           else
           {
                errorProvider1.SetError(conciu, "");
            }
           // {
             //   errorProvider1.SetError(conciu, "no se selecciono");

                //aqui no selecciono ningun item del combo

        //    }

            //radiobuton
            if (radioButton1.Checked == true || radioButton2.Checked == true)
            {
               // MessageBox.Show("seleccionado");
            }
            else
            {
                errorProvider1.SetError(groupBox1, "no selecciono");
            }
            
          
        }
        //para los combobox


        private void conciu_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*conciu.Items.Clear();
            conciu.Items.Add("Potosi");
            conciu.Items.Add("Sucre");
            conciu.Items.Add("La Paz");*/
            conprov.Items.Clear();
            //combo
        switch(conciu.Text)
        {
            case "Potosi":
                {
                    
                    conprov.Items.Add("Rafael Bustillo");
                    conprov.Items.Add("Sud Chichas");
                    conprov.Items.Add("Antonio Quijarro");
                    conprov.Items.Add("Charcas");
                    conprov.Items.Add("Chayanta");
                    conprov.Items.Add("Cornelio Saavedra");
                    conprov.Items.Add("Daniel Campos");
                    conprov.Items.Add("Nor Chichas");
                    conprov.Items.Add("Tomás Frías");
                  //  conprov.Items.Add("Sud Chichas");
                    break;
                }
            case "Sucre":
                {
                    //conprov.Items.Clear();
                    conprov.Items.Add("Azurduy");
                    conprov.Items.Add("Belisario Boeto");
                    conprov.Items.Add("Hernando Siles");
                    conprov.Items.Add("Luis Calvo");
                    conprov.Items.Add("Nor Cinti");
                    conprov.Items.Add("Oropeza");
                    conprov.Items.Add("Sud Cinti");
                    conprov.Items.Add("Tomina");
                  //  conprov.Items.Add("zzzzzzzzzzzz");
                    break;
                }
            case "La Paz":
                {
                    //conprov.Items.Clear();
                    conprov.Items.Add("Abel Iturralde");
                    conprov.Items.Add("Aroma");
                    conprov.Items.Add("Bautista Saavedra");
                    conprov.Items.Add("Azurduy");
                    conprov.Items.Add("Camacho");
                    conprov.Items.Add("Caranavi");
                    conprov.Items.Add("Franz Tamayo");
                    conprov.Items.Add("Gualberto Villarroel");

                    break;
                }


        }
              
                      
               
        }

      //  private void txtip_TextChanged(object sender, EventArgs e)
        //{
          //  errorProvider1.SetError(txtip, "");
            //if (!Validar.isCi(txtip.Text))
              //  errorProvider1.SetError(txtip, "Ingresar formato correcto");

        //}

        
    }
}