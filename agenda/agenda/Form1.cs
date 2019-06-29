using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace agenda
{
    public partial class Form1 : Form
    {
        public struct da
        {
            public List<string> lista;
        }
        DateTime hoy = DateTime.Now;
        public Form1()
        {
            InitializeComponent();
        }
      

       // private void btnaceptar_Click(object sender, EventArgs e)
      //  {
        //    txtfecha.Text = hoy.ToShortDateString();
        //    txthora.Text = hoy.ToShortTimeString();
       // }

        private void btnir_Click(object sender, EventArgs e)
        {
              //para llamar al formulario
          //  frminfo frm = new frminfo();
            //para mostrar el formulario y bloquea las demas ventanas
            //frm.ShowDialog();
            //no bloquea
        //   frm.Show();
          //  des = new List<descripcion>(new descripcion[] { txtdescripcion.Text });
          // descripcion de = new descripcion();
          // de.descrip = txtfecha.Text;
         // de.descrip = txthora.Text;
          // de.descrip = txtdescripcion.Text;
         // des.Add(de);
            da info;
            info.lista = new List<string>(new string[] {txts.Text });
          frminfo frm = new frminfo(info);
          //para mostrar el formulario y bloquea las demas ventanas
          frm.ShowDialog();
           //mostrar();
            


         
        }
      // private void mostrar()
        //{
          //  dataGridView1.DataSource = null;
           // dataGridView1.DataSource = ;
         //   dataGridView1.MinimumSize = 5;
         //dataGridView1.MaximumSize = 5;
       //}

       private void btnredactAR_Click(object sender, EventArgs e)
       {
           txtfecha.Text = hoy.ToShortDateString();
           txthora.Text = hoy.ToShortTimeString();
           mostrar1();

       }

    
      private void mostrar1()
        {
            label4.Text = txts.Text;
           // textBox1.Text =des;
            txts.MaxLength = 30;

        }

      

      
      

       
      
       
    }
}
