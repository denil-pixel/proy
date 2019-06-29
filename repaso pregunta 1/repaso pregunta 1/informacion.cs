using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace repaso_pregunta_1
{
    public partial class informacion : Form
    {
        public informacion(frmtraje.da info)
        {
           //txtreceptor.Text = info.lista[0];
            InitializeComponent();
            label1.Text = info.lista[0];
            label2.Text = info.lista[1];
            label3.Text = info.lista[2];
            label4.Text = info.lista[3];


         //   label6.Text = datos.lista[0];
     
           // txtreceptor.Text = info.lista[1];
           // dataGridView1.DataSource = info.lista[0];
            // = info.lista[1];
            //txtreceptor.Text = info.lista[2];
            //txtreceptor.Text = info.lista[3];
        }

        public informacion(Form1.re ty)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            //label6.Text = [0];
            label6.Text = ty.lista[0];
        }
    }
}
