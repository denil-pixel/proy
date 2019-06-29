using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejemplo_17
{
    public partial class Form1 : Form
    {
        class persona
        {
            public string nombre { get; set; }
            public string ci { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
        }
            List<string> lista = new List<string>();
            List<persona> listap = new List<persona>();

        private void button1_Click(object sender, EventArgs e)
        {
            // lo que yo hoze
            //comboBox1.Items.Add(textBox1.Text);
           // lo ddel ing
            int i =0;
            while (i<lista.Count && lista[i]!=textBox1.Text)i++;
            if(i >= lista.Count)
                lista.Add(textBox1.Text);
          //  if (comboBox1.Items = textBox1.Text)
           // {
              //  MessageBox.Show("f");
            //}



         //   string[] lista = textBox1.Text.Split(',');

           // List<string> listaunicos = new List<string>();

            //foreach (string item in lista)
            //{

              //  if (!listaunicos.Contains(item))
               // {

                 //   listaunicos.Add(item);

//                }

  //          }
    //        textBox1.Text = string.Join(",", listaunicos.ToArray());
            //   }
            // }
        }

     
    }
}
