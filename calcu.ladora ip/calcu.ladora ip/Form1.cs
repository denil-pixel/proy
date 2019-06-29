using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calcu.ladora_ip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         public static bool IsIPv4(string value)
    {
        var quads = value.Split('.');

        // if we do not have 4 quads, return false
        if (!(quads.Length==4)) return false;

        // for each quad
        foreach(var quad in quads) 
        {
            int q;
            // if parse fails 
            // or length of parsed int != length of quad string (i.e.; '1' vs '001')
            // or parsed int < 0
            // or parsed int > 255
            // return false
            if (!Int32.TryParse(quad, out q) 
                || !q.ToString().Length.Equals(quad.Length) 
                || q < 0 
                || q > 255) { return false; }

        }

        return true;
    }

        private void button1_Click(object sender, EventArgs e)
        {
        IsIPv4();
        }
       // private void button1_Click(object sender, EventArgs e)
       // {
        //    string ipori = Convert.ToString(txt1.Text);
          //   string [] rangoipf =ipori.Split('/');
          //   if (rangoipf.Length >= 5)
          //   {
            //     MessageBox.Show("ja");
          //   }
            
           //  else
          //   {
             //    MessageBox.Show("imvalida");
           //  }
       }
    //    private void conver()
   // {
      //  double rangoip = Convert.ToDouble(txt1.Text);
      //  if (rangoip >= 0 && rangoip <= 255)
      //  {
     //       MessageBox.Show("valida");
   //     }
    //    else
    //    {
      //      MessageBox.Show("imvalida");
     //   }

   // }
      //  private void convertit()
      //  {
          //  string ipori = Convert.ToString(txt1.Text);
          //  string[] rangoipf =ipori.Split('/');
          //  if(rangoipf.Length >=0 && rangoipf.Length <=255)
         //   {
         //       MessageBox.Show("valida");
          //  }
           
 
                 
        }
      
     

    

        
    
}
