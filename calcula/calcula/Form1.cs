using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{

    public partial class Form1 : Form
    {
        String op = "";
        Int32 num1=0;
        Int32 num2=0;
        Int32 res=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            tbDatos.Text = tbDatos.Text + "1";
            b1.PerformClick();
       }

        private void b2_Click(object sender, EventArgs e)
        {
            tbDatos.Text = tbDatos.Text + "2";
            b2.PerformClick();
        }

        private void b3_Click(object sender, EventArgs e)
        {
            tbDatos.Text = tbDatos.Text + "3";
            b3.PerformClick();
        }

        private void b4_Click(object sender, EventArgs e)
        {
            tbDatos.Text = tbDatos.Text + "4";
            b4.PerformClick();
        }

        private void b5_Click(object sender, EventArgs e)
        {
            tbDatos.Text = tbDatos.Text + "5";
            b5.PerformClick();
        }

        private void b6_Click(object sender, EventArgs e)
        {
            tbDatos.Text = tbDatos.Text + "6";
            b6.PerformClick();
        }

        private void b7_Click(object sender, EventArgs e)
        {
            tbDatos.Text = tbDatos.Text + "7";
            b7.PerformClick();
        }

        private void b8_Click(object sender, EventArgs e)
        {
            tbDatos.Text = tbDatos.Text + "8";
            b8.PerformClick();
        }

        private void b9_Click(object sender, EventArgs e)
        {

            tbDatos.Text = tbDatos.Text + "9";
            b9.PerformClick();
        }

        private void b0_Click(object sender, EventArgs e)
        {
            tbDatos.Text = tbDatos.Text + "0";
            b0.PerformClick();
        }

        private void bce_Click(object sender, EventArgs e)
        {
            tbDatos.Text = "0";
            bce.PerformClick();
        }

        private void bigual_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToInt32(tbDatos.Text);
            switch(op)
            {

                case "+":
                    res = num1 + num2;
                    break;

                case "-":
                    res = num1 - num2;
                
                    break;
                case "*":
                    res = num1 * num2;
                    break;
                case "/":
                    res = num1 / num2;
                    break;
            }
            tbDatos.Text = res.ToString();
        }

        private void bsuma_Click(object sender, EventArgs e)
        {
            op = "+";
            num1 = Convert.ToInt32(tbDatos.Text);
            tbDatos.Text = String.Empty;
         //   bsuma.PerformClick();
        }

        private void bresta_Click(object sender, EventArgs e)
        {
            op = "-";
            num1 = Convert.ToInt32(tbDatos.Text);
            tbDatos.Text = String.Empty;

        }

        private void bmultipilicacion_Click(object sender, EventArgs e)
        {
            op = "*";
            num1 = Convert.ToInt32(tbDatos.Text);
            tbDatos.Text = String.Empty;
           // bmultipilicacion.PerformClick();
        }

        private void bdivision_Click(object sender, EventArgs e)
        {
            op = "/";
            num1 = Convert.ToInt32(tbDatos.Text);
            tbDatos.Text = String.Empty;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch(e.KeyChar.ToString())
            {

                case "0":
                    b0.PerformClick();
                    break;
              //  case "1":
                //    b1.PerformClick();
                //    break;

              //  case "2":
                 //   b2.PerformClick();
                //    break;
                //case "3":
                //    b3.PerformClick();
                  //  break;
                //case "4":
                  //  b2.PerformClick();
                    //break;
            //    case "5":
               //     b2.PerformClick();
              //      break;
             //   case "6":
             //       b2.PerformClick();
             //       break;
           //     case "7":
          //          b2.PerformClick();
          //          break;
           //     case "8":
           //         b2.PerformClick();
           //         break;
            //    case "9":
          //          b2.PerformClick();
           //         break;
             //   case "+":
              //   bsuma.PerformClick();
              //     break;
               //case "-":
             //    bresta.PerformClick();
               //   break;

               case "*":
                  bmultipilicacion.PerformClick();
                 break;

            }
        }



        }

       

        

    
        
    }
